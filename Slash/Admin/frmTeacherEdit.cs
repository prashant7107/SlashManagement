using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Admin
{
    public partial class frmTeacherEdit : Form
    {
        public frmTeacherEdit()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_isChanged != 1)
            {
                MessageBox.Show("No Changes were made!");
                return;
            }
            else
            {
                if (validate() == false)
                {
                    return;
                }
                else
                { int _active = 0;
                    if (_isactive == true)
                    {
                        _active = 1;
                    }
                    else
                    {
                        _active = 0;
                    }

                    myConnection.Open();
                    SqlCommand myCommand = new SqlCommand("update Teachers_List set Teacher='" + txtTeacher.Text + "',Contact_num='" + long.Parse(txtContact.Text) + "',Subjects='" + rtxtSubjects.Text + "',Remarks='" + rtxtRemarks.Text + "',Email='" + txtEmail.Text + "',Status='" + _active + "' where Id='" + int.Parse(txtgetId.Text) + "'", myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("Updated");
                    this.Close();
                }
            }
        }
        public long ParsedContact;
        private bool validate()
        {
            int _Chck = 0;
            if (txtTeacher.Text == "" || txtTeacher.Text == " ")
            {
                lblname.Visible = true;
                _Chck = 1;
            }
            if (!long.TryParse(txtContact.Text, out ParsedContact))
            {
                lblContact.Visible = true;
                _Chck = 1;
            }
            if (txtContact.Text == "" || txtContact.Text == " ")
            {
                lblContact.Visible = true;
                _Chck = 1;
            }
            string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(txtEmail.Text, EmailPattern))
            {
                lblEmail.Visible = true;
                _Chck = 1;
            }
            if (txtEmail.Text == "" || txtEmail.Text == " ")
            {
                lblEmail.Visible = true;
                _Chck = 1;
            }
            if (rtxtSubjects.Text == "" || rtxtSubjects.Text == " ")
            {
                lblname.Visible = true;
                _Chck = 1;
            }
            if (_Chck == 1)
            {
                return false;
            }

            else
                return true;
        }
        int _isregisterClicked = 0;
        int _isChanged = 0;
        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void rtxtSubjects_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void rtxtRemarks_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void frmTeacherEdit_Load(object sender, EventArgs e)
        {
            string query = "select * from Teachers_List where Id ='" + txtgetId.Text + "'";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string _name = dt.Rows[0].Field<string>("Teacher");
            long _contact = dt.Rows[0].Field<long>("Contact_num");
            string _subjects = dt.Rows[0].Field<string>("Subjects");
            string _email = dt.Rows[0].Field<string>("Email");
            string _remarks = dt.Rows[0].Field<string>("Remarks");
            bool _status = dt.Rows[0].Field<bool>("Status");
            txtTeacher.Text = _name;
            txtContact.Text = _contact.ToString();
            txtEmail.Text = _email;
            rtxtSubjects.Text = _subjects;
            rtxtRemarks.Text = _remarks;
            if (_status == true)
            {
                rbtnActtive.Checked = true;
            }
            else
            {
                rbtnInactive.Checked = true;
            }
        }
        private bool _isactive;
        private void rbtnActtive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = true;
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = false;
            if (_isregisterClicked == 1)
            {
                validate();
            }
            _isChanged = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
