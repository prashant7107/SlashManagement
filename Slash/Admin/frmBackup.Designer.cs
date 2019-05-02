namespace Slash.Admin
{
    partial class frmBackup
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
            this.pgProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comDrive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pgProgressBar
            // 
            this.pgProgressBar.Location = new System.Drawing.Point(15, 94);
            this.pgProgressBar.Name = "pgProgressBar";
            this.pgProgressBar.Size = new System.Drawing.Size(223, 23);
            this.pgProgressBar.TabIndex = 2;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(83, 163);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(95, 120);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(24, 13);
            this.lblPercentage.TabIndex = 0;
            this.lblPercentage.Text = "0 %";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(162, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Drive";
            // 
            // comDrive
            // 
            this.comDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comDrive.FormattingEnabled = true;
            this.comDrive.Items.AddRange(new object[] {
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:"});
            this.comDrive.Location = new System.Drawing.Point(71, 55);
            this.comDrive.Name = "comDrive";
            this.comDrive.Size = new System.Drawing.Size(162, 21);
            this.comDrive.TabIndex = 4;
            this.comDrive.SelectedIndexChanged += new System.EventHandler(this.comDrive_SelectedIndexChanged);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 199);
            this.Controls.Add(this.comDrive);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.pgProgressBar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Server Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgProgressBar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comDrive;
    }
}