using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Admin
{
    public partial class frmEducationSearch : Form
    {
        public frmEducationSearch()
        {
            InitializeComponent();
        }
      //  SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEducationSearch.DataSource = null;
            educations.Clear();
            retrive();
        }
        List<frmEducationCls> educations=new List<frmEducationCls>();
        private void retrive()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Id", typeof(int));
            //dt.Columns.Add("Education", typeof(string));
            //dt.Columns.Add("Active", typeof(bool));
            //myConnection.Open();
            //SqlCommand com = new SqlCommand("select * from Student_Education where Education LIKE '%" + txtEducation.Text + "%'", myConnection);
            //SqlDataReader rd = com.ExecuteReader();
            //if (rd != null)
            //{
            //    while (rd.Read())
            //    {
            //        var row = dt.NewRow();
            //        row["Id"] = rd["Id"];
            //        row["Education"] = rd["Education"];
            //        row["Active"] = rd["Status"];
            //        dt.Rows.Add(row);
            //    }
            //}

            var context = new Db.SlashContext();
            var edu = context.Student_Education.Where(p => (p.Education.Contains(txtEducation.Text.Trim()) &&
                                                            (!p.Education.Contains("-- Select --"))))
                                                                .OrderBy(s => s.Education);
            if (string.IsNullOrEmpty(txtEducation.Text))
            {
                edu =
                    context.Student_Education.Where(p => !p.Education.Contains("-- Select --"))
                                              .OrderBy(s => s.Education);
            }


            foreach (var subject in edu)
            {
                frmEducationCls cObj = new frmEducationCls();
                cObj.Id = subject.Id;
                cObj.Education = subject.Education;
                cObj.Status = (bool)subject.Status;

                educations.Add(cObj);
            };

            dgvEducationSearch.DataSource = educations;
            dgvEducationSearch.Columns["Id"].Visible = false;
            //myConnection.Close();
        }

        private int _id;
        private string _educations;
        private bool _status;
        private void dgvCourseSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var _idget = (dgvEducationSearch.CurrentRow.Cells["Id"].Value);
                _id = (int)_idget;
                var _educationget= (dgvEducationSearch.CurrentRow.Cells["Education"].Value);
                _educations = _educationget.ToString().Trim();
                var _statusget= (dgvEducationSearch.CurrentRow.Cells["Status"].Value);
                _status = (bool) _statusget;



                //showing the update area
                txtEducationNew.Text = _educations.Trim();
                if (_status)
                {
                    rbtnActtive.Checked = true;
                }
                else
                {
                    rbtnInactive.Checked = true;
                }
                hideshowUpdateitems(true);
            }
        }

        private void hideshowUpdateitems(bool state)
        {
            lblEducationInvalid.Visible = false;
            lblHeading.Visible = state;
            txtEducationNew.Visible = state;
            lblStatus.Visible = state;
            rbtnActtive.Visible = state;
            rbtnInactive.Visible = state;
            btnUpdate.Visible = true;
            if (state)
            {
                pnlupdateEducation.BackColor = Color.Tan;
                pnlupdateEducation.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                pnlupdateEducation.BackColor = SystemColors.AppWorkspace;
                pnlupdateEducation.BorderStyle = BorderStyle.None;
            }
            
        }

     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _isAddClicked = 1;
            if (_ischanged != 1 && _status==_isactive)
            {
                MessageBox.Show("No Changes were made!");
                return;
            }
            
                if (validate() == false)
                {
                    return;
                }

            var context = new Db.SlashContext();
            var courseEdit = context.Student_Education.Find(_id);
            courseEdit.Education = txtEducationNew.Text;
            courseEdit.Status = _isactive;
            context.SaveChanges();
            dgvEducationSearch.DataSource = null;
            educations.Clear();
            retrive();
            hideshowUpdateitems(false);
            MessageBox.Show("Updated");

              
        }
        private bool validate()
        {
            if (txtEducationNew.Text == "" || txtEducationNew.Text == " ")
            {
                lblEducationInvalid.Visible = true;
                return false;
            }
            else
            {
                lblEducationInvalid.Visible = false;
                return true;
            }
        }
        private bool _isactive;
        private int _ischanged = 0;
        private int _isAddClicked = 0;

        private void rbtnActtive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = true;
        }
    

        private void rbtnInactive_CheckedChanged(object sender, EventArgs e)
        {
            _isactive = false;
        }

        private void txtEducationNew_TextChanged(object sender, EventArgs e)
        {
            if (txtEducationNew.Text.Trim() != _educations.Trim())
            {
                _ischanged=1;
            }
        if (_isAddClicked == 1)
            {
                validate();
            }
        }
    }
}
