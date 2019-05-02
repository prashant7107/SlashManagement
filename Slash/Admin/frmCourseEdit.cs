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
    public partial class frmCourseEdit : Form
    {
        public frmCourseEdit()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_ischanged != 1)
            {
                MessageBox.Show("No Changes were made!");
                return;
            }
            else
            {
                int _active = 0;
                if (_isactive == true)
                {
                    _active = 1;
                }
                else
                {
                    _active = 0;
                }
                if (validate() == false)
                {
                    return;
                }
                var context=new Db.SlashContext();
                var courseEdit = context.Course_List.Find(int.Parse(txtgetId.Text));
                courseEdit.Subject = txtCourse.Text;
                courseEdit.Status = _isactive;
                context.SaveChanges();
               
                MessageBox.Show("Updated");
                this.Close();
            }
        }
        private int _ischanged = 0;
        private int _isAddClicked = 0;
        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            _ischanged = 1;
            if(_isAddClicked==1)
            {
                validate();
            }

        }
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
        private bool _isactive;
        private void rbtnActtive_CheckedChanged(object sender, EventArgs e)
        {
            _ischanged = 1;
            _isactive = true;
        }

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            _ischanged = 1;
            _isactive = false;
        }

        private void frmCourseEdit_Load(object sender, EventArgs e)
        {
            string query = "select * from Course_List where Id ='" + txtgetId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = dt.Rows.Count;
            string _subjects = dt.Rows[0].Field<string>("Subject");
            bool _status = dt.Rows[0].Field<bool>("Status");
            txtCourse.Text = _subjects;
            if (_status == true)
            {
                rbtnActtive.Checked = true;
            }
            else
            {
                rbtnInactive.Checked = true;
            }
        }
    }
}
