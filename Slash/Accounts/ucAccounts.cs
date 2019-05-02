using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Accounts
{
    public partial class ucAccounts : UserControl
    {
        public ucAccounts()
        {
            InitializeComponent();
        }

        private void btnRemaining_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            ucRemaining _remain = new ucRemaining();
            pnlSearch.Controls.Add(_remain);
            this.Dock = DockStyle.Fill;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var _income = new ucIncome();
            pnlSearch.Controls.Add(_income);
            this.Dock = DockStyle.Fill;
        }

        private void btnateacher_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var _teach = new ucByTeacher();
            pnlSearch.Controls.Add(_teach);
            this.Dock = DockStyle.Fill;
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var _course = new ucByCourse();
            pnlSearch.Controls.Add(_course);
            this.Dock = DockStyle.Fill;
        }
    }
}
