using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Admin
{
    public partial class frmTeacherSearch : Form
    {
        public frmTeacherSearch()
        {
            InitializeComponent();
        }

        List<frmTteacherCls> teachers = new List<frmTteacherCls>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            retrive();
        }
        private void retrive()
        {
            var context=new Db.SlashContext();
            var teach = context.Teachers_List.Where(p => (p.Teacher.Contains(txtTeacher.Text.Trim()) &&
                                                       (!p.Teacher.Contains("-- Select --"))))
                                
                                    .OrderBy(p => p.Teacher);
            
            if (string.IsNullOrEmpty(txtTeacher.Text))
            {
                teach = context.Teachers_List.Where(p => !p.Teacher.Contains("-- Select --"))

                    .OrderBy(p => p.Teacher);
            }


            foreach (var teacher in teach)
            {
                frmTteacherCls cObj = new frmTteacherCls();
                cObj.Id = teacher.Id;
                cObj.Name = teacher.Teacher;
                cObj.Status = (bool)teacher.Status;
                cObj.ContactNumber = (long)teacher.Contact_num;
                cObj.Subjects = teacher.Subjects;
                cObj.Remarks = teacher.Remarks;
                cObj.Email = teacher.Email;

                teachers.Add(cObj);
            };
          
            dgvTeacherSearch.DataSource = teachers;
            dgvTeacherSearch.Columns["Id"].Visible = false;
        }


        private int _id;
        private string _name;
        private string _email;
        private string _subjects;
        private string _remarks;
        private long _contact;
        private bool _status;
        private string contactCheck;
        private void dgvTeacherSearch_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var _idget = (dgvTeacherSearch.CurrentRow.Cells["Id"].Value);
                _id = (int)_idget;
                var _nameget = (dgvTeacherSearch.CurrentRow.Cells["Name"].Value);
                _name = _nameget.ToString().Trim();
                var _contactget = (dgvTeacherSearch.CurrentRow.Cells["ContactNumber"].Value);
                _contact = (long) _contactget;
                var _subjectget = (dgvTeacherSearch.CurrentRow.Cells["Subjects"].Value);
                _subjects = _subjectget.ToString().Trim();
                var _remarksget = (dgvTeacherSearch.CurrentRow.Cells["Remarks"].Value);
                _remarks = _remarksget.ToString().Trim();
                var _statusget = (dgvTeacherSearch.CurrentRow.Cells["Status"].Value);
                _status = (bool) _statusget;
                var _emailget = (dgvTeacherSearch.CurrentRow.Cells["Email"].Value);
                _email = _emailget.ToString().Trim();


                txtNameNew.Text = _name.Trim();
                txtContact.Text = _contact.ToString().Trim();
                rtxtSubjects.Text = _subjects.Trim();
                rtxtRemarks.Text = _remarks.Trim();
                txtEmail.Text = _email.Trim();
                if (_status)
                {
                    rbtnActtive.Checked = true;
                }
                else
                {
                    rbtnInactive.Checked = true;
                }
                showHideUpdateitems(true);
                
            }
        }
        public long ParsedContact;
        int _isregisterClicked = 0;
        int _isChanged = 0;
        private bool _isactive;
        private void txtNameNew_TextChanged(object sender, EventArgs e)
        {
            if (txtNameNew.Text.Trim() != _name)
            {
                _isChanged = 1;
            }
            if (_isregisterClicked == 1)
            {
                validate();
            }
            
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (long.Parse(txtContact.Text.ToString())!=_contact)
            {
                _isChanged = 1;
            }
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.ToString().Trim() != _email.ToString().Trim()) 
            {
                _isChanged = 1;

            }
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void rtxtSubjects_TextChanged(object sender, EventArgs e)
        {
            if (rtxtSubjects.ToString().Trim() != _subjects.Trim())
            {
                _isChanged = 1;

            }
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void rtxtRemarks_TextChanged(object sender, EventArgs e)
        {
            if (rtxtRemarks.ToString().Trim() != _remarks.Trim())
            {
                _isChanged = 1;

            }
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void rbtnActtive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = true;
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = false;
            if (_isregisterClicked == 1)
            {
                validate();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_status != _isactive)
            {
                _isChanged = 1;
            }
            if (_isChanged != 1)
            {
                MessageBox.Show("No Changes were made!");
                return;
            }
           
                if (validate() == false)
                {
                    return;
                }
               var context=new Db.SlashContext();
            var teach = context.Teachers_List.Find(_id);
            teach.Teacher = txtNameNew.Text.Trim();
            teach.Contact_num = long.Parse(txtContact.Text);
            teach.Email = txtEmail.Text.Trim();
            teach.Remarks = rtxtRemarks.Text.Trim();
            teach.Subjects = rtxtSubjects.Text.Trim();
            teach.Status = _isactive;
            context.SaveChanges();
            dgvTeacherSearch.DataSource = null;
            teachers.Clear();
            retrive();
            showHideUpdateitems(false);
            MessageBox.Show("Updated");

        }

        private bool validate()
        {
            int _Chck = 0;
            if (txtNameNew.Text == "" || txtNameNew.Text == " ")
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

        public void showHideUpdateitems(bool state)
        {
            lblNameText.Visible = state;
            lblname.Visible = false;
            txtNameNew.Visible = state;

            lblContact.Visible = false;
            lblContacttext.Visible = state;
            txtContact.Visible = state;

            lblEmail.Visible = false;
            lblEmailText.Visible = state;
            txtEmail.Visible = state;

            lblSubjects.Visible = false;
            lblSubjectsText.Visible = state;
            rtxtSubjects.Visible = state;

            lblRemarks.Visible = state;
            rtxtRemarks.Visible = state;

            lblStatus.Visible = state;
            rbtnActtive.Visible = state;
            rbtnInactive.Visible = state;

            btnUpdate.Visible = state;

            if (state)
            {
                pnlUpdateArea.BackColor = Color.Tan;
                pnlUpdateArea.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                pnlUpdateArea.BackColor = SystemColors.AppWorkspace;
                pnlUpdateArea.BorderStyle = BorderStyle.None;
            }
        }


    }
}
