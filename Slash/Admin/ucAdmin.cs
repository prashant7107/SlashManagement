using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Admin
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }

        private void pcbEducations_Click(object sender, EventArgs e)
        {
            View.frmEducationView edu = new View.frmEducationView();
            edu.Show();
        }

        private void pcbCourse_Click(object sender, EventArgs e)
        {
            View.frmCourseView course = new View.frmCourseView();
            course.Show();
        }

        private void pcbTeacher_Click(object sender, EventArgs e)
        {
            View.frmTeachersView teach = new View.frmTeachersView();
            teach.Show();
        }

        private void btnEducationLevelAdd_Click(object sender, EventArgs e)
        {
            frmEducation edu = new frmEducation();
            
            edu.Show();
        }

        private void btnCoursesAdd_Click(object sender, EventArgs e)
        {
            frmCourse course = new frmCourse();
            course.Show();
        }

        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            frmTeacher tea = new frmTeacher();
            tea.Show();
        }

        private void btnTeacherEdit_Click(object sender, EventArgs e)
        {
            frmTeacherSearch tea = new frmTeacherSearch();
            tea.Show();
        }

        private void btnCoursesEdit_Click(object sender, EventArgs e)
        {
            frmCourseSearch edit = new frmCourseSearch();
            edit.Show();
        }

        private void btnEducationLevelEdit_Click(object sender, EventArgs e)
        {
            frmEducationSearch edu = new frmEducationSearch();
            edu.Show();
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            Admin_Admin.frmAddAdmin admin= new Admin_Admin.frmAddAdmin();
            admin.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            Admin_Admin.frmAddAdmin admin = new Admin_Admin.frmAddAdmin();
            admin.Show();
        }

        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var change = new Admin.Admin_Admin.frmChangeAdminPassword();
            change.txtName.Text = lbladmin.Text.Trim();
            change.txtUsername.Text = txtUsername.Text.Trim();
            change.txtId.Text = txtbox.Text.Trim();
            change.Show();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            frmBackup bk = new frmBackup();
            bk.Show();
        }
    }
}
