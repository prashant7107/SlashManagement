namespace Slash.Admin
{
    partial class ucAdmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnTeacherEdit = new System.Windows.Forms.Button();
            this.btnCoursesEdit = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnEducationLevelEdit = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.btnCoursesAdd = new System.Windows.Forms.Button();
            this.btnEducationLevelAdd = new System.Windows.Forms.Button();
            this.pcbTeacher = new System.Windows.Forms.PictureBox();
            this.pcbCourse = new System.Windows.Forms.PictureBox();
            this.pcbEducations = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEducations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(679, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Education Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(434, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(154, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbladmin.Location = new System.Drawing.Point(164, 39);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(84, 24);
            this.lbladmin.TabIndex = 7;
            this.lbladmin.Text = "Teacher";
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangePassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkChangePassword.Location = new System.Drawing.Point(264, 42);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(125, 22);
            this.linkChangePassword.TabIndex = 8;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Change Password";
            this.linkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePassword_LinkClicked);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(47, 86);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 20);
            this.txtbox.TabIndex = 10;
            this.txtbox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(791, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Admin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(74, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Admin";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackgroundImage = global::Slash.Properties.Resources.Plus_Sign_256x2561;
            this.btnAddAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnAddAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Location = new System.Drawing.Point(732, 17);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(74, 76);
            this.btnAddAdmin.TabIndex = 11;
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnTeacherEdit
            // 
            this.btnTeacherEdit.BackgroundImage = global::Slash.Properties.Resources.reviewwriting_icon_edited;
            this.btnTeacherEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacherEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnTeacherEdit.FlatAppearance.BorderSize = 0;
            this.btnTeacherEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherEdit.Location = new System.Drawing.Point(217, 444);
            this.btnTeacherEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeacherEdit.Name = "btnTeacherEdit";
            this.btnTeacherEdit.Size = new System.Drawing.Size(100, 100);
            this.btnTeacherEdit.TabIndex = 2;
            this.btnTeacherEdit.UseVisualStyleBackColor = true;
            this.btnTeacherEdit.Click += new System.EventHandler(this.btnTeacherEdit_Click);
            // 
            // btnCoursesEdit
            // 
            this.btnCoursesEdit.BackgroundImage = global::Slash.Properties.Resources.reviewwriting_icon_edited;
            this.btnCoursesEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoursesEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnCoursesEdit.FlatAppearance.BorderSize = 0;
            this.btnCoursesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursesEdit.Location = new System.Drawing.Point(509, 444);
            this.btnCoursesEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnCoursesEdit.Name = "btnCoursesEdit";
            this.btnCoursesEdit.Size = new System.Drawing.Size(100, 100);
            this.btnCoursesEdit.TabIndex = 4;
            this.btnCoursesEdit.UseVisualStyleBackColor = true;
            this.btnCoursesEdit.Click += new System.EventHandler(this.btnCoursesEdit_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackgroundImage = global::Slash.Properties.Resources.data_backup;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(924, 500);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 100);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnEducationLevelEdit
            // 
            this.btnEducationLevelEdit.BackgroundImage = global::Slash.Properties.Resources.reviewwriting_icon_edited;
            this.btnEducationLevelEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEducationLevelEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnEducationLevelEdit.FlatAppearance.BorderSize = 0;
            this.btnEducationLevelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducationLevelEdit.Location = new System.Drawing.Point(799, 444);
            this.btnEducationLevelEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEducationLevelEdit.Name = "btnEducationLevelEdit";
            this.btnEducationLevelEdit.Size = new System.Drawing.Size(100, 100);
            this.btnEducationLevelEdit.TabIndex = 6;
            this.btnEducationLevelEdit.UseVisualStyleBackColor = true;
            this.btnEducationLevelEdit.Click += new System.EventHandler(this.btnEducationLevelEdit_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.BackgroundImage = global::Slash.Properties.Resources.Plus_Sign_256x2561;
            this.btnTeacherAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacherAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnTeacherAdd.FlatAppearance.BorderSize = 0;
            this.btnTeacherAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherAdd.Location = new System.Drawing.Point(117, 444);
            this.btnTeacherAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(100, 100);
            this.btnTeacherAdd.TabIndex = 1;
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnCoursesAdd
            // 
            this.btnCoursesAdd.BackgroundImage = global::Slash.Properties.Resources.Plus_Sign_256x2561;
            this.btnCoursesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoursesAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnCoursesAdd.FlatAppearance.BorderSize = 0;
            this.btnCoursesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursesAdd.Location = new System.Drawing.Point(409, 444);
            this.btnCoursesAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnCoursesAdd.Name = "btnCoursesAdd";
            this.btnCoursesAdd.Size = new System.Drawing.Size(100, 100);
            this.btnCoursesAdd.TabIndex = 3;
            this.btnCoursesAdd.UseVisualStyleBackColor = true;
            this.btnCoursesAdd.Click += new System.EventHandler(this.btnCoursesAdd_Click);
            // 
            // btnEducationLevelAdd
            // 
            this.btnEducationLevelAdd.BackgroundImage = global::Slash.Properties.Resources.Plus_Sign_256x2561;
            this.btnEducationLevelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEducationLevelAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnEducationLevelAdd.FlatAppearance.BorderSize = 0;
            this.btnEducationLevelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducationLevelAdd.Location = new System.Drawing.Point(699, 444);
            this.btnEducationLevelAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnEducationLevelAdd.Name = "btnEducationLevelAdd";
            this.btnEducationLevelAdd.Size = new System.Drawing.Size(100, 100);
            this.btnEducationLevelAdd.TabIndex = 5;
            this.btnEducationLevelAdd.UseVisualStyleBackColor = true;
            this.btnEducationLevelAdd.Click += new System.EventHandler(this.btnEducationLevelAdd_Click);
            // 
            // pcbTeacher
            // 
            this.pcbTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbTeacher.Image = global::Slash.Properties.Resources.teachers_clip_art_free;
            this.pcbTeacher.InitialImage = global::Slash.Properties.Resources.teachers_clip_art_free;
            this.pcbTeacher.Location = new System.Drawing.Point(100, 162);
            this.pcbTeacher.Name = "pcbTeacher";
            this.pcbTeacher.Size = new System.Drawing.Size(225, 225);
            this.pcbTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTeacher.TabIndex = 0;
            this.pcbTeacher.TabStop = false;
            this.pcbTeacher.Click += new System.EventHandler(this.pcbTeacher_Click);
            // 
            // pcbCourse
            // 
            this.pcbCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbCourse.Image = global::Slash.Properties.Resources.books_and_computer_clipart_12;
            this.pcbCourse.InitialImage = global::Slash.Properties.Resources.books_and_computer_clipart_12;
            this.pcbCourse.Location = new System.Drawing.Point(393, 162);
            this.pcbCourse.Name = "pcbCourse";
            this.pcbCourse.Size = new System.Drawing.Size(225, 225);
            this.pcbCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCourse.TabIndex = 0;
            this.pcbCourse.TabStop = false;
            this.pcbCourse.Click += new System.EventHandler(this.pcbCourse_Click);
            // 
            // pcbEducations
            // 
            this.pcbEducations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbEducations.Image = global::Slash.Properties.Resources.graduation_cap_vector;
            this.pcbEducations.InitialImage = global::Slash.Properties.Resources.graduation_cap_vector;
            this.pcbEducations.Location = new System.Drawing.Point(685, 162);
            this.pcbEducations.Name = "pcbEducations";
            this.pcbEducations.Size = new System.Drawing.Size(225, 225);
            this.pcbEducations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEducations.TabIndex = 0;
            this.pcbEducations.TabStop = false;
            this.pcbEducations.Click += new System.EventHandler(this.pcbEducations_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.linkChangePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.btnTeacherEdit);
            this.Controls.Add(this.btnCoursesEdit);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnEducationLevelEdit);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.btnCoursesAdd);
            this.Controls.Add(this.btnEducationLevelAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbTeacher);
            this.Controls.Add(this.pcbCourse);
            this.Controls.Add(this.pcbEducations);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1024, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEducations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbEducations;
        private System.Windows.Forms.PictureBox pcbCourse;
        private System.Windows.Forms.PictureBox pcbTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEducationLevelAdd;
        private System.Windows.Forms.Button btnEducationLevelEdit;
        private System.Windows.Forms.Button btnCoursesAdd;
        private System.Windows.Forms.Button btnCoursesEdit;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnTeacherEdit;
        private System.Windows.Forms.LinkLabel linkChangePassword;
        public System.Windows.Forms.TextBox txtbox;
        public System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Button btnAddAdmin;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackup;
    }
}
