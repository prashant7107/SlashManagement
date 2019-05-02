using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Slash.View
{
    public partial class ucByTeacher : UserControl
    {
        public ucByTeacher()
        {
            InitializeComponent();
        }
     //   SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void ucByTeacher_Load(object sender, EventArgs e)
        {
            //list of Teachers.
         
            comboTeacher.DisplayMember = "Teacher";
            comboTeacher.ValueMember = "Id";
            comboTeacher.DataSource = GlobalClass.TeacherSource.TeacherSourc();
            //
        }
        int _Teacherid;
        private void comboTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewList.Clear();
            dgvStudents.DataSource = null;
            var getId = (int)comboTeacher.SelectedValue;
            _teacher = (string) comboTeacher.SelectedText;
            _Teacherid = (int)getId;
            retrive(_Teacherid);
        }
        List<View> ViewList = new List<View>();
        private string _teacher;
        private void retrive(int id)
        {
            var context = new Db.SlashContext();
            var std = context.Student_Entry.Where(s => (s.TeacherId == id) &&
                                                (s.Status==true))
                                            .OrderBy(s => s.Name);

            foreach (var student in std)
            {
                View v = new View();
                v.id = student.Id;
                v.name = student.Name;
                v.address = student.Address;

                int subid = (int)student.CourseId;
                var sub = context.Course_List.Find(subid);
                v.subject = sub.Subject;

                int tid = (int)student.TeacherId;
                var t = context.Teachers_List.Find(tid);
                v.teacher = t.Teacher;

                v.code = student.Code;
                v.contactnumber = student.Contact_Number;
                v.emailid = student.Email_Id;
                v.starttime = (int)student.Time_Start;
                v.endtime = (int)student.Time_End;
                ViewList.Add(v);
            }
            dgvStudents.DataSource = ViewList;
            dgvStudents.Columns["Id"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewByTeacher.Document = printByTeacher;
            printPreviewByTeacher.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private String providePrintLine;
        private void printByTeacher_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var context = new Db.SlashContext();
            var teacher = context.Teachers_List.Find(_Teacherid);
            _teacher = (string) teacher.Teacher;
            providePrintLine = "Student of teacher :" + _teacher;
            GlobalClass.ViewPrint.PrintViews(ViewList,e,providePrintLine);
        }
    }
}
