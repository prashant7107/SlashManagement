namespace Slash.Admin
{
    partial class frmEducationEdit
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
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActtive = new System.Windows.Forms.RadioButton();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtgetId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Status";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnInactive.ForeColor = System.Drawing.Color.Gold;
            this.rbtnInactive.Location = new System.Drawing.Point(226, 126);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(82, 24);
            this.rbtnInactive.TabIndex = 3;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            this.rbtnInactive.CheckedChanged += new System.EventHandler(this.rbtnInactive_CheckedChanged);
            // 
            // rbtnActtive
            // 
            this.rbtnActtive.AutoSize = true;
            this.rbtnActtive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnActtive.ForeColor = System.Drawing.Color.Gold;
            this.rbtnActtive.Location = new System.Drawing.Point(120, 126);
            this.rbtnActtive.Name = "rbtnActtive";
            this.rbtnActtive.Size = new System.Drawing.Size(70, 24);
            this.rbtnActtive.TabIndex = 2;
            this.rbtnActtive.TabStop = true;
            this.rbtnActtive.Text = "Active";
            this.rbtnActtive.UseVisualStyleBackColor = true;
            this.rbtnActtive.CheckedChanged += new System.EventHandler(this.rbtnActtive_CheckedChanged);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.Color.Red;
            this.lblCourse.Location = new System.Drawing.Point(161, 63);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(81, 12);
            this.lblCourse.TabIndex = 34;
            this.lblCourse.Text = "* Invalid Entry";
            this.lblCourse.Visible = false;
            // 
            // txtgetId
            // 
            this.txtgetId.Location = new System.Drawing.Point(337, 174);
            this.txtgetId.Name = "txtgetId";
            this.txtgetId.Size = new System.Drawing.Size(100, 20);
            this.txtgetId.TabIndex = 33;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(163, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEducation
            // 
            this.txtEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEducation.Location = new System.Drawing.Point(76, 78);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(260, 29);
            this.txtEducation.TabIndex = 1;
            this.txtEducation.TextChanged += new System.EventHandler(this.txtEducation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Update Education Level";
            // 
            // frmEducationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(397, 220);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbtnInactive);
            this.Controls.Add(this.rbtnActtive);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtgetId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.label1);
            this.Name = "frmEducationEdit";
            this.Text = "frmEducationEdit";
            this.Load += new System.EventHandler(this.frmEducationEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActtive;
        private System.Windows.Forms.Label lblCourse;
        public System.Windows.Forms.TextBox txtgetId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.Label label1;
    }
}