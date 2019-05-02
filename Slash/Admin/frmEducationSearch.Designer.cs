namespace Slash.Admin
{
    partial class frmEducationSearch
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
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEducationSearch = new System.Windows.Forms.DataGridView();
            this.pnlupdateEducation = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActtive = new System.Windows.Forms.RadioButton();
            this.lblEducationInvalid = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEducationNew = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationSearch)).BeginInit();
            this.pnlupdateEducation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(114)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtEducation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 65);
            this.panel1.TabIndex = 10;
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
            // txtEducation
            // 
            this.txtEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEducation.Location = new System.Drawing.Point(108, 20);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(320, 29);
            this.txtEducation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Education";
            // 
            // dgvEducationSearch
            // 
            this.dgvEducationSearch.AllowUserToAddRows = false;
            this.dgvEducationSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEducationSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEducationSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducationSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEducationSearch.Location = new System.Drawing.Point(0, 65);
            this.dgvEducationSearch.Name = "dgvEducationSearch";
            this.dgvEducationSearch.ReadOnly = true;
            this.dgvEducationSearch.Size = new System.Drawing.Size(581, 439);
            this.dgvEducationSearch.TabIndex = 11;
            this.dgvEducationSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourseSearch_CellClick);
            // 
            // pnlupdateEducation
            // 
            this.pnlupdateEducation.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlupdateEducation.Controls.Add(this.lblStatus);
            this.pnlupdateEducation.Controls.Add(this.rbtnInactive);
            this.pnlupdateEducation.Controls.Add(this.rbtnActtive);
            this.pnlupdateEducation.Controls.Add(this.lblEducationInvalid);
            this.pnlupdateEducation.Controls.Add(this.btnUpdate);
            this.pnlupdateEducation.Controls.Add(this.txtEducationNew);
            this.pnlupdateEducation.Controls.Add(this.lblHeading);
            this.pnlupdateEducation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlupdateEducation.Location = new System.Drawing.Point(0, 316);
            this.pnlupdateEducation.Name = "pnlupdateEducation";
            this.pnlupdateEducation.Size = new System.Drawing.Size(581, 188);
            this.pnlupdateEducation.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Ivory;
            this.lblStatus.Location = new System.Drawing.Point(130, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 44;
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
            this.rbtnInactive.TabIndex = 40;
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
            this.rbtnActtive.TabIndex = 39;
            this.rbtnActtive.TabStop = true;
            this.rbtnActtive.Text = "Active";
            this.rbtnActtive.UseVisualStyleBackColor = true;
            this.rbtnActtive.Visible = false;
            this.rbtnActtive.CheckedChanged += new System.EventHandler(this.rbtnActtive_CheckedChanged);
            // 
            // lblEducationInvalid
            // 
            this.lblEducationInvalid.AutoSize = true;
            this.lblEducationInvalid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEducationInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblEducationInvalid.Location = new System.Drawing.Point(276, 47);
            this.lblEducationInvalid.Name = "lblEducationInvalid";
            this.lblEducationInvalid.Size = new System.Drawing.Size(81, 12);
            this.lblEducationInvalid.TabIndex = 43;
            this.lblEducationInvalid.Text = "* Invalid Entry";
            this.lblEducationInvalid.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(278, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEducationNew
            // 
            this.txtEducationNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEducationNew.Location = new System.Drawing.Point(191, 62);
            this.txtEducationNew.Name = "txtEducationNew";
            this.txtEducationNew.Size = new System.Drawing.Size(260, 29);
            this.txtEducationNew.TabIndex = 38;
            this.txtEducationNew.Visible = false;
            this.txtEducationNew.TextChanged += new System.EventHandler(this.txtEducationNew_TextChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Ivory;
            this.lblHeading.Location = new System.Drawing.Point(214, 11);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(232, 24);
            this.lblHeading.TabIndex = 42;
            this.lblHeading.Text = "Update Education Level";
            this.lblHeading.Visible = false;
            // 
            // frmEducationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 504);
            this.Controls.Add(this.pnlupdateEducation);
            this.Controls.Add(this.dgvEducationSearch);
            this.Controls.Add(this.panel1);
            this.Name = "frmEducationSearch";
            this.Text = "frmEducationSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducationSearch)).EndInit();
            this.pnlupdateEducation.ResumeLayout(false);
            this.pnlupdateEducation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEducationSearch;
        private System.Windows.Forms.Panel pnlupdateEducation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActtive;
        private System.Windows.Forms.Label lblEducationInvalid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEducationNew;
        private System.Windows.Forms.Label lblHeading;
    }
}