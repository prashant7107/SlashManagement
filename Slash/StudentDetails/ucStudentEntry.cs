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
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.Entity.Validation;

namespace Slash.StudentDetails
{
    public partial class ucStudentEntry : UserControl
    {
        public ucStudentEntry()
        {
            InitializeComponent();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        // SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        string _gender;
        int _isRegisterClicked = 0;
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
        public long ParsedContact;
        public int countHr = 0;
        private void ucStudentEntry_Load(object sender, EventArgs e)
        {
            var context = new Db.SlashContext();



            //myConnection.Open();
            //string _qHours= "Select * from Hours";
            //using (SqlCommand _cmdHour = new SqlCommand(_qHours, myConnection))
            //{
            //    using (SqlDataReader _drHours = _cmdHour.ExecuteReader())
            //    {
            //        while(_drHours.Read())
            //        {
            //            Hours strthr = new Hours();
            //            strthr.displaym = (string)_drHours["displaym"];
            //            strthr.valuem = (int)_drHours["valuem"];
            //            starthr.Add(strthr);

            //            Hours enhr = new Hours();
            //            enhr.displaym = (string)_drHours["displaym"];
            //            enhr.valuem = (int)_drHours["valuem"];
            //            endhr.Add(enhr);
            //            countHr++;
            //        }
            //    }
            //}


            //list of hours for starthr
            comboStartHr.DisplayMember = "displaym";
            comboStartHr.ValueMember = "valuem";
            comboStartHr.DataSource = GlobalClass.HoursSouce.HourSourc();
            comboEndHr.DisplayMember = "displaym";
            comboEndHr.ValueMember = "valuem";
            comboEndHr.DataSource = GlobalClass.HoursSouce.HourSourc();
            //
            //list of educational qualifications.
          
            comboQualification.DisplayMember = "Educations";
            comboQualification.ValueMember = "Id";
            comboQualification.DataSource = GlobalClass.EducationSource.EducationSourc();

            //list of Course and Code.
          
            comboCourse.DisplayMember = "Subject";
            comboCourse.ValueMember = "Id";
            comboCourse.DataSource = GlobalClass.CourseSource.CourseSourc();
            //
            //list of Teachers.
            ComboTeachers.DisplayMember = "Teacher";
            ComboTeachers.ValueMember = "Id";
            ComboTeachers.DataSource = GlobalClass.TeacherSource.TeacherSourc();
            //
        }
        private int _CourseValue;
        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboCourse.SelectedValue;
            _CourseValue = (int)getId;
           
        }
        private int _EducationValue;
        private void comboQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboQualification.SelectedValue;
            _EducationValue = (int)getId;
        }
        private int _TeacherValue;
        private void ComboTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)ComboTeachers.SelectedValue;
            _TeacherValue = (int)getId;
        }
        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "M";
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "F";
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            _isRegisterClicked = 1;
            if (validation() == false)
            {
                lblRegister.Visible = true;
                return;
            }
            insert();
            resetData();
        }
        private bool validation()
        {
            int _chck = 0;
            resetfields();

            if (txtName.Text == "" || txtName.Text == " ")
            {
                lblName.Visible = true;
                _chck = 1;
            }
            if (dtpDob.Value >= System.DateTime.Today)
            {
                lblDob.Visible = true;
                _chck = 1;
            }
            if (rbtnMale.Checked == false && rbtnFemale.Checked == false)
            {
                lblGender.Visible = true;
                _chck = 1;
            }
            if (txtAddress.Text == "" || txtAddress.Text == " ")
            {
                lblAddress.Visible = true;
                _chck = 1;
            }
            if (comboQualification.SelectedIndex == 0)
            {
                lblEducation.Visible = true;
                _chck = 1;
            }
            if (comboCourse.SelectedIndex == 0)
            {
                lblCourse.Visible = true;
                _chck = 1;
            }
            if (ComboTeachers.SelectedIndex == 0)
            {
                lblTeacher.Visible = true;
                _chck = 1;
            }


            if (comboStartHr.SelectedIndex >= comboEndHr.SelectedIndex)
            {
                lblTime.Visible = true;
                _chck = 1;
            }
            if (txtContact.Text.Length != 10)
            {
                lblContact.Visible = true;
                _chck = 1;
            }
            if (!long.TryParse(txtContact.Text, out ParsedContact))
            {
                lblContact.Visible = true;
                _chck = 1;
            }
            if (txtContact.Text == "" || txtContact.Text == " ")
            {
                lblContact.Visible = true;
                _chck = 1;
            }
            string EmailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(txtEmail.Text, EmailPattern))
            {
                lblEmail.Visible = true;
                _chck = 1;
            }
            if (txtEmail.Text == "" || txtEmail.Text == " ")
            {
                lblEmail.Visible = true;
                _chck = 1;
            }
            if (txtCost.Text == "" || txtCost.Text == " ")
            {
                lblPayable.Visible = true;
                _chck = 1;
            }
            if (int.TryParse(txtCost.Text, out _cost))
            {
                if (int.TryParse(txtPaidAmmount.Text, out _paid))
                {
                    if (_paid > _cost)
                    {
                        lblPayable.Visible = true;
                        _chck = 1;
                    }
                }
            }

            if (_chck == 1)
                return false;
            else
                return true;
        }
        int insertedID;
        private void insert()
        {
            string _Name = txtName.Text;
            DateTime _DOB = dtpDob.Value;
            string _Address = txtAddress.Text;
            int _EducationId = _EducationValue;
            int _CourseId = _CourseValue;
            string _Code = txtCode.Text;
            DateTime _StartDate = dtpStartDate.Value;
            int _StartTime = _starthrvalue;
            int _EndTime = _endhrvalue;
            int _TeacherId = _TeacherValue;
            long _Contact = long.Parse(txtContact.Text);
            string _Email = txtEmail.Text;
            int _PayableAmount = int.Parse(txtCost.Text);
            int _AmountPaid = _paid;
            string _remarks = rchRemarks.Text;
            DateTime _EntryTime = DateTime.Now;
            Byte[] _Photo = null;
            if (pcbStudentPhoto.Image!=null)
            {
                Bitmap stdPhoto = new Bitmap(pcbStudentPhoto.Image);
                _Photo = imageToByteArray(stdPhoto);
            }
            var context = new Db.SlashContext();
            var student = new Db.Student_Entry()
            {
                Name = _Name,
                DOB = _DOB,
                Gender = _gender,
                Address = _Address,
                EducationId = _EducationId,
                CourseId = _CourseId,
                Code = _Code,
                Start_Date = _StartDate,
                Time_Start = _StartTime,
                Time_End = _EndTime,
                TeacherId = _TeacherId,
                Contact_Number = _Contact,
                Email_Id = _Email,
                Charge = _PayableAmount,
                Paid_Charge = _AmountPaid,
                Remarks = _remarks,
                EntryTime = _EntryTime,
                Status = true,
                Student_Photo = new Db.Student_Photo()
                { Photo = _Photo },

            };
            context.Student_Entry.Add(student);
            
            try
            {
               
                context.SaveChanges();
                insertedID = student.Id;

            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                  
                    MessageBox.Show("Entity of type " + eve.Entry.Entity.GetType().Name + "in state" + eve.Entry.State + "has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        
                        MessageBox.Show("- Property: " + ve.PropertyName + ",Error" + ve.ErrorMessage);
                    }
                }
                throw;
            }
            var payent = new Db.Payment()
            {
                StudentId = insertedID,
                Ammount_Payment = _AmountPaid,
                Date = System.DateTime.Now
            };
            context.Payments.Add(payent);
            context.SaveChanges();
            MessageBox.Show("Successful");
        }

        //    if (ImgAddress == null)
        //    {
        //        string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
        //        string FileName = string.Format("{0}Resources\\No_Photo.jpg", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
        //        ImgAddress = FileName;
        //    }
        //        byte[] img = null;
        //        FileStream fs = new FileStream(ImgAddress, FileMode.Open, FileAccess.Read);
        //        BinaryReader br = new BinaryReader(fs);
        //        img = br.ReadBytes((int)fs.Length);
        //        myConnection.Open();
        //        SqlCommand com = new SqlCommand("insert into Student_Photo(x,Photo)values('',(Select*from openrowset(bulk '" + ImgAddress + "',single_blob)as x))", myConnection);
        //        com.ExecuteNonQuery();
        //    SqlCommand myCommand = new SqlCommand("insert into Student_Entry(Name,DOB,Gender,Address,EducationId,CourseId,Code,Start_Date,Time_Start,Time_End,TeacherId,Contact_Number,Email_Id,Charge,Paid_Charge,Status,EntryTime,Remarks,PhotoId) values('" + _Name + "','" + _DOB + "','" + _gender + "','" + _Address + "','" + _EducationId + "','" + _CourseId + "','"+_Code+"','" + _StartDate + "','" + _StartTime + "','" + _EndTime + "','" + _TeacherId + "','" + _Contact + "','" + _Email + "','" + _PayableAmount + "','" + _AmountPaid + "',1,'" + _EntryTime + "','"+_remarks+"',SCOPE_IDENTITY())", myConnection);
        //    myCommand.ExecuteNonQuery();
        //    SqlCommand pay = new SqlCommand("insert into Payment(StudentId,Ammount_Payment,Date) values(CONVERT(INT,IDENT_CURRENT('Student_Entry')),'"+_AmountPaid+"','"+_EntryTime+"')", myConnection);
        //    pay.ExecuteNonQuery();
        //    myConnection.Close();
        //}
        private void btnPhotoEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog photoAd = new OpenFileDialog();
            if (photoAd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImgAddress = photoAd.FileName;
                pcbStudentPhoto.ImageLocation = ImgAddress;
                check = 1;
                pcbHasPhoto();
            }
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        string ImgAddress;
        int check = 0;
     
        private void linkPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog photoAd = new OpenFileDialog();
            if (photoAd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImgAddress = photoAd.FileName;
                pcbStudentPhoto.ImageLocation = ImgAddress;
                check = 1;

            }
            pcbHasPhoto();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetfields();
            _isRegisterClicked = 0;
            resetData();
            
        }
        private void resetData()
        {
            _isRegisterClicked = 0;
            txtName.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            dtpDob.ResetText();
            txtAddress.Text = "";
            comboQualification.SelectedIndex = 0;
            comboCourse.SelectedIndex=0;
            txtCode.Text = "";
            dtpStartDate.ResetText();
            comboStartHr.SelectedIndex=0;
            comboEndHr.SelectedIndex = 0;
            ComboTeachers.SelectedIndex=0;
            txtContact.Text = "";
            txtEmail.Text = "";
            txtCost.Text = "";
            txtPaidAmmount.Text = "";
            txtDue.Text = "";
            rchRemarks.Text = "";
            pcbEmpty();

        }
        private void txtPaidAmmount_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            if (int.TryParse(txtCost.Text, out _cost))
            {
                if (int.TryParse(txtPaidAmmount.Text, out _paid))
                {
                    txtDue.Text = (_cost - _paid).ToString();
                }
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }
        int _starthrvalue;
        private void comboStartHr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }

            var getId = (int)comboStartHr.SelectedValue;
            _starthrvalue = (int)getId;
        }
        int _endhrvalue;
        private void comboEndHr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboEndHr.SelectedValue;
            _endhrvalue = (int)getId;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
        }
        int _cost;
        int _paid;
        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            if (int.TryParse(txtCost.Text, out _cost))
            {
                if (int.TryParse(txtPaidAmmount.Text, out _paid))
                {
                    txtDue.Text = (_cost - _paid).ToString();
                }
            }
        }
        private void resetfields()
        {
            lblName.Visible = false;
            lblDob.Visible = false;
            lblGender.Visible = false;
            lblAddress.Visible = false;
            lblEducation.Visible = false;
            lblCourse.Visible = false;
            lblTeacher.Visible = false;
            // lblStartDate.Visible = false;
            lblTime.Visible = false;
            lblContact.Visible = false;
            lblEmail.Visible = false;
            lblPayable.Visible = false;
            lblRegister.Visible = false;
        }

        private void txtDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pcbEmpty();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetData();
        }
        private void pcbEmpty()
        {
            linkPhoto.Visible = true;
            btnPhotoEdit.Visible = false;
            btnRemovePhoto.Visible = false;
            pcbStudentPhoto.Image = null;
        }
        private void pcbHasPhoto()
        {
            linkPhoto.Visible = false;
            btnPhotoEdit.Visible = true;
            btnRemovePhoto.Visible = true;
        }
    }
}
