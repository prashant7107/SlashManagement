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
    public partial class ucByCourse : UserControl
    {
        public ucByCourse()
        {
            InitializeComponent();
        }

        private void ucByCourse_Load(object sender, EventArgs e)
        {
            //list of Course and Code.
            
            comboCourse.DisplayMember = "Subject";
            comboCourse.ValueMember = "Id";
            comboCourse.DataSource = GlobalClass.CourseSource.CourseSourc();
            //
        }

        int _Courseid;
        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewList.Clear();
            dgvStudents.DataSource = null;
            var getId = (int)comboCourse.SelectedValue;
            _Courseid = (int)getId;
            retrive(_Courseid);
        }
        List<View> ViewList = new List<View>();
        public string _course;
        private void retrive(int courseid)
        {
            var context = new Db.SlashContext();
            var std = context.Student_Entry.Where(o => (o.CourseId == courseid) &&
                                                       (o.Status == true))
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            #region (print by dgvprinter)
            // DGVPrinter printer = new DGVPrinter();
            //printer.Title = "Slash Intl Academy Pvt. Ltd.";
            //printer.SubTitle = string.Format("Date : {0}", DateTime.Now.Date);
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            //printer.PageNumbers = true;
            //printer.PageNumberInHeader = false;
            //printer.PorportionalColumns = true;
            //printer.HeaderCellAlignment = StringAlignment.Near;
            ////printer.Footer = "footer section";
            //printer.FooterSpacing = 0;
            //printer.PrintDataGridView(dgvStudents);
            #endregion
            printPreviewByCourse.Document = printByCourse;
            printPreviewByCourse.ShowDialog();

        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private String providePrintLine;
        private void printByCourse_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var context = new Db.SlashContext();
            var corse = context.Course_List.Find(_Courseid);
            _course = (string)corse.Subject;
            providePrintLine = "Student in Subject :"+_course;
        GlobalClass.ViewPrint.PrintViews(ViewList,e,providePrintLine);
        }
    }
}
