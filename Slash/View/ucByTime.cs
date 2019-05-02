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
    public partial class ucByTime : UserControl
    {
        public ucByTime()
        {
            InitializeComponent();
        }
        private void ucByTime_Load(object sender, EventArgs e)
        {
            //list of hours for starthr
           
            comboTime.DisplayMember = "displaym";
            comboTime.ValueMember = "valuem";
            comboTime.DataSource =GlobalClass.HoursSouce.HourSourc();
;
        }
        int _timeId;
        private void comboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewList.Clear();
            dgvStudents.DataSource = null;
            var getId = (int)comboTime.SelectedValue;
            _timeId = (int)getId;
            retrive(_timeId);
        }
        List<View> ViewList = new List<View>();
        private string _time;
        private void retrive(int id)
        {
            var context = new Db.SlashContext();
            var std = context.Student_Entry.Where(s => (s.Time_Start == id) &&
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
                _time = student.Time_Start.ToString();
                ViewList.Add(v);
            }
            dgvStudents.DataSource = ViewList;
            
            dgvStudents.Columns["Id"].Visible = false;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewByTime.Document = printByTime;
            printPreviewByTime.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private String providePrintLine;
        private void printByTime_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            providePrintLine = "Student in Time :" + _time;
            GlobalClass.ViewPrint.PrintViews(ViewList,e,providePrintLine);
        }

       
    }
}
