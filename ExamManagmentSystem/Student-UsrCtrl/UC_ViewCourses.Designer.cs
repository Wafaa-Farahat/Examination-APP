namespace ExamManagmentSystem.Student_UsrCtrl
{
    partial class UC_ViewCourses
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.studentCoursesGridView = new System.Windows.Forms.DataGridView();
            this.studentCoursesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // studentCoursesGridView
            // 
            this.studentCoursesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentCoursesGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentCoursesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentCoursesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentCoursesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentCoursesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentCoursesGridView.EnableHeadersVisualStyles = false;
            this.studentCoursesGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentCoursesGridView.Location = new System.Drawing.Point(84, 233);
            this.studentCoursesGridView.Name = "studentCoursesGridView";
            this.studentCoursesGridView.RowHeadersVisible = false;
            this.studentCoursesGridView.RowHeadersWidth = 51;
            this.studentCoursesGridView.RowTemplate.Height = 24;
            this.studentCoursesGridView.Size = new System.Drawing.Size(500, 581);
            this.studentCoursesGridView.TabIndex = 16;
            this.studentCoursesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentCoursesGridView_CellContentClick);
            // 
            // studentCoursesLabel
            // 
            this.studentCoursesLabel.AutoSize = true;
            this.studentCoursesLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCoursesLabel.Location = new System.Drawing.Point(194, 112);
            this.studentCoursesLabel.Name = "studentCoursesLabel";
            this.studentCoursesLabel.Size = new System.Drawing.Size(276, 38);
            this.studentCoursesLabel.TabIndex = 14;
            this.studentCoursesLabel.Text = "Student Courses";
            // 
            // UC_ViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentCoursesGridView);
            this.Controls.Add(this.studentCoursesLabel);
            this.Name = "UC_ViewCourses";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_ViewCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView studentCoursesGridView;
        private System.Windows.Forms.Label studentCoursesLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}
