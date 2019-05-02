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
    public partial class frmEducationView : Form
    {
        public frmEducationView()
        {
            InitializeComponent();
        }
        List<EducationView> educations=new List<EducationView>();
        private void frmEducationView_Load(object sender, EventArgs e)
        {
            var context = new Db.SlashContext();
            var edu = context.Student_Education.Where(p => !p.Education.Contains("-- Select --"))
                .OrderBy(p => p.Education);
            foreach (var education in edu)
            {
                EducationView cv = new EducationView();
                cv.Education = education.Education;
                cv.Status = (bool)education.Status;
                educations.Add(cv);
            }
            retrive(1);
        }
        private void retrive(int a)
        {
            if (a == 1)
            {
                List<EducationView> active = new List<EducationView>();
                dgvEducation.DataSource = null;
                active.Clear();
                var temp = educations.Where(b => b.Status == true).ToList();
                active.AddRange(temp);
                dgvEducation.DataSource = active;

            }

            else if (a == 0)
            {
                List<EducationView> inactive = new List<EducationView>();
                dgvEducation.DataSource = null;
                inactive.Clear();
                var temp = educations.Where(b => b.Status == false).ToList();
                inactive.AddRange(temp);
                dgvEducation.DataSource = inactive;
            }

            else
            {
                dgvEducation.DataSource = null;
                dgvEducation.DataSource = educations;
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
