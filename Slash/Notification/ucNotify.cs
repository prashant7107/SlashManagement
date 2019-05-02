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

namespace Slash.Notification
{
    public partial class ucNotify : UserControl
    {
        public ucNotify()
        {
            InitializeComponent();
        }
        SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void ucNotify_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = GlobalClass.StudentRetrive.StudentRetriveNotify();
            dgvStudents.Columns["Id"].Visible = false;
            //retrive();
        }
        private void retrive()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Subject", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Contact", typeof(long));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Start Time", typeof(int));
            dt.Columns.Add("End Time", typeof(int));
            dt.Columns.Add("Pending Charge", typeof(int));
            if (myConnection.State == ConnectionState.Closed)
            {
                myConnection.Open();
            }
            SqlCommand com = new SqlCommand("select stud.Id,stud.Name,stud.Address,cou.Subject,stud.Code,stud.Contact_Number,stud.Email_Id,stud.Time_Start,stud.Time_End,stud.Pending_Charge from student_entry as stud inner join Student_Education as edu on stud.EducationId = edu.Id inner join Course_List as cou on stud.CourseId = cou.Id where stud.EntryTime<DATEADD(DAY,-4,GETDATE()) order by Pending_Charge DESC", myConnection);
                                                        
            SqlDataReader rd = com.ExecuteReader();
            if (rd != null)
            {
                while (rd.Read())
                {
                    var row = dt.NewRow();
                    row["Id"] = rd["Id"];
                    row["Name"] = rd["Name"];
                    row["Address"] = rd["Address"];
                    row["Subject"] = rd["Subject"];
                    row["Code"] = rd["Code"];
                    row["Contact"] = rd["Contact_Number"];
                    row["Email"] = rd["Email_Id"];
                    row["Start Time"] = rd["Time_Start"];
                    row["End Time"] = rd["Time_End"];
                    row["Pending Charge"] = rd["Pending_Charge"];
                    dt.Rows.Add(row);
                }
            }
            dgvStudents.DataSource = dt;
            dgvStudents.Columns["Id"].Visible = false;
            myConnection.Close();
        }
    }
}
