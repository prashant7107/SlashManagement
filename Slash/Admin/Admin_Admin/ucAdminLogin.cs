using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Slash.Admin.Admin_Admin
{
    public partial class ucAdminLogin : UserControl
    {
        public ucAdminLogin()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        string _id;
        string _Name;
        string _UserName;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = txtName.Text.Trim();
            string _password = txtPassword.Text.Trim();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            myConnection.Open();
            SqlCommand com = new SqlCommand("select * from Admin where Username='" + _username + "' and Password='" + _password + "'", myConnection);
            SqlDataReader rd = com.ExecuteReader();
            if (rd != null)
            {
                while (rd.Read())
                {
                    var row = dt.NewRow();
                    row["Id"] = rd["Id"];
                    row["UserName"] = rd["Username"];
                    row["Name"] = rd["Name"];
                    row["Password"] = rd["Password"];
                    dt.Rows.Add(row);
                    _id = rd["Id"].ToString().Trim();
                    _Name= rd["Name"].ToString().Trim();
                    _UserName = rd["Username"].ToString().Trim();
                }
            }
            dgvLogin.DataSource = dt;
            dgvLogin.Columns["Id"].Visible = false;
            myConnection.Close();
            if (dgvLogin.RowCount == 2)
            {

                this.Controls.Clear();
                var admin = new Admin.ucAdmin();
                admin.txtbox.Text = _id;
                admin.lbladmin.Text = _Name;
                admin.txtUsername.Text = _UserName;
                admin.Dock = DockStyle.Fill;
                this.Controls.Add(admin);
            }
            else
            {
                lblpassword.Text = "Invalid Username/Password";
                lblpassword.Visible = true;
            }
        }
    }
}
