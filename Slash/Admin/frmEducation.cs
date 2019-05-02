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

namespace Slash.Admin
{
    public partial class frmEducation : Form
    {
        public frmEducation()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var context = new Db.SlashContext();
            var edu = new Db.Student_Education()
            {
                Education = txtEducation.Text,
                Status = true

            };
            context.Student_Education.Add(edu);
            context.SaveChanges();
            if (MessageBox.Show("Education successfully Added!. Do you want to add another Education Level", "check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtEducation.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}
