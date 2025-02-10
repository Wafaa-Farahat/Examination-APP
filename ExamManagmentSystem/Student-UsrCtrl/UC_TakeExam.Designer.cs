namespace ExamManagmentSystem.Student_UsrCtrl
{
    partial class UC_TakeExam
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
            this.takeExamLabel = new System.Windows.Forms.Label();
            this.btnTakeExam = new Guna.UI2.WinForms.Guna2Button();
            this.selectExamLabel = new System.Windows.Forms.Label();
            this.crsExamList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // takeExamLabel
            // 
            this.takeExamLabel.AutoSize = true;
            this.takeExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.takeExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeExamLabel.Location = new System.Drawing.Point(194, 112);
            this.takeExamLabel.Name = "takeExamLabel";
            this.takeExamLabel.Size = new System.Drawing.Size(202, 38);
            this.takeExamLabel.TabIndex = 7;
            this.takeExamLabel.Text = "Take Exam ";
            this.takeExamLabel.Click += new System.EventHandler(this.takeExamLabel_Click);
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.BorderRadius = 21;
            this.btnTakeExam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeExam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeExam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeExam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeExam.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTakeExam.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeExam.ForeColor = System.Drawing.Color.White;
            this.btnTakeExam.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnTakeExam.Location = new System.Drawing.Point(50, 615);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(286, 45);
            this.btnTakeExam.TabIndex = 6;
            this.btnTakeExam.Text = "Take Exam ";
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // selectExamLabel
            // 
            this.selectExamLabel.AutoSize = true;
            this.selectExamLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamLabel.Location = new System.Drawing.Point(45, 273);
            this.selectExamLabel.Name = "selectExamLabel";
            this.selectExamLabel.Size = new System.Drawing.Size(278, 26);
            this.selectExamLabel.TabIndex = 5;
            this.selectExamLabel.Text = "Select Course to Take Exam:";
            this.selectExamLabel.Click += new System.EventHandler(this.selectExamLabel_Click);
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
            this.crsExamList.TabIndex = 4;
            this.crsExamList.SelectedIndexChanged += new System.EventHandler(this.crsExamList_SelectedIndexChanged);
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // UC_TakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.takeExamLabel);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.selectExamLabel);
            this.Controls.Add(this.crsExamList);
            this.Name = "UC_TakeExam";
            this.Size = new System.Drawing.Size(1056, 886);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label takeExamLabel;
        private Guna.UI2.WinForms.Guna2Button btnTakeExam;
        private System.Windows.Forms.Label selectExamLabel;
        private Guna.UI2.WinForms.Guna2ComboBox crsExamList;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
    }
}
