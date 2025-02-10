namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    partial class UC_ViewQuestion
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
<<<<<<< Updated upstream
=======
            this.selectModelLabel = new System.Windows.Forms.Label();
            this.examModelsList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnViewExamQuestions = new Guna.UI2.WinForms.Guna2Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
<<<<<<< Updated upstream
=======
            // selectModelLabel
            // 
            this.selectModelLabel.AutoSize = true;
            this.selectModelLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectModelLabel.Location = new System.Drawing.Point(45, 688);
            this.selectModelLabel.Name = "selectModelLabel";
            this.selectModelLabel.Size = new System.Drawing.Size(313, 26);
            this.selectModelLabel.TabIndex = 5;
            this.selectModelLabel.Text = "Select Model to View Questions";
            // 
            // examModelsList
            // 
            this.examModelsList.BackColor = System.Drawing.Color.Transparent;
            this.examModelsList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.examModelsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.examModelsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examModelsList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.examModelsList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.examModelsList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.examModelsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.examModelsList.ItemHeight = 30;
            this.examModelsList.Items.AddRange(new object[] {
            "SW",
            "SQL",
            "OOP",
            "CSS",
            "HTML"});
            this.examModelsList.Location = new System.Drawing.Point(50, 759);
            this.examModelsList.Name = "examModelsList";
            this.examModelsList.Size = new System.Drawing.Size(349, 36);
            this.examModelsList.TabIndex = 6;
            this.examModelsList.SelectedIndexChanged += new System.EventHandler(this.examModelsList_SelectedIndexChanged);
            // 
            // btnViewExamQuestions
            // 
            this.btnViewExamQuestions.BorderRadius = 21;
            this.btnViewExamQuestions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewExamQuestions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewExamQuestions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewExamQuestions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewExamQuestions.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewExamQuestions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnViewExamQuestions.ForeColor = System.Drawing.Color.White;
            this.btnViewExamQuestions.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnViewExamQuestions.Location = new System.Drawing.Point(565, 753);
            this.btnViewExamQuestions.Name = "btnViewExamQuestions";
            this.btnViewExamQuestions.Size = new System.Drawing.Size(286, 45);
            this.btnViewExamQuestions.TabIndex = 7;
            this.btnViewExamQuestions.Text = "View Exam Questions";
            this.btnViewExamQuestions.Click += new System.EventHandler(this.btnViewExamQuestions_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1056, 614);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
>>>>>>> Stashed changes
            // UC_ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.Name = "UC_ViewQuestion";
            this.Size = new System.Drawing.Size(1056, 886);
            this.ResumeLayout(false);
=======
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnViewExamQuestions);
            this.Controls.Add(this.examModelsList);
            this.Controls.Add(this.selectModelLabel);
            this.Name = "UC_ViewQuestion";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_ViewQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> Stashed changes

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Label selectModelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox examModelsList;
        private Guna.UI2.WinForms.Guna2Button btnViewExamQuestions;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
>>>>>>> Stashed changes
    }
}
