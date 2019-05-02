using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Studentretrive
{
    public partial class ucRetriveStudent : UserControl
    {
        public ucRetriveStudent()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var byname = new ucByName();
            pnlSearch.Controls.Add(byname);
            this.Dock = DockStyle.Fill;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            pnlSearch.Controls.Clear();
            var bycode = new ucByCode();
            pnlSearch.Controls.Add(bycode);
            this.Dock = DockStyle.Fill;
        }

    }
}
