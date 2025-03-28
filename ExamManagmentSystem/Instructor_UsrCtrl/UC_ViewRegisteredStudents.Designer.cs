namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    partial class UC_ViewRegisteredStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.selectExamLabel = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.generateExamLabel = new System.Windows.Forms.Label();
            this.Registeredstudents = new System.Windows.Forms.DataGridView();
            this.Combo1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registeredstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // selectExamLabel
            // 
            this.selectExamLabel.AutoSize = true;
            this.selectExamLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectExamLabel.Location = new System.Drawing.Point(3, 220);
            this.selectExamLabel.Name = "selectExamLabel";
            this.selectExamLabel.Size = new System.Drawing.Size(418, 26);
            this.selectExamLabel.TabIndex = 2;
            this.selectExamLabel.Text = "Select Course to View Registered Students:";
            this.selectExamLabel.Click += new System.EventHandler(this.selectExamLabel_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(240, 150);
            this.guna2DataGridView1.TabIndex = 3;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // generateExamLabel
            // 
            this.generateExamLabel.AutoSize = true;
            this.generateExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.generateExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateExamLabel.Location = new System.Drawing.Point(347, 71);
            this.generateExamLabel.Name = "generateExamLabel";
            this.generateExamLabel.Size = new System.Drawing.Size(332, 38);
            this.generateExamLabel.TabIndex = 6;
            this.generateExamLabel.Text = "Registered Students";
            this.generateExamLabel.Click += new System.EventHandler(this.generateExamLabel_Click);
            // 
            // Registeredstudents
            // 
            this.Registeredstudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Registeredstudents.BackgroundColor = System.Drawing.Color.White;
            this.Registeredstudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registeredstudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Registeredstudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Registeredstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Registeredstudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.Registeredstudents.EnableHeadersVisualStyles = false;
            this.Registeredstudents.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Registeredstudents.Location = new System.Drawing.Point(522, 180);
            this.Registeredstudents.Name = "Registeredstudents";
            this.Registeredstudents.RowHeadersVisible = false;
            this.Registeredstudents.RowHeadersWidth = 51;
            this.Registeredstudents.RowTemplate.Height = 24;
            this.Registeredstudents.Size = new System.Drawing.Size(480, 552);
            this.Registeredstudents.TabIndex = 19;
            this.Registeredstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Registeredstudents_CellContentClick);
            // 
            // Combo1
            // 
            this.Combo1.BackColor = System.Drawing.Color.Transparent;
            this.Combo1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Combo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combo1.ItemHeight = 30;
            this.Combo1.Items.AddRange(new object[] {
            "SW",
            "SQL",
            "OOP",
            "CSS",
            "HTML"});
            this.Combo1.Location = new System.Drawing.Point(8, 276);
            this.Combo1.Name = "Combo1";
            this.Combo1.Size = new System.Drawing.Size(286, 36);
            this.Combo1.TabIndex = 20;
            // 
            // UC_ViewRegisteredStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.Registeredstudents);
            this.Controls.Add(this.generateExamLabel);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.selectExamLabel);
            this.Name = "UC_ViewRegisteredStudents";
            this.Size = new System.Drawing.Size(1056, 886);
            this.Load += new System.EventHandler(this.UC_ViewRegisteredStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Registeredstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label selectExamLabel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label generateExamLabel;
        private System.Windows.Forms.DataGridView Registeredstudents;
        private Guna.UI2.WinForms.Guna2ComboBox Combo1;
    }
}
