namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    partial class UC_CoursesList
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
            this.generateExamLabel = new System.Windows.Forms.Label();
            this.selectExamLabel = new System.Windows.Forms.Label();
            this.Combo1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StudentView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // generateExamLabel
            // 
            this.generateExamLabel.AutoSize = true;
            this.generateExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generateExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExamLabel.Location = new System.Drawing.Point(425, 65);
            this.generateExamLabel.Name = "generateExamLabel";
            this.generateExamLabel.Size = new System.Drawing.Size(147, 38);
            this.generateExamLabel.TabIndex = 12;
            this.generateExamLabel.Text = "Courses";
            // 
            // selectExamLabel
            // 
            this.selectExamLabel.AutoSize = true;
            this.selectExamLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamLabel.Location = new System.Drawing.Point(80, 222);
            this.selectExamLabel.Name = "selectExamLabel";
            this.selectExamLabel.Size = new System.Drawing.Size(127, 26);
            this.selectExamLabel.TabIndex = 18;
            this.selectExamLabel.Text = "Select Track";
            // 
            // Combo1
            // 
            this.Combo1.AccessibleName = "";
            this.Combo1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            this.Combo1.AllowDrop = true;
            this.Combo1.BackColor = System.Drawing.Color.Transparent;
            this.Combo1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Combo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combo1.ItemHeight = 30;
            this.Combo1.Location = new System.Drawing.Point(22, 265);
            this.Combo1.Name = "Combo1";
            this.Combo1.Size = new System.Drawing.Size(286, 36);
            this.Combo1.TabIndex = 17;
            this.Combo1.SelectedIndexChanged += new System.EventHandler(this.Combo1_SelectedIndexChanged);
            // 
            // StudentView
            // 
            this.StudentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentView.BackgroundColor = System.Drawing.Color.White;
            this.StudentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentView.EnableHeadersVisualStyles = false;
            this.StudentView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentView.Location = new System.Drawing.Point(356, 213);
            this.StudentView.Name = "StudentView";
            this.StudentView.RowHeadersVisible = false;
            this.StudentView.RowHeadersWidth = 51;
            this.StudentView.RowTemplate.Height = 24;
            this.StudentView.Size = new System.Drawing.Size(677, 581);
            this.StudentView.TabIndex = 19;
            this.StudentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentView_CellContentClick);
            // 
            // UC_CoursesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StudentView);
            this.Controls.Add(this.selectExamLabel);
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.generateExamLabel);
            this.Name = "UC_CoursesList";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_CoursesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label generateExamLabel;
        private System.Windows.Forms.Label selectExamLabel;
        private Guna.UI2.WinForms.Guna2ComboBox Combo1;
        private System.Windows.Forms.DataGridView StudentView;
    }
}
