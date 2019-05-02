using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slash.GlobalClass
{
   public class ViewPrint
    {
        private static int numberOfItemsPerPage=0;
        private static int numberOfItemsPrinted=0;

        public static void PrintViews(List<View.View> ViewList, PrintPageEventArgs e,string extraline)
        {
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 10));
            e.Graphics.DrawString("Slash Intl Academy Pvt. Ltd.", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(250, 30));
            e.Graphics.DrawString(extraline, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(310, 60));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 90));
            e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, 120));
            e.Graphics.DrawString("Subject", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(220, 120));
            e.Graphics.DrawString("Teacher", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("Contact No.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 120));
            e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 120));
            e.Graphics.DrawString("Time", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(750, 120));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(20, 140));

            int y_axis = 160;
            for (int i = numberOfItemsPrinted; i < ViewList.Count; i++)
            {
                numberOfItemsPerPage++;

                if (numberOfItemsPerPage <= 25)
                {
                    numberOfItemsPrinted++;

                    if (numberOfItemsPrinted <= ViewList.Count)
                    {
                        e.Graphics.DrawString(ViewList[i].name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, y_axis));
                        e.Graphics.DrawString(ViewList[i].subject, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(220, y_axis));
                        e.Graphics.DrawString(ViewList[i].teacher, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, y_axis));
                        e.Graphics.DrawString(ViewList[i].contactnumber.ToString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(450, y_axis));
                        e.Graphics.DrawString(ViewList[i].emailid, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(580, y_axis));
                        e.Graphics.DrawString(ViewList[i].starttime.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(750, y_axis));
                        e.Graphics.DrawString("-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(770, y_axis));
                        e.Graphics.DrawString(ViewList[i].endtime.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(790, y_axis));
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
            numberOfItemsPerPage = 0;
            numberOfItemsPrinted = 0;

        }
    }
}
