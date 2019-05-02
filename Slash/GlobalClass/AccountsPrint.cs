using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
  public  static  class AccountsPrint
  {
        private static int numberOfItemsPerPage=0;
        private static int numberOfItemsPrinted = 0;

        public static void PrintAccounts(List<Accounts.Accounts> AccountsList, PrintPageEventArgs e,
           string extraline, int totalcount, int totalincome)
        {
           
                e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(),
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 10));
                e.Graphics.DrawString("Slash Intl Academy Pvt. Ltd.", new Font("Arial", 16, FontStyle.Bold),
                    Brushes.Black, new Point(250, 30));
                e.Graphics.DrawString(extraline, new Font("Arial", 16, FontStyle.Bold), Brushes.Black,
                    new Point(310, 60));
                e.Graphics.DrawString(
                    "---------------------------------------------------------------------------------------------------------------------------------------------",
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 90));
                e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black,
                    new Point(30, 120));
                e.Graphics.DrawString("Subject", new Font("Arial", 12, FontStyle.Regular), Brushes.Black,
                    new Point(220, 120));
                e.Graphics.DrawString("Contact No.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black,
                    new Point(400, 120));
                e.Graphics.DrawString("Email.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black,
                    new Point(550, 120));
                e.Graphics.DrawString("Paid", new Font("Arial", 12, FontStyle.Regular), Brushes.Black,
                    new Point(700, 120));
                e.Graphics.DrawString(
                    "---------------------------------------------------------------------------------------------------------------------------------------------",
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 140));

                int y_axis = 160;
                for (int i = numberOfItemsPrinted; i < AccountsList.Count; i++)
                {
                    numberOfItemsPerPage++;

                    if (numberOfItemsPerPage <= 25)
                    {
                        numberOfItemsPrinted++;

                        if (numberOfItemsPrinted <= AccountsList.Count)
                        {
                            e.Graphics.DrawString(AccountsList[i].name, new Font("Arial", 12, FontStyle.Regular),
                                Brushes.Black, new Point(30, y_axis));
                            e.Graphics.DrawString(AccountsList[i].subject, new Font("Arial", 10, FontStyle.Regular),
                                Brushes.Black, new Point(220, y_axis));
                            e.Graphics.DrawString(AccountsList[i].contactnumber.ToString(),
                                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(400, y_axis));
                            e.Graphics.DrawString(AccountsList[i].emailid, new Font("Arial", 11, FontStyle.Regular),
                                Brushes.Black, new Point(555, y_axis));
                            e.Graphics.DrawString("Rs " + AccountsList[i].ammount.ToString(),
                                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(705, y_axis));
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

                e.Graphics.DrawString(
                    "---------------------------------------------------------------------------------------------------------------------------------------------",
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, y_axis - 10));
                e.Graphics.DrawString("Total income :      Rs  " + totalincome,
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, y_axis + 30));
                e.Graphics.DrawString("Total Students:            " + totalcount,
                    new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, y_axis + 60));
                numberOfItemsPerPage = 0;
                numberOfItemsPrinted = 0;
            }
        }
}
