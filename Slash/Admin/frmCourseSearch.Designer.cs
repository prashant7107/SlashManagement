namespace Slash.Admin
{
    partial class frmCourseSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourseSearch = new System.Windows.Forms.DataGridView();
            this.pnlUpdateCourse = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActtive = new System.Windows.Forms.RadioButton();
            this.lblCourseInvalid = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCourseNewName = new System.Windows.Forms.TextBox();
            this.lblheading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSearch)).BeginInit();
            this.pnlUpdateCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(114)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtCourse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 65);
            this.panel1.TabIndex = 9;
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
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(87, 20);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(320, 29);
            this.txtCourse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // dgvCourseSearch
            // 
            this.dgvCourseSearch.AllowUserToAddRows = false;
            this.dgvCourseSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourseSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourseSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourseSearch.Location = new System.Drawing.Point(0, 65);
            this.dgvCourseSearch.Name = "dgvCourseSearch";
            this.dgvCourseSearch.ReadOnly = true;
            this.dgvCourseSearch.Size = new System.Drawing.Size(581, 439);
            this.dgvCourseSearch.TabIndex = 10;
            this.dgvCourseSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseSearch_CellClick);
            // 
            // pnlUpdateCourse
            // 
            this.pnlUpdateCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlUpdateCourse.Controls.Add(this.lblStatus);
            this.pnlUpdateCourse.Controls.Add(this.rbtnInactive);
            this.pnlUpdateCourse.Controls.Add(this.rbtnActtive);
            this.pnlUpdateCourse.Controls.Add(this.lblCourseInvalid);
            this.pnlUpdateCourse.Controls.Add(this.btnUpdate);
            this.pnlUpdateCourse.Controls.Add(this.txtCourseNewName);
            this.pnlUpdateCourse.Controls.Add(this.lblheading);
            this.pnlUpdateCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateCourse.Location = new System.Drawing.Point(0, 316);
            this.pnlUpdateCourse.Name = "pnlUpdateCourse";
            this.pnlUpdateCourse.Size = new System.Drawing.Size(581, 188);
            this.pnlUpdateCourse.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Ivory;
            this.lblStatus.Location = new System.Drawing.Point(130, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnInactive.ForeColor = System.Drawing.Color.Gold;
            this.rbtnInactive.Location = new System.Drawing.Point(341, 110);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(82, 24);
            this.rbtnInactive.TabIndex = 32;
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
            this.rbtnActtive.Location = new System.Drawing.Point(235, 110);
            this.rbtnActtive.Name = "rbtnActtive";
            this.rbtnActtive.Size = new System.Drawing.Size(70, 24);
            this.rbtnActtive.TabIndex = 31;
            this.rbtnActtive.TabStop = true;
            this.rbtnActtive.Text = "Active";
            this.rbtnActtive.UseVisualStyleBackColor = true;
            this.rbtnActtive.Visible = false;
            this.rbtnActtive.CheckedChanged += new System.EventHandler(this.rbtnActtive_CheckedChanged);
            // 
            // lblCourseInvalid
            // 
            this.lblCourseInvalid.AutoSize = true;
            this.lblCourseInvalid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblCourseInvalid.Location = new System.Drawing.Point(276, 47);
            this.lblCourseInvalid.Name = "lblCourseInvalid";
            this.lblCourseInvalid.Size = new System.Drawing.Size(81, 12);
            this.lblCourseInvalid.TabIndex = 35;
            this.lblCourseInvalid.Text = "* Invalid Entry";
            this.lblCourseInvalid.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(278, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCourseNewName
            // 
            this.txtCourseNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseNewName.Location = new System.Drawing.Point(191, 62);
            this.txtCourseNewName.Name = "txtCourseNewName";
            this.txtCourseNewName.Size = new System.Drawing.Size(260, 29);
            this.txtCourseNewName.TabIndex = 30;
            this.txtCourseNewName.Visible = false;
            this.txtCourseNewName.TextChanged += new System.EventHandler(this.txtCourseNewName_TextChanged);
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.ForeColor = System.Drawing.Color.Ivory;
            this.lblheading.Location = new System.Drawing.Point(214, 11);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(210, 24);
            this.lblheading.TabIndex = 34;
            this.lblheading.Text = "Update Course Name";
            this.lblheading.Visible = false;
            // 
            // frmCourseSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 504);
            this.Controls.Add(this.pnlUpdateCourse);
            this.Controls.Add(this.dgvCourseSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCourseSearch";
            this.Text = "frmCourseSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseSearch)).EndInit();
            this.pnlUpdateCourse.ResumeLayout(false);
            this.pnlUpdateCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourseSearch;
        private System.Windows.Forms.Panel pnlUpdateCourse;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActtive;
        private System.Windows.Forms.Label lblCourseInvalid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCourseNewName;
        private System.Windows.Forms.Label lblheading;
    }
}