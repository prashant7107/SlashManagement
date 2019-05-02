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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(validate()==false)
            {
                return;
            }
            var context=new Db.SlashContext();
            var course = new Db.Course_List()
            {
                Subject = txtCourse.Text,
                Status = true

            };
            context.Course_List.Add(course);
            context.SaveChanges();
            if (MessageBox.Show("Course successfully Added!. Do you want to add another Teacher", "check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtCourse.Text = "";
            }
            else
            {
                this.Close();
            }
        }
        private int _isAddClicked = 0;
        private bool validate()
        {
            _isAddClicked = 1;
            if (txtCourse.Text == "" || txtCourse.Text == " ")
            {
                lblCourse.Visible = true;
                return false;
            }
            else
                return true;
        }
        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            if (_isAddClicked == 1)
            {
                validate();
            }
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
