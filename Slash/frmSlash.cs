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
using Slash.payment;

namespace Slash
{
    public partial class frmSlash : Form
    {
        public frmSlash()
        {
            InitializeComponent();
            
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
       

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            StudentDetails.ucStudentEntry studentEntry = new StudentDetails.ucStudentEntry();
            studentEntry.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(studentEntry);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            Studentretrive.ucRetriveStudent studentretrive = new Studentretrive.ucRetriveStudent();
            studentretrive.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(studentretrive);
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            payment.ucPayment pay = new payment.ucPayment();
            pay.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(pay);
        }


        private void passToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var sms = new StatusUpdate.ucStatusChange();
            sms.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(sms);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var sms = new View.ucView();
            sms.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(sms);
        }

        private void frmSlash_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var dash = new ucDashboard();
            dash.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(dash);
            if (myConnection.State == ConnectionState.Closed)
            {
                myConnection.Open();
            }
            int _count = 0;
            SqlCommand com = new SqlCommand("select stud.Id,stud.Name from student_entry as stud where EntryTime<DATEADD(DAY,-3,GETDATE())", myConnection);
            SqlDataReader rd = com.ExecuteReader();
            if (rd != null)
            {
                while (rd.Read())
                {
                    _count++;
                }
            }
            myConnection.Close();
            if(_count>1)
            {
                btnNotify.Visible = true;
                btnNotify.Text = _count.ToString();

            }
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var acc = new Accounts.ucAccounts();
            acc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(acc);
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var pay = new Notification.ucNotify();
            pay.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(pay);

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var admin = new Admin.Admin_Admin.ucAdminLogin();
            admin.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(admin);
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var dash = new ucDashboard();
            dash.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(dash);
        }
    }
}
