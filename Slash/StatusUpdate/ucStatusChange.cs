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
using Slash.Properties;

namespace Slash.StatusUpdate
{
    public partial class ucStatusChange : UserControl
    {
        public ucStatusChange()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            Students.Clear();
            retrive();
        }
        int _rem;
        List<StudentStatus> Students = new List<StudentStatus>();
        private void retrive()
        {

            var context = new Db.SlashContext();
            var stds = context.Student_Entry.Where(p =>
                    (p.Name.Contains(txtName.Text)) &&
                    (p.Status == true))
                .OrderBy(s => s.Name);
            if (string.IsNullOrEmpty(txtName.Text))
            {
                  stds =
                    from s in context.Student_Entry.Where((s=>s.Status==true))
                    orderby s.Name
                    select s;
            }
            
                

                foreach (var student in stds)
                {
                    StudentStatus std = new StudentStatus();
                    std.Id = student.Id;
                    std.Name = student.Name;
                    std.Code = student.Code;

                    int subjctid = (int)student.CourseId;
                    var sub = context.Course_List.Find(subjctid);
                    std.Subject = sub.Subject;

                    int c=std.Charge = student.Charge;
                    int p=std.Paid_charge = (int)student.Paid_Charge;
                   _rem= std.Remaining = c - p;
                   
                    Students.Add(std);

            }

            Bitmap okimage = null;
            okimage = (Bitmap)Resources.Check_mark;
            Bitmap notokimage = null;
            notokimage = Resources.cross_512;
            dgvStudents.DataSource = Students;
            dgvStudents.RowTemplate.Height = 30;
            dgvStudents.Columns["Check"].Width = 40;
            dgvStudents.Columns["Id"].Visible = false;
            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (int.Parse(row.Cells["Remaining"].Value.ToString()) == 0)
                {
                    ((DataGridViewImageCell) row.Cells["Check"]).Value = okimage;
                }
                else
                {
                    ((DataGridViewImageCell)row.Cells["Check"]).Value = notokimage;
                }
            }
            
            ((DataGridViewImageColumn) dgvStudents.Columns["Check"]).ImageLayout =DataGridViewImageCellLayout.Stretch;
            
        }

             private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var _idget = (dgvStudents.CurrentRow.Cells["Id"].Value);
            int _idss = (int)_idget;
            var r = Students.Find(x => x.Id == _idss);
            int rem = r.Remaining;
            if (rem!=0)
            {
                MessageBox.Show("Ensure Payment /n Pending Balance ='" + rem + "'");
            }
            else
            {
                if (e.RowIndex != -1 && e.ColumnIndex == 6)
                {
                   // myConnection.Open();
                    var context=new Db.SlashContext();
                    var s = context.Student_Entry.Find(_idss);
                    s.Status = false;
                    context.SaveChanges();
                    retrive();
                    
                    dgvStudents.DataSource = null;
                    Students.Clear();
                    retrive();

                    MessageBox.Show("Status Update");
                    //SqlCommand myCommand = new SqlCommand("update Student_Entry set Status=0 where Id='" + _id + "'", myConnection);
                    //myCommand.ExecuteNonQuery();
                    //myConnection.Close();
                    //MessageBox.Show("Successful");
                }
            }
                
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    }

