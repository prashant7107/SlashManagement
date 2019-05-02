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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate() == false)
            {
                return;
            }
            else
            {
                var context= new Db.SlashContext();
                var teacher = new Db.Teachers_List()
                {
                    Teacher = txtTeacher.Text,
                    Contact_num = long.Parse(txtContact.Text),
                    Email = txtEmail.Text,
                    Subjects = rtxtSubjects.Text,
                    Remarks = rtxtRemarks.Text,
                    Status = true
                };
                context.Teachers_List.Add(teacher);
                context.SaveChanges();

               
                if (MessageBox.Show("Teacher successfully Added!. Do you want to add another Teacher", "check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtTeacher.Text = "";
                    txtContact.Text = "";
                    rtxtRemarks.Text = "";
                    rtxtSubjects.Text = "";

                }
                else
                {
                    this.Close();
                }
            }
        }
        int _isregisterClicked = 0;
        public long ParsedContact;
        private bool validate()
        {
            _isregisterClicked = 1;
            int _Chck = 0;
            if(txtTeacher.Text=="" || txtTeacher.Text==" ")
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

            if (txtContact.Text.Length != 10)
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

        private void frmTeacher_Load(object sender, EventArgs e)
        {
           
        }

        private void txtTeacher_TextChanged(object sender, EventArgs e)
        {
            if(_isregisterClicked==1)
            {
                validate();
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void rtxtSubjects_TextChanged(object sender, EventArgs e)
        {
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }
    }
}
