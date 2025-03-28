namespace ExamManagmentSystem.Student_UsrCtrl
{
    partial class UC_ViewResults
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
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.generateExamLabel = new System.Windows.Forms.Label();
            this.studentCoursesGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateExamLabel
            // 
            this.generateExamLabel.AutoSize = true;
            this.generateExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generateExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExamLabel.Location = new System.Drawing.Point(364, 91);
            this.generateExamLabel.Name = "generateExamLabel";
            this.generateExamLabel.Size = new System.Drawing.Size(219, 38);
            this.generateExamLabel.TabIndex = 4;
            this.generateExamLabel.Text = "View Results";
            // 
            // studentCoursesGridView1
            // 
            this.studentCoursesGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentCoursesGridView1.BackgroundColor = System.Drawing.Color.White;
            this.studentCoursesGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentCoursesGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentCoursesGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentCoursesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentCoursesGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentCoursesGridView1.EnableHeadersVisualStyles = false;
            this.studentCoursesGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentCoursesGridView1.Location = new System.Drawing.Point(246, 168);
            this.studentCoursesGridView1.Name = "studentCoursesGridView1";
            this.studentCoursesGridView1.RowHeadersVisible = false;
            this.studentCoursesGridView1.RowHeadersWidth = 51;
            this.studentCoursesGridView1.RowTemplate.Height = 24;
            this.studentCoursesGridView1.Size = new System.Drawing.Size(500, 581);
            this.studentCoursesGridView1.TabIndex = 18;
            this.studentCoursesGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentCoursesGridView1_CellContentClick);
            // 
            // UC_ViewResults
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.studentCoursesGridView1);
            this.Controls.Add(this.generateExamLabel);
            this.Name = "UC_ViewResults";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_ViewResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCoursesGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label generateExamLabel;
        private System.Windows.Forms.DataGridView studentCoursesGridView1;
    }
}
