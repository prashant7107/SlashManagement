﻿namespace Slash.Admin.View
{
    partial class frmCourseView
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btninactive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(114)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btninactive);
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Purple;
            this.btnAll.Location = new System.Drawing.Point(189, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(83, 34);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btninactive
            // 
            this.btninactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btninactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninactive.ForeColor = System.Drawing.Color.Purple;
            this.btninactive.Location = new System.Drawing.Point(101, 3);
            this.btninactive.Name = "btninactive";
            this.btninactive.Size = new System.Drawing.Size(83, 34);
            this.btninactive.TabIndex = 2;
            this.btninactive.Text = "Inactive";
            this.btninactive.UseVisualStyleBackColor = false;
            this.btninactive.Click += new System.EventHandler(this.btninactive_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.Purple;
            this.btnActive.Location = new System.Drawing.Point(12, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(83, 34);
            this.btnActive.TabIndex = 1;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourse.Location = new System.Drawing.Point(0, 44);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.Size = new System.Drawing.Size(284, 217);
            this.dgvCourse.TabIndex = 2;
            // 
            // frmCourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.panel1);
            this.Name = "frmCourseView";
            this.Text = "frmCourseView";
            this.Load += new System.EventHandler(this.frmCourseView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btninactive;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.DataGridView dgvCourse;
    }
}