using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.View
{
    public partial class ucView : UserControl
    {
        public ucView()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            ucByCourse bycourse = new ucByCourse();
            pnlSearch.Controls.Add(bycourse);
            this.Dock = DockStyle.Fill;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            ucByTime bytime = new ucByTime();
            pnlSearch.Controls.Add(bytime);
            this.Dock = DockStyle.Fill;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var byteach = new ucByTeacher();
            pnlSearch.Controls.Add(byteach);
            this.Dock = DockStyle.Fill;
        }

        private void btnEntryDate_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var bydate = new ucDateAdded();
            pnlSearch.Controls.Add(bydate);
            this.Dock = DockStyle.Fill;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var all = new ucAll();
            pnlSearch.Controls.Add(all);
            this.Dock = DockStyle.Fill;
        }
    }
}
