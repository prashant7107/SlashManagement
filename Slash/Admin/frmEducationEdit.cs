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
    public partial class frmEducationEdit : Form
    {
        public frmEducationEdit()
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
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("update Student_Education set Education='" + txtEducation.Text + "',Status='" + _active + "' where Id='" + int.Parse(txtgetId.Text) + "'", myConnection);
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Updated");
                this.Close();
            }

        }
        private int _ischanged = 0;
        private int _isAddClicked = 0;
        private bool validate()
        {
            _isAddClicked = 1;
            if (txtEducation.Text == "" || txtEducation.Text == " ")
            {
                lblCourse.Visible = true;
                return false;
            }
            else
                return true;
        }
        private bool _isactive;

        private void frmEducationEdit_Load(object sender, EventArgs e)
        {
            string query = "select * from Student_Education where Id ='" + txtgetId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = dt.Rows.Count;
            string _Education = dt.Rows[0].Field<string>("Education");
            bool _status = dt.Rows[0].Field<bool>("Status");
            txtEducation.Text = _Education;
            if (_status == true)
            {
                rbtnActtive.Checked = true;
            }
            else
            {
                rbtnInactive.Checked = true;
            }
        }

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

        private void txtEducation_TextChanged(object sender, EventArgs e)
        {
            _ischanged = 1;
            if (_isAddClicked == 1)
            {
                validate();
            }
        }
    }
}
