using Slash.StudentDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slash.Studentretrive
{
    public partial class frmStudentParticular : Form
    {
        public frmStudentParticular()
        {
            InitializeComponent();
        }
        //SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Slash"].ConnectionString);
        int change = 0;
        int _photoId;
        int _id;
        string _name;
        DateTime _dob;
        string _genderss;
        string _address;
        int _educationid;
        int _courseid;
        string _code;
        DateTime _startdate;
        int _Starthr;
        int _Endhr;
        int _teacherid;
        long _contact;
        string _email;
        string _remarks;
        byte[] _photo;
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void txtGetData_TextChanged(object sender, EventArgs e)
        {
            //string query = "select stud.Id,stud.Name,stud.DOB,stud.Gender,stud.Address,edu.Education,cou.Subject,stud.Code,stud.Start_Date,tea.Teacher,stud.Contact_Number,stud.Email_Id,ph.Photo from student_entry as stud inner join Student_Education as edu on stud.EducationId = edu.Id inner join Course_List as cou on stud.CourseId = cou.Id inner join Teachers_List as tea on stud.TeacherId = tea.Id inner join Student_Photo as ph on stud.PhotoId = ph.Id where stud.Id = '" + txtGetData.Text + "'";
            _id = int.Parse(txtGetData.Text);
            var context = new Db.SlashContext();
            var stds = context.Student_Entry.Find(_id);
            #region sql get student
            //string query = "select *,ph.Photo from Student_Entry stud inner join Student_Photo ph on stud.PhotoId=ph.Id where stud.Id ='" + txtGetData.Text + "'";
            //SqlCommand cmd = new SqlCommand(query, myConnection);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //string _name = dt.Rows[0].Field<string>("Name");
            //DateTime _dob = dt.Rows[0].Field<DateTime>("DOB");
            //string _gender = dt.Rows[0].Field<string>("Gender");
            //_gender = _gender.Replace(" ","");
            //string _address = dt.Rows[0].Field<string>("Address");
            //int _educationid = dt.Rows[0].Field<int>("EducationId");
            //int _courseid = dt.Rows[0].Field<int>("CourseId");
            //string _code = dt.Rows[0].Field<string>("Code");
            //DateTime _startdate = dt.Rows[0].Field<DateTime>("Start_Date");
            //int _Starthr = dt.Rows[0].Field<int>("Time_Start");
            //int _Endhr = dt.Rows[0].Field<int>("Time_End");
            //int _teacherid = dt.Rows[0].Field<int>("TeacherId");
            //long _contact = dt.Rows[0].Field<long>("Contact_Number");
            //string _email = dt.Rows[0].Field<string>("Email_Id");
            //string _remarks = dt.Rows[0].Field<string>("Remarks");
            //byte[] _photo = dt.Rows[0].Field<byte[]>("Photo");
            #endregion
             _name = stds.Name;
            if (stds.DOB != null)
                _dob = (DateTime)stds.DOB;
            else
                _dob = System.DateTime.Today;
             _genderss = stds.Gender;
            _genderss = _genderss.Replace(" ", "");
             _address = stds.Address;
             _educationid = (int)stds.EducationId;
             _courseid = (int)stds.CourseId;
             _code = stds.Code;
             _startdate = (DateTime)stds.Start_Date;
             _Starthr = (int)stds.Time_Start;
             _Endhr = (int)stds.Time_End;
             _teacherid = (int)stds.TeacherId;
             _contact = stds.Contact_Number;
             _email = stds.Email_Id;
             _remarks = stds.Remarks;
             _photoId = (int)stds.PhotoId;
            var img = context.Student_Photo.Find(_photoId);
            int idimg = img.Id;
            _photo=img.Photo;
            resetdata();
        }
        public int _passeducationid;
        public int _passcourseid;
        public int _passstarthr;
        public int _passendhr;
        public int _passteacher;
        private void frmStudentParticular_Load(object sender, EventArgs e)
        {
            //list of hours for starthr
            comboStarthr.DisplayMember = "displaym";
            comboStarthr.ValueMember = "valuem";
            comboStarthr.DataSource = GlobalClass.HoursSouce.HourSourc();
            comboStarthr.SelectedValue = _passstarthr;
            
            comboEndhr.DisplayMember = "displaym";
            comboEndhr.ValueMember = "valuem";
            comboEndhr.DataSource = GlobalClass.HoursSouce.HourSourc();
            comboEndhr.SelectedValue = _passendhr;
            //
            //list of educational qualifications.
           
            comboQualification.DisplayMember = "Educations";
            comboQualification.ValueMember = "Id";
            comboQualification.DataSource = GlobalClass.EducationSource.EducationSourc();
            comboQualification.SelectedValue = _passeducationid;
            //
            //list of Course and Code.
           
            comboCourse.DisplayMember = "Subject";
            comboCourse.ValueMember = "Id";
            comboCourse.DataSource = GlobalClass.CourseSource.CourseSourc();
            comboCourse.SelectedValue = _passcourseid;
            //
            //list of Teachers.
           
            ComboTeachers.DisplayMember = "Teacher";
            ComboTeachers.ValueMember = "Id";
            ComboTeachers.DataSource = GlobalClass.TeacherSource.TeacherSourc();
            ComboTeachers.SelectedValue = _passteacher;
            //
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void comboQualification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboQualification.SelectedValue;
            _EducationValue = (int)getId;
            change = 1;
        }
        int _isRegisterClicked = 0;
        private int _EducationValue;
        private int _CourseValue;
        private int _starthrvalue;
        private int _endhrvalue;
        private int _TeacherValue;
        int checkPhoto = 0;
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (change != 1)
            {
                MessageBox.Show("No Changes");
                return;
            }
            else
            {
                string _name = txtName.Text;
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
                string _rem = rchRemarks.Text;
                DateTime _UpdateTime = DateTime.Now;
                Byte[] _Photo = null;
                _isRegisterClicked = 1;
                if (validation() == false)
                {
                    lblRegister.Visible = true;
                    return;
                }
                else
                {
                    var context = new Db.SlashContext();

                    if (checkPhoto == 1)
                    {
                        if (pcbStudentPhoto.Image != null)
                        {
                            Bitmap stdPhoto = new Bitmap(pcbStudentPhoto.Image);
                            _Photo = imageToByteArray(stdPhoto);

                            var photo = context.Student_Photo.Find(_photoId);
                            photo.Photo = _Photo;
                            context.SaveChanges();
                        }
                        else
                        {
                            var photo = context.Student_Photo.Find(_photoId);
                            photo.Photo = null;
                            context.SaveChanges();
                        }

                    }
                   
                        var stud = context.Student_Entry.Find(_id);
                        stud.Name = _name;
                        stud.DOB = _DOB;
                        stud.Address = _Address;
                        stud.EducationId = _EducationId;
                        stud.CourseId = _CourseId;
                        stud.Code = _Code;
                        stud.Start_Date = _StartDate;
                        stud.Time_Start = _StartTime;
                        stud.Time_End = _EndTime;
                        stud.TeacherId = _TeacherId;
                        stud.Contact_Number = _Contact;
                        stud.Email_Id = _Email;
                        stud.Remarks = _rem;
                        stud.LastUpdate = _UpdateTime;
                        context.SaveChanges();
                    MessageBox.Show("Successful");
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
            lblRegister.Visible = false;

        }
        private void resetdata()
        {
            if (_photo == null)
            {
                pcbStudentPhoto.Image = null;
            }
            else
            {

                pcbStudentPhoto.Image = byteArrayToImage(_photo);
            }
            //  rbtnMale.Checked = true;
            txtName.Text = _name;
            if (_genderss == "M")
            {
                rbtnMale.Checked = true;
            }
            if (_genderss == "F")
            {
                rbtnFemale.Checked = true;
            }
            rchRemarks.Text = _remarks;
            dtpDob.Value = _dob;
            txtAddress.Text = _address;
            txtCode.Text = _code;
            dtpStartDate.Value = _startdate;
            txtContact.Text = _contact.ToString();
            txtEmail.Text = _email;
            _passeducationid = _educationid;
            _passcourseid = _courseid;
            _passstarthr = _Starthr;
            _passendhr = _Endhr;
            _passteacher = _teacherid;
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

            if (comboStarthr.SelectedIndex == 0)
            {
                lblTime.Visible = true;
                _chck = 1;
            }
            if (comboEndhr.SelectedIndex == 0)
            {
                lblTime.Visible = true;
                _chck = 1;
            }
            if (comboStarthr.SelectedIndex >= comboEndhr.SelectedIndex)
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
            string _pattern = txtEmail.Text.Replace(" ", string.Empty);
            if (!Regex.IsMatch(_pattern, EmailPattern))
            {
                lblEmail.Text = "1";
                lblEmail.Visible = true;
                _chck = 1;
            }
            if (txtEmail.Text == "" || txtEmail.Text == " ")
            {
                lblEmail.Text = "2";
                lblEmail.Visible = true;
                _chck = 1;
            }
            if (_chck == 1)
                return false;
            else
                return true;
        }
        public long ParsedContact;
        private void comboStartHr_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
       public string _gender;
        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "M";
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "F";
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboCourse.SelectedValue;
            _CourseValue = (int)getId;
            change = 1;
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void comboStarthr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }

            var getId = (int)comboStarthr.SelectedValue;
            _starthrvalue = (int)getId;
            change = 1;
        }

        private void comboEndhr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)comboEndhr.SelectedValue;
            _endhrvalue = (int)getId;
            change = 1;
        }

        private void ComboTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            var getId = (int)ComboTeachers.SelectedValue;
            _TeacherValue = (int)getId;
            change = 1;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (_isRegisterClicked == 1)
            {
                validation();
            }
            change = 1;
        }
        string ImgAddress;
        private void btnPhotoEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog photoAd = new OpenFileDialog();
            if (photoAd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImgAddress = photoAd.FileName;
                pcbStudentPhoto.ImageLocation = ImgAddress;
                checkPhoto = 1;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetdata();
        }

        private void rchRemarks_TextChanged(object sender, EventArgs e)
        {
            change = 1;
        }
    }
}
