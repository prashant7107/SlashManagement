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
    public partial class ucRemaining : UserControl
    {
        public ucRemaining()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void ucRemaining_Load(object sender, EventArgs e)
        {
            retrive();
        }
        int count = 0;
        int remaining = 0;
        List<Accounts> AccountsList = new List<Accounts>();
        private void retrive()
        {
            var context = new Db.SlashContext();
            var result =
                from a in context.Student_Entry
                join c in context.Course_List on a.CourseId equals c.Id
                where (a.Pending_Charge>0)
                orderby a.Pending_Charge
                select new
                {
                    a.Name,
                    a.Code,
                    c.Subject,
                    a.Email_Id,
                    a.Contact_Number,
                    a.Charge,
                    a.Paid_Charge,
                    a.Pending_Charge
                };

            foreach (var payment in result)
            {
                Accounts ac = new Accounts();
                ac.name = payment.Name;
                ac.code = payment.Code;
                ac.subject = payment.Subject;
                ac.emailid = payment.Email_Id;
                ac.contactnumber = payment.Contact_Number;
                ac.pendingAmmount = (int)payment.Pending_Charge;
                ac.ammount = (int)payment.Paid_Charge;
                ac.charge = payment.Charge;
                remaining += (int)ac.pendingAmmount;
                count++;
                AccountsList.Add(ac);

            }

            dgvStudents.DataSource = AccountsList;


            lblBalance.Text = remaining.ToString();
            lblCount.Text = count.ToString();
            count = 0;

            showLabels();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewRemainging.Document = printRemaining;
            printPreviewRemainging.ShowDialog();
        }
        int numberOfItemsPrinted = 0;
        int numberOfItemsPerPage = 0;

        private void printRemaining_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 10));
            e.Graphics.DrawString("Slash Intl Academy Pvt. Ltd.", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(250, 30));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 80));
            e.Graphics.DrawString("Subject", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(220, 80));
            e.Graphics.DrawString("Contact No.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 80));
            e.Graphics.DrawString("Email.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 80));
            e.Graphics.DrawString("Paid", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(650, 80));
            e.Graphics.DrawString("Due", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(730, 80));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 100));

            int y_axis = 130;
            for (int i = numberOfItemsPrinted; i < AccountsList.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrinted++;

                    if (numberOfItemsPrinted <= AccountsList.Count)
                    {
                        e.Graphics.DrawString(AccountsList[i].name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, y_axis));
                        e.Graphics.DrawString(AccountsList[i].subject, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(220, y_axis));
                        e.Graphics.DrawString(AccountsList[i].contactnumber.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, y_axis));
                        e.Graphics.DrawString(AccountsList[i].emailid, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, y_axis));
                        e.Graphics.DrawString("Rs "+AccountsList[i].ammount.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(655, y_axis));
                        e.Graphics.DrawString("Rs " +AccountsList[i].pendingAmmount.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(745, y_axis));
                        y_axis += 30;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, y_axis));
            e.Graphics.DrawString("Total Remaining Amount:      Rs  " + remaining, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, y_axis+30));
            e.Graphics.DrawString("Total Students:                            " + count, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, y_axis + 60));
            numberOfItemsPerPage = 0;
            numberOfItemsPrinted = 0;
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
