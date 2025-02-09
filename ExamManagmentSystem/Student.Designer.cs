namespace ExamManagmentSystem
{
    partial class Student
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.stdMenuPanel = new System.Windows.Forms.Panel();
            this.btnExitStd = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogoutStd = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewCourses = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewResults = new Guna.UI2.WinForms.Guna2Button();
            this.btnTakeExam = new Guna.UI2.WinForms.Guna2Button();
            this.stdUsernameLabel = new System.Windows.Forms.Label();
            this.insProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.stdHomePanel = new System.Windows.Forms.Panel();
            this.uC_ViewCourses1 = new ExamManagmentSystem.Student_UsrCtrl.UC_ViewCourses();
            this.uC_TakeExam1 = new ExamManagmentSystem.Student_UsrCtrl.UC_TakeExam();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.stdMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insProfilePictureBox)).BeginInit();
            this.stdHomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stdMenuPanel
            // 
            this.stdMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stdMenuPanel.Controls.Add(this.btnExitStd);
            this.stdMenuPanel.Controls.Add(this.btnLogoutStd);
            this.stdMenuPanel.Controls.Add(this.btnViewCourses);
            this.stdMenuPanel.Controls.Add(this.btnViewResults);
            this.stdMenuPanel.Controls.Add(this.btnTakeExam);
            this.stdMenuPanel.Controls.Add(this.stdUsernameLabel);
            this.stdMenuPanel.Controls.Add(this.insProfilePictureBox);
            this.stdMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.stdMenuPanel.Name = "stdMenuPanel";
            this.stdMenuPanel.Size = new System.Drawing.Size(308, 886);
            this.stdMenuPanel.TabIndex = 1;
            // 
            // btnExitStd
            // 
            this.btnExitStd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitStd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitStd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitStd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitStd.FillColor = System.Drawing.Color.Transparent;
            this.btnExitStd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitStd.ForeColor = System.Drawing.Color.White;
            this.btnExitStd.Image = ((System.Drawing.Image)(resources.GetObject("btnExitStd.Image")));
            this.btnExitStd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitStd.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnExitStd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExitStd.Location = new System.Drawing.Point(20, 790);
            this.btnExitStd.Name = "btnExitStd";
            this.btnExitStd.Size = new System.Drawing.Size(284, 45);
            this.btnExitStd.TabIndex = 24;
            this.btnExitStd.Text = "Exit ";
            this.btnExitStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitStd.TextOffset = new System.Drawing.Point(15, 0);
            this.btnExitStd.Click += new System.EventHandler(this.btnExitStd_Click);
            // 
            // btnLogoutStd
            // 
            this.btnLogoutStd.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogoutStd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogoutStd.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogoutStd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutStd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutStd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogoutStd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogoutStd.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogoutStd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogoutStd.ForeColor = System.Drawing.Color.White;
            this.btnLogoutStd.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoutStd.Image")));
            this.btnLogoutStd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogoutStd.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnLogoutStd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogoutStd.Location = new System.Drawing.Point(22, 616);
            this.btnLogoutStd.Name = "btnLogoutStd";
            this.btnLogoutStd.Size = new System.Drawing.Size(284, 45);
            this.btnLogoutStd.TabIndex = 25;
            this.btnLogoutStd.Text = "Logout";
            this.btnLogoutStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogoutStd.TextOffset = new System.Drawing.Point(16, 0);
            this.btnLogoutStd.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewCourses.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewCourses.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewCourses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCourses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCourses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCourses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCourses.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewCourses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCourses.Image")));
            this.btnViewCourses.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewCourses.ImageOffset = new System.Drawing.Point(12, 0);
            this.btnViewCourses.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewCourses.Location = new System.Drawing.Point(22, 541);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(284, 45);
            this.btnViewCourses.TabIndex = 21;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewCourses.TextOffset = new System.Drawing.Point(14, 0);
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewResults.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewResults.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewResults.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewResults.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewResults.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewResults.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewResults.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewResults.ForeColor = System.Drawing.Color.White;
            this.btnViewResults.Image = ((System.Drawing.Image)(resources.GetObject("btnViewResults.Image")));
            this.btnViewResults.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewResults.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnViewResults.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewResults.Location = new System.Drawing.Point(22, 461);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(284, 45);
            this.btnViewResults.TabIndex = 20;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewResults.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnTakeExam.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTakeExam.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnTakeExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeExam.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTakeExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTakeExam.ForeColor = System.Drawing.Color.White;
            this.btnTakeExam.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeExam.Image")));
            this.btnTakeExam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTakeExam.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTakeExam.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTakeExam.Location = new System.Drawing.Point(21, 382);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(284, 45);
            this.btnTakeExam.TabIndex = 19;
            this.btnTakeExam.Text = "Take Exam";
            this.btnTakeExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTakeExam.TextOffset = new System.Drawing.Point(9, 0);
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // stdUsernameLabel
            // 
            this.stdUsernameLabel.AutoSize = true;
            this.stdUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.stdUsernameLabel.Location = new System.Drawing.Point(56, 233);
            this.stdUsernameLabel.Name = "stdUsernameLabel";
            this.stdUsernameLabel.Size = new System.Drawing.Size(117, 25);
            this.stdUsernameLabel.TabIndex = 14;
            this.stdUsernameLabel.Text = " Ali Ahmed";
            this.stdUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insProfilePictureBox
            // 
            this.insProfilePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("insProfilePictureBox.BackgroundImage")));
            this.insProfilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.insProfilePictureBox.ErrorImage = null;
            this.insProfilePictureBox.InitialImage = null;
            this.insProfilePictureBox.Location = new System.Drawing.Point(64, 49);
            this.insProfilePictureBox.Name = "insProfilePictureBox";
            this.insProfilePictureBox.Size = new System.Drawing.Size(154, 170);
            this.insProfilePictureBox.TabIndex = 13;
            this.insProfilePictureBox.TabStop = false;
            // 
            // stdHomePanel
            // 
            this.stdHomePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stdHomePanel.Controls.Add(this.uC_ViewCourses1);
            this.stdHomePanel.Controls.Add(this.uC_TakeExam1);
            this.stdHomePanel.Location = new System.Drawing.Point(307, 0);
            this.stdHomePanel.Name = "stdHomePanel";
            this.stdHomePanel.Size = new System.Drawing.Size(1056, 886);
            this.stdHomePanel.TabIndex = 2;
            // 
            // uC_ViewCourses1
            // 
            this.uC_ViewCourses1.BackColor = System.Drawing.Color.White;
            this.uC_ViewCourses1.Location = new System.Drawing.Point(0, 1);
            this.uC_ViewCourses1.Name = "uC_ViewCourses1";
            this.uC_ViewCourses1.Size = new System.Drawing.Size(1056, 886);
            this.uC_ViewCourses1.TabIndex = 1;
            // 
            // uC_TakeExam1
            // 
            this.uC_TakeExam1.BackColor = System.Drawing.Color.White;
            this.uC_TakeExam1.Location = new System.Drawing.Point(0, 1);
            this.uC_TakeExam1.Name = "uC_TakeExam1";
            this.uC_TakeExam1.Size = new System.Drawing.Size(1056, 886);
            this.uC_TakeExam1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.stdHomePanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.stdHomePanel;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 886);
            this.Controls.Add(this.stdHomePanel);
            this.Controls.Add(this.stdMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.stdMenuPanel.ResumeLayout(false);
            this.stdMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insProfilePictureBox)).EndInit();
            this.stdHomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stdMenuPanel;
        private Guna.UI2.WinForms.Guna2Button btnExitStd;
        private Guna.UI2.WinForms.Guna2Button btnLogoutStd;
        private Guna.UI2.WinForms.Guna2Button btnViewCourses;
        private Guna.UI2.WinForms.Guna2Button btnViewResults;
        private Guna.UI2.WinForms.Guna2Button btnTakeExam;
        private System.Windows.Forms.Label stdUsernameLabel;
        private System.Windows.Forms.PictureBox insProfilePictureBox;
        private System.Windows.Forms.Panel stdHomePanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Student_UsrCtrl.UC_TakeExam uC_TakeExam1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Student_UsrCtrl.UC_ViewCourses uC_ViewCourses1;
    }
}