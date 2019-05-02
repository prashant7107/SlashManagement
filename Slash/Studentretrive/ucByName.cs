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

namespace Slash.Studentretrive
{
    public partial class ucByName : UserControl
    {
        public ucByName()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //retrive();
            dgvStudents.DataSource = GlobalClass.StudentRetrive.StudentRetriveName(txtName.Text);
            dgvStudents.Columns["Id"].Visible = false;
        }

        #region old sql retrive method
        //private void retrive()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id", typeof(int));
        //    dt.Columns.Add("Name", typeof(string));
        //    dt.Columns.Add("Address", typeof(string));
        //    dt.Columns.Add("Subject", typeof(string));
        //    dt.Columns.Add("Code", typeof(string));
        //    dt.Columns.Add("Teacher", typeof(string));
        //    dt.Columns.Add("Contact", typeof(long));
        //    dt.Columns.Add("Email", typeof(string));
        //    myConnection.Open();
        //    SqlCommand com = new SqlCommand("select stud.Id,stud.Name,stud.Address,cou.Subject,stud.Code,Tea.Teacher,stud.Contact_Number,stud.Email_Id from student_entry as stud inner join Student_Education as edu on stud.EducationId = edu.Id inner join Course_List as cou on stud.CourseId = cou.Id inner join Teachers_List as tea on stud.TeacherId = tea.Id where stud.Name LIKE '%" + txtName.Text + "%' ", myConnection);
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
        //            dt.Rows.Add(row);
        //        }
        //    }
        //    dgvStudents.DataSource = Students;
        //    dgvStudents.Columns["Id"].Visible = false;
        //    myConnection.Close();
        //}

        #endregion
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var _idget = (dgvStudents.CurrentRow.Cells["Id"].Value);
                int _id = (int)_idget;
                frmStudentParticular std = new frmStudentParticular();
                std.txtGetData.Text = _id.ToString();
                std.Show();
            }
        }
    }
}
