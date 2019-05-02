using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.payment
{
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }


     //   SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        int _amountpaid;
        int status = 0;
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

            if(txtAmmount.Text=="" || txtAmmount.Text==" ")
            {
                txtRemaining.Text = remaining.ToString();
            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(status==1)
            {
                int _totalPaid = int.Parse(txtPaid.Text) + int.Parse(txtAmmount.Text);
                var context = new Db.SlashContext();
                var obj = context.Student_Entry.Find(int.Parse(txtGetId.Text));
                obj.Paid_Charge = _totalPaid;
                context.SaveChanges();
                var paymentTable=new Db.Payment();
                paymentTable.StudentId = int.Parse(txtGetId.Text);
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
                this.Close();
               

            }
            else
            {
                MessageBox.Show("Please Check your values");
            }
        }
        public int remaining;
        private void frmPay_Load(object sender, EventArgs e)
        {
            var context=new Db.SlashContext();
            var pay = context.Student_Entry.Find(int.Parse(txtGetId.Text));
            remaining = (int)(pay.Charge - pay.Paid_Charge);
            txtRemaining.Text = remaining.ToString();
            //remaining = int.Parse(txtRemaining.Text);
        }
    }
}
