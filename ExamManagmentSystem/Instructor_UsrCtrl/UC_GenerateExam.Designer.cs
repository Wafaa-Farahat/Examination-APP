namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    partial class UC_GenerateExam
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
            this.crsExamList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selectExamLabel = new System.Windows.Forms.Label();
            this.btnGenerateModelExam = new Guna.UI2.WinForms.Guna2Button();
            this.generateExamLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // crsExamList
            // 
            this.crsExamList.BackColor = System.Drawing.Color.Transparent;
            this.crsExamList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.crsExamList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.crsExamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crsExamList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crsExamList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crsExamList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.crsExamList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.crsExamList.ItemHeight = 30;
            this.crsExamList.Items.AddRange(new object[] {
            "SW",
            "SQL",
            "OOP",
            "CSS",
            "HTML"});
            this.crsExamList.Location = new System.Drawing.Point(50, 337);
            this.crsExamList.Name = "crsExamList";
            this.crsExamList.Size = new System.Drawing.Size(286, 36);
            this.crsExamList.TabIndex = 0;
            this.crsExamList.SelectedIndexChanged += new System.EventHandler(this.crsExamList_SelectedIndexChanged);
            // 
            // selectExamLabel
            // 
            this.selectExamLabel.AutoSize = true;
            this.selectExamLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamLabel.Location = new System.Drawing.Point(45, 273);
            this.selectExamLabel.Name = "selectExamLabel";
            this.selectExamLabel.Size = new System.Drawing.Size(319, 26);
            this.selectExamLabel.TabIndex = 1;
            this.selectExamLabel.Text = "Select Course to Generate Exam:";
            // 
            // btnGenerateModelExam
            // 
            this.btnGenerateModelExam.BorderRadius = 21;
            this.btnGenerateModelExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateModelExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateModelExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateModelExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateModelExam.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGenerateModelExam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateModelExam.ForeColor = System.Drawing.Color.White;
            this.btnGenerateModelExam.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateModelExam.Location = new System.Drawing.Point(50, 615);
            this.btnGenerateModelExam.Name = "btnGenerateModelExam";
            this.btnGenerateModelExam.Size = new System.Drawing.Size(286, 45);
            this.btnGenerateModelExam.TabIndex = 2;
            this.btnGenerateModelExam.Text = "Generate Exam Model";
            this.btnGenerateModelExam.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // generateExamLabel
            // 
            this.generateExamLabel.AutoSize = true;
            this.generateExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generateExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExamLabel.Location = new System.Drawing.Point(194, 112);
            this.generateExamLabel.Name = "generateExamLabel";
            this.generateExamLabel.Size = new System.Drawing.Size(375, 39);
            this.generateExamLabel.TabIndex = 3;
            this.generateExamLabel.Text = "Generate Exam Model";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_GenerateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.generateExamLabel);
            this.Controls.Add(this.btnGenerateModelExam);
            this.Controls.Add(this.selectExamLabel);
            this.Controls.Add(this.crsExamList);
            this.Name = "UC_GenerateExam";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_GenerateExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox crsExamList;
        private System.Windows.Forms.Label selectExamLabel;
        private Guna.UI2.WinForms.Guna2Button btnGenerateModelExam;
        private System.Windows.Forms.Label generateExamLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
