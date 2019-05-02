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
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Slash.View
{
    public partial class ucAll : UserControl
    {
        public ucAll()
        {
            InitializeComponent();
        }

        private int forPrint;
        List<View> ViewList = new List<View>();
        private void btnRunning_Click(object sender, EventArgs e)
        {
            forPrint = 1;
            ViewList.Clear();
            dgvStudents.DataSource = null;
            retrive(true);
        }

        private void retrive(bool a)
        {
         
            var context = new Db.SlashContext();
            var std = context.Student_Entry.Where(s=>s.Status==a).OrderBy(s=>s.Name);
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

            #region old sql to get all data
            //DataTable dt = new DataTable();
            //    dt.Columns.Add("Id", typeof(int));
            //    dt.Columns.Add("Name", typeof(string));
            //    dt.Columns.Add("Address", typeof(string));
            //    dt.Columns.Add("Subject", typeof(string));
            //    dt.Columns.Add("Code", typeof(string));
            //    dt.Columns.Add("Teacher", typeof(string));
            //    dt.Columns.Add("Contact", typeof(long));
            //    dt.Columns.Add("Email", typeof(string));
            //    dt.Columns.Add("Start Time", typeof(int));
            //    dt.Columns.Add("End Time", typeof(int));
            //    if (myConnection.State == ConnectionState.Closed)
            //    {
            //        myConnection.Open();
            //    }
            //    SqlCommand com = new SqlCommand("select stud.Id,stud.Name,stud.Address,cou.Subject,stud.Code,Tea.Teacher,stud.Contact_Number,stud.Email_Id,stud.Time_Start,stud.Time_End from student_entry as stud inner join Student_Education as edu on stud.EducationId = edu.Id inner join Course_List as cou on stud.CourseId = cou.Id inner join Teachers_List as tea on stud.TeacherId = tea.Id where stud.Status='"+a+"' order by Subject,Name", myConnection);
            //    SqlDataReader rd = com.ExecuteReader();
            //    if (rd != null)
            //    {
            //        while (rd.Read())
            //        {
            //            var row = dt.NewRow();
            //            row["Id"] = rd["Id"];
            //            row["Name"] = rd["Name"];
            //            row["Address"] = rd["Address"];
            //            row["Subject"] = rd["Subject"];
            //            row["Code"] = rd["Code"];
            //            row["Teacher"] = rd["Teacher"];
            //            row["Contact"] = rd["Contact_Number"];
            //            row["Email"] = rd["Email_Id"];
            //            row["Start Time"] = rd["Time_Start"];
            //            row["End Time"] = rd["Time_End"];
            //            dt.Rows.Add(row);

            //            #region(listing_)
            //            View v = new View();
            //            v.id = int.Parse(rd["Id"].ToString());
            //            v.name = rd["Name"].ToString();
            //            v.address = rd["Address"].ToString();
            //            v.subject = rd["Subject"].ToString();
            //            v.code = rd["Code"].ToString();
            //            v.teacher = rd["Teacher"].ToString();
            //            v.contactnumber = Int64.Parse(rd["Contact_Number"].ToString());
            //            v.emailid = rd["Email_Id"].ToString();
            //            v.starttime = int.Parse(rd["Time_Start"].ToString());
            //            v.endtime = int.Parse(rd["Time_End"].ToString());
            //            ViewList.Add(v);
            //            #endregion
            //        }
            //    }
            #endregion
            //this.BindingContext[this.dgvStudents.DataSource].EndCurrentEdit();
            //this.dgvStudents.Refresh();
            //this.dgvStudents.Parent.Refresh();
            dgvStudents.DataSource = ViewList;
            dgvStudents.Columns["Id"].Visible = false;

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            forPrint = 0;
            ViewList.Clear();
            dgvStudents.DataSource = null;
            retrive(false);
        }
       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewAll.Document = printAll;
            printPreviewAll.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;

        private String providePrintLine;
        private void printAll_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (forPrint == 0)
            {
                providePrintLine = "Student who have Completed Course";
            }

            if (forPrint == 1)
            {
                providePrintLine = "Student who are still taking Course";
            }
            GlobalClass.ViewPrint.PrintViews(ViewList,e,providePrintLine);

            #region  old code to  print page

            //e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 10));
            //e.Graphics.DrawString("Slash Intl Academy Pvt. Ltd.", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(250, 30));
            //e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 60));
            //e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 80));
            //e.Graphics.DrawString("Subject", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(220, 80));
            //e.Graphics.DrawString("Teacher", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 80));
            //e.Graphics.DrawString("Contact No.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 80));
            //e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 80));
            //e.Graphics.DrawString("Time", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(750, 80));
            //e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 100));

            //int y_axis = 130;
            //for (int i = numberOfItemsPrinted; i < ViewList.Count; i++)
            //{
            //    numberOfItemsPerPage++;

            //    if (numberOfItemsPerPage <= 25)
            //    {
            //        numberOfItemsPrinted++;

            //        if (numberOfItemsPrinted <= ViewList.Count)
            //        {
            //            e.Graphics.DrawString(ViewList[i].name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, y_axis));
            //            e.Graphics.DrawString(ViewList[i].subject, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(220, y_axis));
            //            e.Graphics.DrawString(ViewList[i].teacher, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, y_axis));
            //            e.Graphics.DrawString(ViewList[i].contactnumber.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, y_axis));
            //            e.Graphics.DrawString(ViewList[i].emailid, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(580, y_axis));
            //            e.Graphics.DrawString(ViewList[i].starttime.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(750, y_axis));
            //            e.Graphics.DrawString("-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(770, y_axis));
            //            e.Graphics.DrawString(ViewList[i].endtime.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(790, y_axis));
            //            y_axis += 30;
            //        }
            //        else
            //        {
            //            e.HasMorePages = false;
            //        }
            //    }
            //    else
            //    {
            //        numberOfItemsPerPage = 0;
            //        e.HasMorePages = true;
            //        return;
            //    }
            //}
            //e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, y_axis));
            //numberOfItemsPerPage = 0;
            //numberOfItemsPrinted = 0;
            #endregion
        }
    }
}
