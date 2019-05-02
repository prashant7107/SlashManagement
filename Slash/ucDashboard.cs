using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void pcbAdmin_Click(object sender, EventArgs e)
        {

            //this.Controls.Clear();
            //var admin = new Admin.ucAdmin();
            //admin.Dock = DockStyle.Fill;
            //this.Controls.Add(admin);
            this.Controls.Clear();
            var admin = new Admin.Admin_Admin.ucAdminLogin();
            admin.Dock = DockStyle.Fill;
            this.Controls.Add(admin);
        }

        private void pcbAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            StudentDetails.ucStudentEntry studentEntry = new StudentDetails.ucStudentEntry();
            studentEntry.Dock = DockStyle.Fill;
            this.Controls.Add(studentEntry);
        }

        private void pcbEdit_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Studentretrive.ucRetriveStudent studentretrive = new Studentretrive.ucRetriveStudent();
            studentretrive.Dock = DockStyle.Fill;
            this.Controls.Add(studentretrive);
        }

        private void pcbPay_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            payment.ucPayment pay = new payment.ucPayment();
            pay.Dock = DockStyle.Fill;
            this.Controls.Add(pay);
        }

        private void pcbPass_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var sms = new StatusUpdate.ucStatusChange();
            sms.Dock = DockStyle.Fill;
            this.Controls.Add(sms);
        }

        private void pcbView_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var sms = new View.ucView();
            sms.Dock = DockStyle.Fill;
            this.Controls.Add(sms);
        }

        private void pcbAccounts_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var acc = new Accounts.ucAccounts();
            acc.Dock = DockStyle.Fill;
            this.Controls.Add(acc);
        }
    }
}
