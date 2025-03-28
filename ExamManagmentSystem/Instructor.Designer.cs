namespace ExamManagmentSystem
{
    partial class Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            this.insMenuPanel = new System.Windows.Forms.Panel();
            this.btnExitInst = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogoutIns = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewCourseResult = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewStud = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewQues = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerateExam = new Guna.UI2.WinForms.Guna2Button();
            this.insUsernameLabel = new System.Windows.Forms.Label();
            this.insProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.instHomePanel = new System.Windows.Forms.Panel();
            this.uC_CoursesList1 = new ExamManagmentSystem.Instructor_UsrCtrl.UC_CoursesList();
            this.uC_StudentsResults1 = new ExamManagmentSystem.Instructor_UsrCtrl.UC_StudentsResults();
            this.uC_ViewRegisteredStudents1 = new ExamManagmentSystem.Instructor_UsrCtrl.UC_ViewRegisteredStudents();
            this.uC_ViewQuestion1 = new ExamManagmentSystem.Instructor_UsrCtrl.UC_ViewQuestion();
            this.uC_GenerateExam1 = new ExamManagmentSystem.Instructor_UsrCtrl.UC_GenerateExam();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.insMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insProfilePictureBox)).BeginInit();
            this.instHomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // insMenuPanel
            // 
            this.insMenuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insMenuPanel.Controls.Add(this.btnExitInst);
            this.insMenuPanel.Controls.Add(this.btnLogoutIns);
            this.insMenuPanel.Controls.Add(this.guna2Button5);
            this.insMenuPanel.Controls.Add(this.btnViewCourseResult);
            this.insMenuPanel.Controls.Add(this.btnViewStud);
            this.insMenuPanel.Controls.Add(this.btnViewQues);
            this.insMenuPanel.Controls.Add(this.btnGenerateExam);
            this.insMenuPanel.Controls.Add(this.insUsernameLabel);
            this.insMenuPanel.Controls.Add(this.insProfilePictureBox);
            this.insMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.insMenuPanel.Name = "insMenuPanel";
            this.insMenuPanel.Size = new System.Drawing.Size(308, 886);
            this.insMenuPanel.TabIndex = 0;
            this.insMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExitInst
            // 
            this.btnExitInst.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitInst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitInst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitInst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitInst.FillColor = System.Drawing.Color.Transparent;
            this.btnExitInst.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitInst.ForeColor = System.Drawing.Color.White;
            this.btnExitInst.Image = ((System.Drawing.Image)(resources.GetObject("btnExitInst.Image")));
            this.btnExitInst.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitInst.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnExitInst.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExitInst.Location = new System.Drawing.Point(20, 790);
            this.btnExitInst.Name = "btnExitInst";
            this.btnExitInst.Size = new System.Drawing.Size(284, 45);
            this.btnExitInst.TabIndex = 24;
            this.btnExitInst.Text = "Exit ";
            this.btnExitInst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitInst.TextOffset = new System.Drawing.Point(15, 0);
            this.btnExitInst.Click += new System.EventHandler(this.btnExitInst_Click);
            // 
            // btnLogoutIns
            // 
            this.btnLogoutIns.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLogoutIns.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogoutIns.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogoutIns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutIns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogoutIns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogoutIns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogoutIns.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogoutIns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogoutIns.ForeColor = System.Drawing.Color.White;
            this.btnLogoutIns.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoutIns.Image")));
            this.btnLogoutIns.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogoutIns.ImageOffset = new System.Drawing.Point(17, 0);
            this.btnLogoutIns.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogoutIns.Location = new System.Drawing.Point(20, 710);
            this.btnLogoutIns.Name = "btnLogoutIns";
            this.btnLogoutIns.Size = new System.Drawing.Size(284, 45);
            this.btnLogoutIns.TabIndex = 25;
            this.btnLogoutIns.Text = "Logout";
            this.btnLogoutIns.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogoutIns.TextOffset = new System.Drawing.Point(16, 0);
            this.btnLogoutIns.Click += new System.EventHandler(this.btnLogoutIns_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(12, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button5.Location = new System.Drawing.Point(24, 640);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(284, 45);
            this.guna2Button5.TabIndex = 23;
            this.guna2Button5.Text = "Courses List";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.TextOffset = new System.Drawing.Point(15, 0);
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnViewCourseResult
            // 
            this.btnViewCourseResult.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewCourseResult.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewCourseResult.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewCourseResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCourseResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewCourseResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewCourseResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewCourseResult.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewCourseResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewCourseResult.ForeColor = System.Drawing.Color.White;
            this.btnViewCourseResult.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCourseResult.Image")));
            this.btnViewCourseResult.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewCourseResult.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnViewCourseResult.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewCourseResult.Location = new System.Drawing.Point(24, 560);
            this.btnViewCourseResult.Name = "btnViewCourseResult";
            this.btnViewCourseResult.Size = new System.Drawing.Size(284, 45);
            this.btnViewCourseResult.TabIndex = 22;
            this.btnViewCourseResult.Text = "Students Results";
            this.btnViewCourseResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewCourseResult.TextOffset = new System.Drawing.Point(14, 0);
            this.btnViewCourseResult.Click += new System.EventHandler(this.btnViewCourseResult_Click);
            // 
            // btnViewStud
            // 
            this.btnViewStud.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewStud.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewStud.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewStud.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStud.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStud.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewStud.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewStud.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewStud.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewStud.ForeColor = System.Drawing.Color.White;
            this.btnViewStud.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStud.Image")));
            this.btnViewStud.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewStud.ImageOffset = new System.Drawing.Point(12, 0);
            this.btnViewStud.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewStud.Location = new System.Drawing.Point(24, 480);
            this.btnViewStud.Name = "btnViewStud";
            this.btnViewStud.Size = new System.Drawing.Size(284, 45);
            this.btnViewStud.TabIndex = 21;
            this.btnViewStud.Text = "View Registered Students";
            this.btnViewStud.TextOffset = new System.Drawing.Point(17, 0);
            this.btnViewStud.Click += new System.EventHandler(this.btnViewStud_Click);
            // 
            // btnViewQues
            // 
            this.btnViewQues.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnViewQues.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewQues.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewQues.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewQues.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewQues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewQues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewQues.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewQues.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewQues.ForeColor = System.Drawing.Color.White;
            this.btnViewQues.Image = ((System.Drawing.Image)(resources.GetObject("btnViewQues.Image")));
            this.btnViewQues.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewQues.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnViewQues.ImageSize = new System.Drawing.Size(20, 25);
            this.btnViewQues.Location = new System.Drawing.Point(24, 400);
            this.btnViewQues.Name = "btnViewQues";
            this.btnViewQues.Size = new System.Drawing.Size(284, 45);
            this.btnViewQues.TabIndex = 20;
            this.btnViewQues.Text = "View Questions";
            this.btnViewQues.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewQues.TextOffset = new System.Drawing.Point(20, 0);
            this.btnViewQues.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnGenerateExam
            // 
            this.btnGenerateExam.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnGenerateExam.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnGenerateExam.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateExam.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateExam.ForeColor = System.Drawing.Color.White;
            this.btnGenerateExam.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateExam.Image")));
            this.btnGenerateExam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerateExam.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnGenerateExam.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGenerateExam.Location = new System.Drawing.Point(24, 320);
            this.btnGenerateExam.Name = "btnGenerateExam";
            this.btnGenerateExam.Size = new System.Drawing.Size(284, 45);
            this.btnGenerateExam.TabIndex = 19;
            this.btnGenerateExam.Text = "Generate Exam";
            this.btnGenerateExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerateExam.TextOffset = new System.Drawing.Point(9, 0);
            this.btnGenerateExam.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // insUsernameLabel
            // 
            this.insUsernameLabel.AutoSize = true;
            this.insUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insUsernameLabel.ForeColor = System.Drawing.Color.White;
            this.insUsernameLabel.Location = new System.Drawing.Point(82, 233);
            this.insUsernameLabel.Name = "insUsernameLabel";
            this.insUsernameLabel.Size = new System.Drawing.Size(122, 25);
            this.insUsernameLabel.TabIndex = 14;
            this.insUsernameLabel.Text = "Ramy Nagy";
            this.insUsernameLabel.Click += new System.EventHandler(this.insUsernameLabel_Click);
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
            // instHomePanel
            // 
            this.instHomePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.instHomePanel.Controls.Add(this.uC_CoursesList1);
            this.instHomePanel.Controls.Add(this.uC_StudentsResults1);
            this.instHomePanel.Controls.Add(this.uC_ViewRegisteredStudents1);
            this.instHomePanel.Controls.Add(this.uC_ViewQuestion1);
            this.instHomePanel.Controls.Add(this.uC_GenerateExam1);
            this.instHomePanel.Location = new System.Drawing.Point(307, 0);
            this.instHomePanel.Name = "instHomePanel";
            this.instHomePanel.Size = new System.Drawing.Size(1056, 886);
            this.instHomePanel.TabIndex = 1;
            this.instHomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // uC_CoursesList1
            // 
            this.uC_CoursesList1.BackColor = System.Drawing.Color.White;
            this.uC_CoursesList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CoursesList1.Location = new System.Drawing.Point(0, 1);
            this.uC_CoursesList1.Name = "uC_CoursesList1";
            this.uC_CoursesList1.Size = new System.Drawing.Size(1056, 886);
            this.uC_CoursesList1.TabIndex = 28;
            this.uC_CoursesList1.Load += new System.EventHandler(this.uC_CoursesList1_Load);
            // 
            // uC_StudentsResults1
            // 
            this.uC_StudentsResults1.BackColor = System.Drawing.Color.White;
            this.uC_StudentsResults1.Location = new System.Drawing.Point(0, 1);
            this.uC_StudentsResults1.Name = "uC_StudentsResults1";
            this.uC_StudentsResults1.Size = new System.Drawing.Size(1056, 886);
            this.uC_StudentsResults1.TabIndex = 27;
            // 
            // uC_ViewRegisteredStudents1
            // 
            this.uC_ViewRegisteredStudents1.BackColor = System.Drawing.Color.White;
            this.uC_ViewRegisteredStudents1.Location = new System.Drawing.Point(0, 1);
            this.uC_ViewRegisteredStudents1.Name = "uC_ViewRegisteredStudents1";
            this.uC_ViewRegisteredStudents1.Size = new System.Drawing.Size(1056, 886);
            this.uC_ViewRegisteredStudents1.TabIndex = 26;
            // 
            // uC_ViewQuestion1
            // 
            this.uC_ViewQuestion1.BackColor = System.Drawing.Color.White;
            this.uC_ViewQuestion1.Location = new System.Drawing.Point(0, 1);
            this.uC_ViewQuestion1.Name = "uC_ViewQuestion1";
            this.uC_ViewQuestion1.Size = new System.Drawing.Size(1056, 886);
            this.uC_ViewQuestion1.TabIndex = 1;
            // 
            // uC_GenerateExam1
            // 
            this.uC_GenerateExam1.BackColor = System.Drawing.Color.White;
            this.uC_GenerateExam1.Location = new System.Drawing.Point(0, 1);
            this.uC_GenerateExam1.Name = "uC_GenerateExam1";
            this.uC_GenerateExam1.Size = new System.Drawing.Size(1056, 886);
            this.uC_GenerateExam1.TabIndex = 0;
            this.uC_GenerateExam1.Load += new System.EventHandler(this.uC_GenerateExam1_Load);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.instHomePanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.instHomePanel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.instHomePanel;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.instHomePanel;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.instHomePanel;
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 886);
            this.Controls.Add(this.instHomePanel);
            this.Controls.Add(this.insMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor";
            this.Load += new System.EventHandler(this.Instructor_Load);
            this.insMenuPanel.ResumeLayout(false);
            this.insMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insProfilePictureBox)).EndInit();
            this.instHomePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel insMenuPanel;
        private System.Windows.Forms.Panel instHomePanel;
        private System.Windows.Forms.Label insUsernameLabel;
        private System.Windows.Forms.PictureBox insProfilePictureBox;
        private Guna.UI2.WinForms.Guna2Button btnViewCourseResult;
        private Guna.UI2.WinForms.Guna2Button btnViewStud;
        private Guna.UI2.WinForms.Guna2Button btnViewQues;
        private Guna.UI2.WinForms.Guna2Button btnGenerateExam;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnLogoutIns;
        private Guna.UI2.WinForms.Guna2Button btnExitInst;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Instructor_UsrCtrl.UC_GenerateExam uC_GenerateExam1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Instructor_UsrCtrl.UC_ViewQuestion uC_ViewQuestion1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Instructor_UsrCtrl.UC_StudentsResults uC_StudentsResults1;
        private Instructor_UsrCtrl.UC_ViewRegisteredStudents uC_ViewRegisteredStudents1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Instructor_UsrCtrl.UC_CoursesList uC_CoursesList1;
    }
}