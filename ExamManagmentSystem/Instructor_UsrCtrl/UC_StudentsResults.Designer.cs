namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    partial class UC_StudentsResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.courseResultList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selectInsCourseLabel = new System.Windows.Forms.Label();
            this.studentsResultLabel = new System.Windows.Forms.Label();
            this.btnViewStudentsResult = new Guna.UI2.WinForms.Guna2Button();
            this.studentsResultGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // courseResultList
            // 
            this.courseResultList.BackColor = System.Drawing.Color.Transparent;
            this.courseResultList.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseResultList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseResultList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseResultList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseResultList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseResultList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.courseResultList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.courseResultList.ItemHeight = 30;
            this.courseResultList.Items.AddRange(new object[] {
            "SW",
            "SQL",
            "OOP",
            "CSS",
            "HTML"});
            this.courseResultList.Location = new System.Drawing.Point(50, 337);
            this.courseResultList.Name = "courseResultList";
            this.courseResultList.Size = new System.Drawing.Size(349, 36);
            this.courseResultList.TabIndex = 7;
            this.courseResultList.SelectedIndexChanged += new System.EventHandler(this.courseResultList_SelectedIndexChanged);
            // 
            // selectInsCourseLabel
            // 
            this.selectInsCourseLabel.AutoSize = true;
            this.selectInsCourseLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectInsCourseLabel.Location = new System.Drawing.Point(45, 273);
            this.selectInsCourseLabel.Name = "selectInsCourseLabel";
            this.selectInsCourseLabel.Size = new System.Drawing.Size(371, 26);
            this.selectInsCourseLabel.TabIndex = 8;
            this.selectInsCourseLabel.Text = "Select Course to View Students Result";
            // 
            // studentsResultLabel
            // 
            this.studentsResultLabel.AutoSize = true;
            this.studentsResultLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentsResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsResultLabel.Location = new System.Drawing.Point(194, 112);
            this.studentsResultLabel.Name = "studentsResultLabel";
            this.studentsResultLabel.Size = new System.Drawing.Size(263, 38);
            this.studentsResultLabel.TabIndex = 9;
            this.studentsResultLabel.Text = "Students Result";
            this.studentsResultLabel.Click += new System.EventHandler(this.generateExamLabel_Click);
            // 
            // btnViewStudentsResult
            // 
            this.btnViewStudentsResult.BorderRadius = 21;
            this.btnViewStudentsResult.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStudentsResult.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStudentsResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewStudentsResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewStudentsResult.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewStudentsResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewStudentsResult.ForeColor = System.Drawing.Color.White;
            this.btnViewStudentsResult.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnViewStudentsResult.Location = new System.Drawing.Point(50, 615);
            this.btnViewStudentsResult.Name = "btnViewStudentsResult";
            this.btnViewStudentsResult.Size = new System.Drawing.Size(286, 45);
            this.btnViewStudentsResult.TabIndex = 10;
            this.btnViewStudentsResult.Text = "View Students Result";
            this.btnViewStudentsResult.Click += new System.EventHandler(this.btnViewStudentsResult_Click);
            // 
            // studentsResultGridView
            // 
            this.studentsResultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentsResultGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentsResultGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsResultGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentsResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentsResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentsResultGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentsResultGridView.EnableHeadersVisualStyles = false;
            this.studentsResultGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentsResultGridView.Location = new System.Drawing.Point(488, 289);
            this.studentsResultGridView.Name = "studentsResultGridView";
            this.studentsResultGridView.RowHeadersVisible = false;
            this.studentsResultGridView.RowHeadersWidth = 51;
            this.studentsResultGridView.RowTemplate.Height = 24;
            this.studentsResultGridView.Size = new System.Drawing.Size(500, 274);
            this.studentsResultGridView.TabIndex = 11;
            this.studentsResultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsResultGridView_CellContentClick);
            // 
            // UC_StudentsResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentsResultGridView);
            this.Controls.Add(this.btnViewStudentsResult);
            this.Controls.Add(this.studentsResultLabel);
            this.Controls.Add(this.selectInsCourseLabel);
            this.Controls.Add(this.courseResultList);
            this.Name = "UC_StudentsResults";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_StudentsResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsResultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox courseResultList;
        private System.Windows.Forms.Label selectInsCourseLabel;
        private System.Windows.Forms.Label studentsResultLabel;
        private Guna.UI2.WinForms.Guna2Button btnViewStudentsResult;
        private System.Windows.Forms.DataGridView studentsResultGridView;
    }
}
