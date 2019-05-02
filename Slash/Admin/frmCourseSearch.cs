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
    public partial class frmCourseSearch : Form
    {
        public frmCourseSearch()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCourseSearch.DataSource = null;
            courses.Clear();
            retrive();
        }
        List<frmCourseCls> courses = new List<frmCourseCls>();
        private void retrive()
        {
            var context=new Db.SlashContext();
            var course = context.Course_List.Where(p => (p.Subject.Contains(txtCourse.Text.Trim()) &&
                                                    !p.Subject.Contains("-- Select --")))
                                                    .OrderBy(s => s.Subject);
            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                course=context.Course_List.Where(p => !p.Subject.Contains("-- Select --"))
                    .OrderBy(s => s.Subject);
            }


            foreach (var subject in course)
            {
                frmCourseCls cObj=new frmCourseCls();
                cObj.Id = subject.Id;
                cObj.Subject = subject.Subject;
                cObj.Status = (bool)subject.Status;

                courses.Add(cObj);
            };
            
            dgvCourseSearch.DataSource = courses;
            dgvCourseSearch.Columns["Id"].Visible = false;
        }

        private int _id;
        private string _subject;
        private bool _status;
        private void dgvCourseSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var _idget = (dgvCourseSearch.CurrentRow.Cells["Id"].Value);
                _id= (int)_idget;
                var _subjectget= (dgvCourseSearch.CurrentRow.Cells["Subject"].Value);
                _subject = _subjectget.ToString().Trim();
                var _statusget= (dgvCourseSearch.CurrentRow.Cells["Status"].Value);
                _status = (bool) _statusget;

                //shwoing the edit part
                txtCourseNewName.Text = _subject;
                if (_status)
                {
                    rbtnActtive.Checked = true;
                }
                else
                {
                    rbtnInactive.Checked = true;
                }
                showhideUpdateitems(true);
             
            }
        }

        private void showhideUpdateitems(bool state)
        {
            lblCourseInvalid.Visible = false;
            lblheading.Visible = state;
            txtCourseNewName.Visible = state;
            lblStatus.Visible = state;
            rbtnActtive.Visible = state;
            rbtnInactive.Visible = state;
            btnUpdate.Visible = state;
            if (state)
            {
                pnlUpdateCourse.BackColor = Color.Tan;
                pnlUpdateCourse.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                pnlUpdateCourse.BackColor = SystemColors.AppWorkspace;
                pnlUpdateCourse.BorderStyle = BorderStyle.None;
            }
            
        }
      
        private int _ischanged = 0;
        private int _isAddClicked = 0;
        private bool _isactive;
        private void rbtnActtive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = true;
        }

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _isAddClicked = 1;
            if (_ischanged != 1 && _status==_isactive)
            {
                MessageBox.Show("No Changes were made!");
                return;
            }
            if (validate() == false)
            {
                return;
            }

            var context = new Db.SlashContext();
                var courseEdit = context.Course_List.Find(_id);
                courseEdit.Subject = txtCourseNewName.Text;
                courseEdit.Status = _isactive;
                context.SaveChanges();
                dgvCourseSearch.DataSource = null;
                courses.Clear();
                retrive();
                showhideUpdateitems(false);
                MessageBox.Show("Updated");
        }
        private bool validate()
        {
            
            if (txtCourseNewName.Text == "" || txtCourseNewName.Text == " ")
            {
                lblCourseInvalid.Visible = true;
                return false;
            }
            else
            {
                lblCourseInvalid.Visible = false;
                return true;
            }
                
        }
        private void txtCourseNewName_TextChanged(object sender, EventArgs e)
        {
            if (txtCourseNewName.Text.Trim() != _subject)
            {
                _ischanged = 1;

            }
            if (_isAddClicked == 1)
            {
                validate();
            }
        }
    }
}
