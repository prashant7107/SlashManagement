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
    public partial class frmCourseView : Form
    {
        public frmCourseView()
        {
            InitializeComponent();
        }
        private void frmCourseView_Load(object sender, EventArgs e)
        {
            var context = new Db.SlashContext();
            var course = context.Course_List.Where(p => !p.Subject.Contains("-- Select --"))
                            .OrderBy(p => p.Subject);
            foreach (var sub in course)
            {
                CourseView cv = new CourseView();
                cv.Subject = sub.Subject;
                cv.Status = (bool)sub.Status;
                courses.Add(cv);
            }
            retrive(1);
        }
        List<CourseView> courses=new List<CourseView>();
        private void retrive(int a)
        {
            if (a==1)
            {
                List<CourseView> active =new List<CourseView>();
                dgvCourse.DataSource = null;
                active.Clear();
                var temp = courses.Where(b => b.Status == true).ToList();
                active.AddRange(temp);
                dgvCourse.DataSource = active;

            }

            else if (a==0)
            {
                List<CourseView> inactive = new List<CourseView>();
                dgvCourse.DataSource = null;
                inactive.Clear();
                var temp= courses.Where(b => b.Status == false).ToList();
                inactive.AddRange(temp);
                dgvCourse.DataSource = inactive;
            }

            else
            {
                dgvCourse.DataSource = null;
                dgvCourse.DataSource = courses;
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
            retrive(2);
        }
    }
}
