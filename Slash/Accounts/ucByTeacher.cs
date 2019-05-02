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
    public partial class ucByTeacher : UserControl
    {
        public ucByTeacher()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        int _Teacherid;
        string teachername;
        private void comboTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            var getId = (int)comboTeacher.SelectedValue;
            _Teacherid = (int)getId;
            GlobalClass.TeacherforTeacherSource teacherrr = Teach.Find(x => x.Id == _Teacherid);
            teachername = teacherrr.Teacher;
            count = 0;
            income = 0;
            dgvStudents.DataSource = null;
            AccountsList.Clear();
        }
        int count = 0;
        int income = 0;
        int totalBalance = 0;
        int totalcount = 0;
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
                where (EntityFunctions.TruncateTime(b.Date) >= entryDateTime && a.TeacherId == _Teacherid)
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
                    where (EntityFunctions.TruncateTime(b.Date) >= startDate && EntityFunctions.TruncateTime(b.Date) <= endDate && a.TeacherId == _Teacherid)
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
            totalBalance = income;
            income = 0;
            count = 0;

            showLabels();
        }
        List<GlobalClass.TeacherforTeacherSource> Teach = GlobalClass.TeacherSource.TeacherSourc();
        private void ucByTeacher_Load(object sender, EventArgs e)
        {
           
            comboTeacher.DisplayMember = "Teacher";
            comboTeacher.ValueMember = "Id";
            comboTeacher.DataSource = GlobalClass.TeacherSource.TeacherSourc();
        }

        private void lblTeacher_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            understandSource = 1;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(0);
           

        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private string extraLine;
        private void printTeacher_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (understandSource == 0)
            {
                extraLine = "Income of " + teachername;
            }
            if (understandSource == 1)
            {
                extraLine = "Income of " + teachername.Trim() + " for Month : " + DateTime.Now.ToString("MM") + " / " +
                            DateTime.Now.Year.ToString();
            }
            if (understandSource == 2)
            {
                extraLine = "Income of " + teachername.Trim() + " from : " + dtpFrom.Value.ToShortDateString() +
                            " to : " + dtpTo.Value.ToShortDateString();
            }
            GlobalClass.AccountsPrint.PrintAccounts(AccountsList,e,extraLine,totalcount,totalBalance);
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewTeacher.Document = printTeacher;
            printPreviewTeacher.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            understandSource = 2;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(1);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
