namespace Slash.Admin
{
    partial class frmTeacherSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTeacherSearch = new System.Windows.Forms.DataGridView();
            this.pnlUpdateArea = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.txtNameNew = new System.Windows.Forms.TextBox();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContacttext = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.rtxtSubjects = new System.Windows.Forms.RichTextBox();
            this.lblSubjectsText = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActtive = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSearch)).BeginInit();
            this.pnlUpdateArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeacher
            // 
            this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacher.Location = new System.Drawing.Point(87, 20);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(320, 29);
            this.txtTeacher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(114)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtTeacher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 65);
            this.panel1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSearch.Location = new System.Drawing.Point(434, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlUpdateArea);
            this.panel2.Controls.Add(this.dgvTeacherSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 439);
            this.panel2.TabIndex = 9;
            // 
            // dgvTeacherSearch
            // 
            this.dgvTeacherSearch.AllowUserToAddRows = false;
            this.dgvTeacherSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeacherSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeacherSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvTeacherSearch.Name = "dgvTeacherSearch";
            this.dgvTeacherSearch.ReadOnly = true;
            this.dgvTeacherSearch.Size = new System.Drawing.Size(581, 439);
            this.dgvTeacherSearch.TabIndex = 1;
            this.dgvTeacherSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherSearch_CellClick_1);
            // 
            // pnlUpdateArea
            // 
            this.pnlUpdateArea.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUpdateArea.CausesValidation = false;
            this.pnlUpdateArea.Controls.Add(this.rbtnInactive);
            this.pnlUpdateArea.Controls.Add(this.rbtnActtive);
            this.pnlUpdateArea.Controls.Add(this.btnUpdate);
            this.pnlUpdateArea.Controls.Add(this.lblStatus);
            this.pnlUpdateArea.Controls.Add(this.rtxtRemarks);
            this.pnlUpdateArea.Controls.Add(this.lblRemarks);
            this.pnlUpdateArea.Controls.Add(this.lblSubjects);
            this.pnlUpdateArea.Controls.Add(this.rtxtSubjects);
            this.pnlUpdateArea.Controls.Add(this.lblSubjectsText);
            this.pnlUpdateArea.Controls.Add(this.lblEmail);
            this.pnlUpdateArea.Controls.Add(this.txtEmail);
            this.pnlUpdateArea.Controls.Add(this.lblEmailText);
            this.pnlUpdateArea.Controls.Add(this.lblContact);
            this.pnlUpdateArea.Controls.Add(this.txtContact);
            this.pnlUpdateArea.Controls.Add(this.lblContacttext);
            this.pnlUpdateArea.Controls.Add(this.lblname);
            this.pnlUpdateArea.Controls.Add(this.txtNameNew);
            this.pnlUpdateArea.Controls.Add(this.lblNameText);
            this.pnlUpdateArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateArea.Location = new System.Drawing.Point(0, 168);
            this.pnlUpdateArea.Name = "pnlUpdateArea";
            this.pnlUpdateArea.Size = new System.Drawing.Size(581, 271);
            this.pnlUpdateArea.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Red;
            this.lblname.Location = new System.Drawing.Point(3, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(81, 12);
            this.lblname.TabIndex = 28;
            this.lblname.Text = "* Invalid Entry";
            this.lblname.Visible = false;
            // 
            // txtNameNew
            // 
            this.txtNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameNew.Location = new System.Drawing.Point(87, 14);
            this.txtNameNew.Name = "txtNameNew";
            this.txtNameNew.Size = new System.Drawing.Size(208, 29);
            this.txtNameNew.TabIndex = 26;
            this.txtNameNew.Visible = false;
            this.txtNameNew.TextChanged += new System.EventHandler(this.txtNameNew_TextChanged);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.ForeColor = System.Drawing.Color.Ivory;
            this.lblNameText.Location = new System.Drawing.Point(6, 19);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(65, 24);
            this.lblNameText.TabIndex = 27;
            this.lblNameText.Text = "Name";
            this.lblNameText.Visible = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Red;
            this.lblContact.Location = new System.Drawing.Point(3, 87);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(81, 12);
            this.lblContact.TabIndex = 31;
            this.lblContact.Text = "* Invalid Entry";
            this.lblContact.Visible = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(87, 64);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(208, 29);
            this.txtContact.TabIndex = 29;
            this.txtContact.Visible = false;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // lblContacttext
            // 
            this.lblContacttext.AutoSize = true;
            this.lblContacttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacttext.ForeColor = System.Drawing.Color.Ivory;
            this.lblContacttext.Location = new System.Drawing.Point(4, 64);
            this.lblContacttext.Name = "lblContacttext";
            this.lblContacttext.Size = new System.Drawing.Size(80, 24);
            this.lblContacttext.TabIndex = 30;
            this.lblContacttext.Text = "Contact";
            this.lblContacttext.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(3, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 12);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "* Invalid Entry";
            this.lblEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(87, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 29);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Visible = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmailText
            // 
            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailText.ForeColor = System.Drawing.Color.Ivory;
            this.lblEmailText.Location = new System.Drawing.Point(7, 116);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(62, 24);
            this.lblEmailText.TabIndex = 33;
            this.lblEmailText.Text = "Email";
            this.lblEmailText.Visible = false;
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjects.ForeColor = System.Drawing.Color.Red;
            this.lblSubjects.Location = new System.Drawing.Point(3, 185);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(81, 12);
            this.lblSubjects.TabIndex = 37;
            this.lblSubjects.Text = "* Invalid Entry";
            this.lblSubjects.Visible = false;
            // 
            // rtxtSubjects
            // 
            this.rtxtSubjects.Location = new System.Drawing.Point(87, 161);
            this.rtxtSubjects.Name = "rtxtSubjects";
            this.rtxtSubjects.Size = new System.Drawing.Size(236, 66);
            this.rtxtSubjects.TabIndex = 35;
            this.rtxtSubjects.Text = "";
            this.rtxtSubjects.Visible = false;
            this.rtxtSubjects.TextChanged += new System.EventHandler(this.rtxtSubjects_TextChanged);
            // 
            // lblSubjectsText
            // 
            this.lblSubjectsText.AutoSize = true;
            this.lblSubjectsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectsText.ForeColor = System.Drawing.Color.Ivory;
            this.lblSubjectsText.Location = new System.Drawing.Point(2, 161);
            this.lblSubjectsText.Name = "lblSubjectsText";
            this.lblSubjectsText.Size = new System.Drawing.Size(90, 24);
            this.lblSubjectsText.TabIndex = 36;
            this.lblSubjectsText.Text = "Subjects";
            this.lblSubjectsText.Visible = false;
            // 
            // rtxtRemarks
            // 
            this.rtxtRemarks.Location = new System.Drawing.Point(370, 39);
            this.rtxtRemarks.Name = "rtxtRemarks";
            this.rtxtRemarks.Size = new System.Drawing.Size(199, 98);
            this.rtxtRemarks.TabIndex = 38;
            this.rtxtRemarks.Text = "";
            this.rtxtRemarks.Visible = false;
            this.rtxtRemarks.TextChanged += new System.EventHandler(this.rtxtRemarks_TextChanged);
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.Ivory;
            this.lblRemarks.Location = new System.Drawing.Point(430, 12);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(91, 24);
            this.lblRemarks.TabIndex = 39;
            this.lblRemarks.Text = "Remarks";
            this.lblRemarks.Visible = false;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnInactive.ForeColor = System.Drawing.Color.Gold;
            this.rbtnInactive.Location = new System.Drawing.Point(173, 238);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(82, 24);
            this.rbtnInactive.TabIndex = 41;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            this.rbtnInactive.Visible = false;
            this.rbtnInactive.CheckedChanged += new System.EventHandler(this.rbtnInactive_CheckedChanged);
            // 
            // rbtnActtive
            // 
            this.rbtnActtive.AutoSize = true;
            this.rbtnActtive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnActtive.ForeColor = System.Drawing.Color.Gold;
            this.rbtnActtive.Location = new System.Drawing.Point(87, 239);
            this.rbtnActtive.Name = "rbtnActtive";
            this.rbtnActtive.Size = new System.Drawing.Size(70, 24);
            this.rbtnActtive.TabIndex = 40;
            this.rbtnActtive.TabStop = true;
            this.rbtnActtive.Text = "Active";
            this.rbtnActtive.UseVisualStyleBackColor = true;
            this.rbtnActtive.Visible = false;
            this.rbtnActtive.CheckedChanged += new System.EventHandler(this.rbtnActtive_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(415, 171);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 68);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Ivory;
            this.lblStatus.Location = new System.Drawing.Point(7, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 43;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // frmTeacherSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(581, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTeacherSearch";
            this.Text = "frmTeacherSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherSearch)).EndInit();
            this.pnlUpdateArea.ResumeLayout(false);
            this.pnlUpdateArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTeacherSearch;
        private System.Windows.Forms.Panel pnlUpdateArea;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtNameNew;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContacttext;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.RichTextBox rtxtSubjects;
        private System.Windows.Forms.Label lblSubjectsText;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActtive;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblStatus;
    }
}