using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Configuration;

namespace Slash.payment
{
    public partial class ucPayment : UserControl
    {
        public ucPayment()
        {
            InitializeComponent();
        }

        // SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            Students.Clear();
            retrive();
        }

        private int rem;
            List<StudentPayment> Students = new List<StudentPayment>();
            private void retrive()
            {
                
                var context = new Db.SlashContext();
                var stds = context.Student_Entry.Where(p =>
                        (p.Name.Contains(txtName.Text)) &&
                        (p.Status == true))
                    .OrderBy(s => s.Name);
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    stds =
                        from s in context.Student_Entry.Where((s => s.Status == true))
                        orderby s.Name
                        select s;
                }



                foreach (var student in stds)
                {
                    StudentPayment std = new StudentPayment();
                    std.Id = student.Id;
                    std.Name = student.Name;
                    std.Code = student.Code;

                    int subjctid = (int)student.CourseId;
                    var sub = context.Course_List.Find(subjctid);
                    std.Subject = sub.Subject;

                    int c = std.Charge = student.Charge;
                    int p = std.Paid_charge = (int)student.Paid_Charge;
                    rem = std.Remaining = c - p;

                    Students.Add(std);

                }
            dgvStudents.DataSource = Students;
            dgvStudents.Columns["Id"].Visible = false;
        }

        private int paidCharge;
        private int _id;
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            retrive();
            if (e.RowIndex != -1)
            {
                var _idget = (dgvStudents.CurrentRow.Cells["Id"].Value);
                 _id= (int)_idget;
               var _name = (dgvStudents.CurrentRow.Cells["Name"].Value);
                string _n = (string)_name;
                var _pchrg = (dgvStudents.CurrentRow.Cells["Paid_charge"].Value);
                paidCharge = int.Parse(_pchrg.ToString());
                var _cash = (dgvStudents.CurrentRow.Cells["Remaining"].Value);
                remaining = (int)_cash;
                txtRemaining.Text = remaining.ToString();
                lblSetName.Text = _n;
                displayPaySheet();
                




                //frmPay std = new frmPay();
                //std.txtGetId.Text = _id.ToString();
                //std.txtRemaining.Text = _rem.ToString();
                //std.lblName.Text = _n;
                //std.txtPaid.Text = (string)_pchrg.ToString();
                //std.ShowDialog();
            }
        }


        int _amountpaid;
        int status = 0;
        public int remaining;
        private void hidePaySheet()
        {
            lblStudentName.Visible = false;
            lblSetName.ResetText();
            lblSetName.Visible = false;
            lblBalance.Visible = false;
            txtRemaining.Visible = false;
            txtAmmount.Visible = false;
            txtAmmount.Text = "";
            lblAmmount.Visible = false;
            btnPay.Visible = false;
            pnlPaymentSection.BackColor=SystemColors.AppWorkspace;
            pnlPaymentSection.BorderStyle = BorderStyle.None;
        }

        private void displayPaySheet()
        {
            pnlPaymentSection.BackColor=Color.Tan;
            pnlPaymentSection.BorderStyle = BorderStyle.Fixed3D;
            lblStudentName.Visible = true;
            lblSetName.Visible = true;
            lblBalance.Visible = true;
            txtRemaining.Visible = true;
            txtAmmount.Visible = true;
            lblAmmount.Visible = true;
            btnPay.Visible = true;
        }
       
        private void ucPayment_Load(object sender, EventArgs e)
        {
        }

        private void txtAmmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmmount.Text, out _amountpaid))
            {
                if (remaining >= int.Parse(txtAmmount.Text))
                {
                    int pay = int.Parse(txtAmmount.Text);
                    int remain = remaining - pay;
                    txtRemaining.Text = remain.ToString();
                    status = 1;
                }

                if (remaining < int.Parse(txtAmmount.Text))
                {
                    txtRemaining.Text = remaining.ToString();
                    status = 0;
                }

            }

            else { status = 0; }

            if (txtAmmount.Text == "" || txtAmmount.Text == " ")
            {
                txtRemaining.Text = remaining.ToString();
            }
        }
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (status == 1)
            {
                int _totalPaid = paidCharge + int.Parse(txtAmmount.Text);
                var context = new Db.SlashContext();
                var obj = context.Student_Entry.Find(_id);
                obj.Paid_Charge = _totalPaid;
                context.SaveChanges();
                var paymentTable = new Db.Payment();
                paymentTable.StudentId = _id;
                paymentTable.Ammount_Payment = int.Parse(txtAmmount.Text);
                paymentTable.Date = DateTime.Now;
                context.Payments.Add(paymentTable);
                context.SaveChanges();
                MessageBox.Show("Successful");
                //myConnection.Open();
                //SqlCommand myCommand = new SqlCommand("update Student_Entry set Paid_Charge='" + _totalPaid + "' where Id='" + int.Parse(txtGetId.Text) + "'", myConnection);
                //myCommand.ExecuteNonQuery();
                //SqlCommand Pay = new SqlCommand("insert into Payment (StudentId,Ammount_Payment,Date) values('"+int.Parse(txtGetId.Text)+"','"+int.Parse(txtAmmount.Text)+"','"+System.DateTime.Now+"')",myConnection);
                //Pay.ExecuteNonQuery();
                //myConnection.Close();
                dgvStudents.DataSource = null;
                Students.Clear();
                retrive();
                hidePaySheet();
            }
            else
            {
                MessageBox.Show("Please Check your values");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hidePaySheet();
        }
    }
}
