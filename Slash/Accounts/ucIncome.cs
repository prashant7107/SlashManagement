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
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;

namespace Slash.Accounts
{
    public partial class ucIncome : UserControl
    {
        public ucIncome()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);

        private void ucIncome_Load(object sender, EventArgs e)
        {

            
        }
        int count = 0;
        int income = 0;
        int totalincome = 0;
        int totalcount = 0;
        int understand_date = 0;
        List<Accounts> AccountsList = new List<Accounts>();
        private void retrive(int getDate)
        {
            #region oldretrive
            //AccountsList.Clear();
            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt.Columns.Add("Id", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Code", typeof(string));
            //dt.Columns.Add("Subject", typeof(string));
            //dt.Columns.Add("Email", typeof(string));
            //dt.Columns.Add("Contact", typeof(long));
            //dt.Columns.Add("Paid Ammount", typeof(int));
            //myConnection.Open();
            //SqlCommand com = new SqlCommand("select stud.Id,stud.Name,stud.Email_Id,stud.Code,cou.Subject,stud.Contact_Number,stud.Charge,stud.Paid_Charge,stud.Pending_Charge from student_entry as stud inner join Course_List as cou on stud.CourseId = cou.Id where stud.Paid_Charge>0", myConnection);
            //SqlDataReader rd = com.ExecuteReader();
            //if (rd != null)
            //{
            //    while (rd.Read())
            //    {
            //        var row = dt.NewRow();
            //        row["Id"] = rd["Id"];
            //        row["Name"] = rd["Name"];
            //        row["Code"] = rd["Code"];
            //        row["Subject"] = rd["Subject"];
            //        row["Email"] = rd["Email_Id"];
            //        row["Contact"] = rd["Contact_Number"];
            //        var _ammount=row["Paid Ammount"] = rd["Paid_Charge"];
            //        income += (int)_ammount;
            //        dt.Rows.Add(row);
            //        count++;

            //        #region(listing_)
            //        Accounts ac = new Accounts();
            //        ac.id = int.Parse(rd["Id"].ToString());
            //        ac.name = rd["Name"].ToString();
            //        ac.subject = rd["Subject"].ToString();
            //        ac.code = rd["Code"].ToString();
            //        ac.contactnumber = Int64.Parse(rd["Contact_Number"].ToString());
            //        ac.emailid = rd["Email_Id"].ToString();
            //        ac.ammount = int.Parse(rd["Paid_Charge"].ToString());
            //        AccountsList.Add(ac);
            //        #endregion
            //    }
            //}
            //dgvStudents.DataSource = dt;
            //dgvStudents.Columns["Id"].Visible = false;
            //myConnection.Close();
            //lblBalance.Text = income.ToString();
            //lblCount.Text = count.ToString();
            //totalcount = count;
            //totalincome = income;
            //income = 0;
            //count = 0;
            #endregion

            DateTime entryDateTime=DateTime.Now;

            if (getDate == 0)
            {
                entryDateTime = DateTime.Today;
            }

            if (getDate == 1)
            {
                entryDateTime = DateTime.Today.AddDays(-1);
            }

           
            
            var context = new Db.SlashContext();
            var result =
                from a in context.Student_Entry
                join b in context.Payments on a.Id equals b.StudentId
                join c in context.Course_List on a.CourseId equals c.Id
                where EntityFunctions.TruncateTime(b.Date) == entryDateTime
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

            if (getDate == 2)
            {
                entryDateTime = DateTime.Today.AddMonths(-1);
                result =
                    from a in context.Student_Entry
                    join b in context.Payments on a.Id equals b.StudentId
                    join c in context.Course_List on a.CourseId equals c.Id
                    where EntityFunctions.TruncateTime(b.Date) >= entryDateTime
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

            if (getDate == 3)
            {
                DateTime startDate = DateTime.Parse(dtpFrom.Value.ToShortDateString());
                DateTime endDate = DateTime.Parse(dtpTo.Value.ToShortDateString());
                result =
                    from a in context.Student_Entry
                    join b in context.Payments on a.Id equals b.StudentId
                    join c in context.Course_List on a.CourseId equals c.Id
                    where (EntityFunctions.TruncateTime(b.Date) >= startDate && EntityFunctions.TruncateTime(b.Date) <= endDate)
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

                income += (int) ac.ammount;
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

        private void btnToday_Click(object sender, EventArgs e)
        {
            understand_date = 1;
            dgvStudents.DataSource = null;
            AccountsList.Clear();
            retrive(0);
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewIncome.Document = printIncome;
            printPreviewIncome.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;
        private string extraLine;
        private void printIncome_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (understand_date==1)
            {
                extraLine = "Income of : " + DateTime.Now.ToShortDateString();
            }
            if (understand_date == 2)
            {
                extraLine = "Income of : " + DateTime.Now.AddDays(-1).ToShortDateString();
            }
            if (understand_date == 3)
            {
                extraLine = "Income for Month : " + DateTime.Now.ToString("MM") + " / " + DateTime.Now.Year.ToString();
            }
            if (understand_date == 4)
            {
                extraLine = "Income from : " + dtpFrom.Value.ToShortDateString() + " to : " +
                            dtpTo.Value.ToShortDateString();
            }
            GlobalClass.AccountsPrint.PrintAccounts(AccountsList,e,extraLine,totalcount,totalincome);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            understand_date = 2;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(1);
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            understand_date = 3;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            retrive(2);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Income";
            for (int i = 1; i < dgvStudents.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvStudents.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvStudents.Rows.Count; i++)
            {
                for (int j = 0; j < dgvStudents.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvStudents.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "income";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            }
            app.Quit();
        }

        string from;
        string to;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            understand_date = 4;
            AccountsList.Clear();
            dgvStudents.DataSource = null;
            AccountsList.Clear();
            retrive(3);
        }

        private void lblTotalIncome_DoubleClick(object sender, EventArgs e)
        {
            retrive(1);
        }

        private void lblTotalIncome_Click(object sender, EventArgs e)
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
