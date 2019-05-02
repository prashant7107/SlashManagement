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

namespace Slash.Accounts
{
    public partial class ucByCourse : UserControl
    {
        public ucByCourse()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        int _CourseId;

        string coursename;
        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            AccountsList.Clear();
            var getId = (int)comboCourse.SelectedValue;
            _CourseId = (int)getId;
            GlobalClass.CourseforCourseSource_ courseee = courses.Find(x => x.Id == _CourseId);
            coursename = courseee.Subject;
            count = 0;
            income = 0;
        }
        int count = 0;
        int income = 0;
        int totalcount = 0;
        int totalincome = 0;
        int understandSource;
        List<Accounts> AccountsList = new List<Accounts>();
        private void retrive(int getDate)
        {
            DateTime entryDateTime = DateTime.Today.AddMonths(-1);
            var context = new Db.SlashContext();
            var result =
                from a in context.Student_Entry
                join b in context.Payments on a.Id equals b.StudentId
                join c in context.Course_List on a.CourseId equals c.Id
                where (EntityFunctions.TruncateTime(b.Date) >= entryDateTime && a.CourseId==_CourseId)
                orderby b.Ammount_Payment
                select new
                {
                    a.Name,
                    a.Code,
                    c.Subject,
                    a.Email_Id,
                    a.Contact_Number,
                    b.Ammount_Payment
                };
            if (getDate == 1)
            {
                DateTime startDate = DateTime.Parse(dtpFrom.Value.ToShortDateString());
                DateTime endDate = DateTime.Parse(dtpTo.Value.ToShortDateString());
                result =
                    from a in context.Student_Entry
                    join b in context.Payments on a.Id equals b.StudentId
                    join c in context.Course_List on a.CourseId equals c.Id
                    where (EntityFunctions.TruncateTime(b.Date) >= startDate && EntityFunctions.TruncateTime(b.Date) <= endDate && a.CourseId==_CourseId)
                    orderby b.Ammount_Payment
                    select new
                    {
                        a.Name,
                        a.Code,
                        c.Subject,
                        a.Email_Id,
                        a.Contact_Number,
                        b.Ammount_Payment
                    };

            }
            foreach (var payment in result)
            {
                Accounts ac = new Accounts();
                ac.name = payment.Name;
                ac.code = payment.Code;
                ac.subject = payment.Subject;
                ac.emailid = payment.Email_Id;
                ac.contactnumber = payment.Contact_Number;
                ac.ammount = (int)payment.Ammount_Payment;

                income += (int)ac.ammount;
                count++;
                AccountsList.Add(ac);

            }

            dgvStudents.DataSource = AccountsList;
            dgvStudents.Columns["pendingAmmount"].Visible = false;
            dgvStudents.Columns["charge"].Visible = false;

            lblBalance.Text = income.ToString();
            lblCount.Text = count.ToString();
            totalcount = count;
            totalincome = income;
            income = 0;
            count = 0;

            showLabels();
        }
        List<GlobalClass.CourseforCourseSource_> courses = GlobalClass.CourseSource.CourseSourc();
        private void ucByCourse_Load(object sender, EventArgs e)
        {
            //list of Course and Code.
            
            comboCourse.DisplayMember = "Subject";
            comboCourse.ValueMember = "Id";
            comboCourse.DataSource = GlobalClass.CourseSource.CourseSourc();
            //
        }

        private void lblCourse_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            understandSource = 1;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(0);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            understandSource = 0;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(1);
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewCourse.Document = printCourse;
            printPreviewCourse.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private string providePrintLine;
        private void printCourse_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (understandSource == 0)
                providePrintLine = "Income from " + coursename;
            if (understandSource == 1)
                providePrintLine = "Income from " + coursename.Trim() + " for Month : " + DateTime.Now.ToString("MM") + " / " + DateTime.Now.Year.ToString();
            if (understandSource == 2)
                providePrintLine = "Income from " + coursename.Trim() + " from : " + dtpFrom.Value.ToShortDateString() +
                                   " to : " + dtpTo.Value.ToShortDateString();
                GlobalClass.AccountsPrint.PrintAccounts(AccountsList, e, providePrintLine,totalcount,totalincome);
        }
        private void showLabels()
        {
            lblBalance.Visible = true;
            lblBalanceText.Visible = true;
            lblCount.Visible = true;
            lblCountText.Visible = true;
        }
    }
}
