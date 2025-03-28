namespace ExamManagmentSystem.Student_UsrCtrl
{
    partial class UC_MyAnswers
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.answersReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnViewExamAnswers = new Guna.UI2.WinForms.Guna2Button();
            this.stdCoursesList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selectStdCourseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // answersReport
            // 
            this.answersReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answersReport.Location = new System.Drawing.Point(2, 1);
            this.answersReport.Name = "answersReport";
            this.answersReport.ServerReport.BearerToken = null;
            this.answersReport.Size = new System.Drawing.Size(1051, 614);
            this.answersReport.TabIndex = 12;
            this.answersReport.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.answersReport.Load += new System.EventHandler(this.answersReport_Load);
            // 
            // btnViewExamAnswers
            // 
            this.btnViewExamAnswers.BorderRadius = 21;
            this.btnViewExamAnswers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewExamAnswers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewExamAnswers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewExamAnswers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewExamAnswers.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewExamAnswers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewExamAnswers.ForeColor = System.Drawing.Color.White;
            this.btnViewExamAnswers.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnViewExamAnswers.Location = new System.Drawing.Point(565, 755);
            this.btnViewExamAnswers.Name = "btnViewExamAnswers";
            this.btnViewExamAnswers.Size = new System.Drawing.Size(286, 45);
            this.btnViewExamAnswers.TabIndex = 11;
            this.btnViewExamAnswers.Text = "View Exam Anwers";
            this.btnViewExamAnswers.Click += new System.EventHandler(this.btnViewExamAnswers_Click);
            // 
            // stdCoursesList
            // 
            this.stdCoursesList.BackColor = System.Drawing.Color.Transparent;
            this.stdCoursesList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.stdCoursesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.stdCoursesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stdCoursesList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdCoursesList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdCoursesList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stdCoursesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.stdCoursesList.ItemHeight = 30;
            this.stdCoursesList.Items.AddRange(new object[] {
            "SW",
            "SQL",
            "OOP",
            "CSS",
            "HTML"});
            this.stdCoursesList.Location = new System.Drawing.Point(50, 761);
            this.stdCoursesList.Name = "stdCoursesList";
            this.stdCoursesList.Size = new System.Drawing.Size(349, 36);
            this.stdCoursesList.TabIndex = 10;
            this.stdCoursesList.SelectedIndexChanged += new System.EventHandler(this.stdCoursesList_SelectedIndexChanged);
            // 
            // selectStdCourseLabel
            // 
            this.selectStdCourseLabel.AutoSize = true;
            this.selectStdCourseLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectStdCourseLabel.Location = new System.Drawing.Point(45, 690);
            this.selectStdCourseLabel.Name = "selectStdCourseLabel";
            this.selectStdCourseLabel.Size = new System.Drawing.Size(341, 26);
            this.selectStdCourseLabel.TabIndex = 9;
            this.selectStdCourseLabel.Text = "Select Course to view you Answers";
            // 
            // UC_MyAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.answersReport);
            this.Controls.Add(this.btnViewExamAnswers);
            this.Controls.Add(this.stdCoursesList);
            this.Controls.Add(this.selectStdCourseLabel);
            this.Name = "UC_MyAnswers";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_MyAnswers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Microsoft.Reporting.WinForms.ReportViewer answersReport;
        private Guna.UI2.WinForms.Guna2Button btnViewExamAnswers;
        private Guna.UI2.WinForms.Guna2ComboBox stdCoursesList;
        private System.Windows.Forms.Label selectStdCourseLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
