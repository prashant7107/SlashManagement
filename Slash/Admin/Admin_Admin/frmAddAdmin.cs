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
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
        }

      //  SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == false)
            {
                return;
            }

            List<AddAdmin> admins=new List<AddAdmin>();
            var context=new Db.SlashContext();
            var admin = new Db.Admin()
            {
                Name = txtName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
                
            };
            context.Admins.Add(admin);
            context.SaveChanges();
            
            //myConnection.Open();
            //SqlCommand myCommand = new SqlCommand("insert into Admin (Name,Username,Password) values('" + txtName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')", myConnection);
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
            if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
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
