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

namespace Slash.Admin.View
{
    public partial class frmTeachersView : Form
    {
        public frmTeachersView()
        {
            InitializeComponent();
        }

        List<TeacherView> teachers=new List<TeacherView>();
        private void frmTeachersView_Load(object sender, EventArgs e)
        {
            var context = new Db.SlashContext();
            var t = context.Teachers_List.Where(p => !p.Teacher.Contains("-- Select --"))
                .OrderBy(p => p.Teacher);
            foreach (var teacher in t)
            {
                TeacherView cv = new TeacherView();
                cv.Name = teacher.Teacher;
                cv.ContactNumber = (long)teacher.Contact_num;
                cv.Subjects = teacher.Subjects;
                cv.Remarks = teacher.Remarks;
                cv.Status = (bool)teacher.Status;
                cv.Email = teacher.Email;
                teachers.Add(cv);
            }
            retrive(1);
        }
        private void retrive(int a)
        {
            if (a == 1)
            {
                List<TeacherView> active = new List<TeacherView>();
                dgvTeachers.DataSource = null;
                active.Clear();
                var temp = teachers.Where(b => b.Status == true).ToList();
                active.AddRange(temp);
                dgvTeachers.DataSource = active;

            }

            else if (a == 0)
            {
                List<TeacherView> inactive = new List<TeacherView>();
                dgvTeachers.DataSource = null;
                inactive.Clear();
                var temp = teachers.Where(b => b.Status == false).ToList();
                inactive.AddRange(temp);
                dgvTeachers.DataSource = inactive;
            }

            else
            {
                dgvTeachers.DataSource = null;
                dgvTeachers.DataSource = teachers;
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            retrive(1);
        }
       
        private void btninactive_Click(object sender, EventArgs e)
        {
            retrive(0);
        }
      
        private void btnAll_Click(object sender, EventArgs e)
        {
            retrive(3);
        }
    }
}
