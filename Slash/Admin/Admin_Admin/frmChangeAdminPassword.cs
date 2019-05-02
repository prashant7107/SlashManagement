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

namespace Slash.Admin.Admin_Admin
{
    public partial class frmChangeAdminPassword : Form
    {
        public frmChangeAdminPassword()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == false)
            {
                return;
            }
            var context=new Db.SlashContext();
            var admin = context.Admins.Find(int.Parse(txtId.Text.Trim()));
            admin.Name = txtName.Text.Trim();
            admin.Username = txtUsername.Text.Trim();
            admin.Password = txtPassword.Text.Trim();
            context.SaveChanges();
            //myConnection.Open();
            //SqlCommand myCommand = new SqlCommand("update Admin set Name='"+txtName.Text.Trim()+"', Username='"+txtUsername.Text.Trim()+"', Password='"+txtPassword.Text.Trim()+"' where Id='" + txtId.Text.Trim()+ "'", myConnection);
            //myCommand.ExecuteNonQuery();
            //myConnection.Close();
            MessageBox.Show("Successful");
            this.Close();
        }
        private bool validation()
        {
            int _chck = 0;

            if (txtUsername.Text == "" || txtUsername.Text == " ")
            {
                lblUsername.Visible = true;
                _chck = 1;
            }
            if (txtPassword.Text == "" || txtPassword.Text == " ")
            {
                lblpassword.Visible = true;
                _chck = 1;
            }
            if (txtUsername.Text.Trim() == txtConfirmPassword.Text.Trim())
            {
                lblConfirmPassword.Visible = true;
                _chck = 1;
            }
            if (_chck == 1)
                return false;
            else
                return true;
        }
    }
}
