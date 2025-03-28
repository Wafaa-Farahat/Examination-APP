namespace ExamManagmentSystem.Student_UsrCtrl
{
    partial class UC_TakeExam1
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
            this.takeExamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takeExamLabel
            // 
            this.takeExamLabel.AutoSize = true;
            this.takeExamLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.takeExamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeExamLabel.Location = new System.Drawing.Point(376, 33);
            this.takeExamLabel.Name = "takeExamLabel";
            this.takeExamLabel.Size = new System.Drawing.Size(274, 38);
            this.takeExamLabel.TabIndex = 8;
            this.takeExamLabel.Text = "Available Exams";
            this.takeExamLabel.Click += new System.EventHandler(this.takeExamLabel_Click);
            // 
            // UC_TakeExam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.takeExamLabel);
            this.Name = "UC_TakeExam1";
            this.Size = new System.Drawing.Size(1056, 886);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label takeExamLabel;
    }
}
