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
using System.Data.Entity.Core.Objects;

namespace Slash.View
{
    public partial class ucDateAdded : UserControl
    {
        public ucDateAdded()
        {
            InitializeComponent();
        }
      //  SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);

        private void ucDateAdded_Load(object sender, EventArgs e)
        {
            _date = System.DateTime.Now.Date;
            retrive();
        }
        List<View> ViewList = new List<View>();
        private void retrive()
        {
            var context = new Db.SlashContext();
            var std = context.Student_Entry.Where(s => (EntityFunctions.TruncateTime(s.EntryTime) == _date) &&
                                                       (s.Status == true))
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
        DateTime _date;
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ViewList.Clear();
            dgvStudents.DataSource = null;
            _date = dtpDate.Value.Date;
            retrive();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewByDate.Document = printBydate;
            printPreviewByDate.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private String providePrintLine;
        private void printBydate_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            providePrintLine = "Student registered on :" + dtpDate.Value.ToShortDateString();
            GlobalClass.ViewPrint.PrintViews(ViewList,e,providePrintLine);
        }
    }

}
