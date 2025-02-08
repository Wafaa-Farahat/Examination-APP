namespace ExamManagmentSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stdPanel = new System.Windows.Forms.Panel();
            this.chkShowHideStd = new System.Windows.Forms.CheckBox();
            this.stdPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStudentLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtEnrolmentNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.instPanel = new System.Windows.Forms.Panel();
            this.checkBoxShowHideIns = new System.Windows.Forms.CheckBox();
            this.btnInstructorLogin = new Guna.UI2.WinForms.Guna2Button();
            this.insPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtSelectUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wrongLabelStd = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stdPanel.SuspendLayout();
            this.instPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.stdPanel);
            this.guna2Panel1.Controls.Add(this.instPanel);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.txtSelectUser);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Location = new System.Drawing.Point(93, 87);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1211, 732);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(177, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 262);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(46, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // stdPanel
            // 
            this.stdPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stdPanel.Controls.Add(this.wrongLabelStd);
            this.stdPanel.Controls.Add(this.chkShowHideStd);
            this.stdPanel.Controls.Add(this.stdPassword);
            this.stdPanel.Controls.Add(this.label6);
            this.stdPanel.Controls.Add(this.btnStudentLogin);
            this.stdPanel.Controls.Add(this.txtEnrolmentNum);
            this.stdPanel.Controls.Add(this.label8);
            this.stdPanel.Controls.Add(this.label7);
            this.stdPanel.Location = new System.Drawing.Point(755, 274);
            this.stdPanel.Margin = new System.Windows.Forms.Padding(4);
            this.stdPanel.Name = "stdPanel";
            this.stdPanel.Size = new System.Drawing.Size(351, 399);
            this.stdPanel.TabIndex = 12;
            // 
            // chkShowHideStd
            // 
            this.chkShowHideStd.AutoSize = true;
            this.chkShowHideStd.Location = new System.Drawing.Point(128, 235);
            this.chkShowHideStd.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowHideStd.Name = "chkShowHideStd";
            this.chkShowHideStd.Size = new System.Drawing.Size(122, 20);
            this.chkShowHideStd.TabIndex = 8;
            this.chkShowHideStd.Text = "show password";
            this.chkShowHideStd.UseVisualStyleBackColor = true;
            this.chkShowHideStd.CheckedChanged += new System.EventHandler(this.chkShowHideStd_CheckedChanged);
            // 
            // stdPassword
            // 
            this.stdPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdPassword.DefaultText = "";
            this.stdPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stdPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stdPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdPassword.ForeColor = System.Drawing.Color.Black;
            this.stdPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdPassword.Location = new System.Drawing.Point(54, 187);
            this.stdPassword.Margin = new System.Windows.Forms.Padding(5);
            this.stdPassword.Name = "stdPassword";
            this.stdPassword.PasswordChar = '*';
            this.stdPassword.PlaceholderText = "";
            this.stdPassword.SelectedText = "";
            this.stdPassword.Size = new System.Drawing.Size(252, 38);
            this.stdPassword.TabIndex = 11;
            this.stdPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BorderRadius = 21;
            this.btnStudentLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnStudentLogin.Location = new System.Drawing.Point(59, 271);
            this.btnStudentLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(247, 44);
            this.btnStudentLogin.TabIndex = 9;
            this.btnStudentLogin.Text = "Login";
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // txtEnrolmentNum
            // 
            this.txtEnrolmentNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrolmentNum.DefaultText = "";
            this.txtEnrolmentNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnrolmentNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnrolmentNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrolmentNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrolmentNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrolmentNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrolmentNum.ForeColor = System.Drawing.Color.Black;
            this.txtEnrolmentNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrolmentNum.Location = new System.Drawing.Point(53, 109);
            this.txtEnrolmentNum.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnrolmentNum.Name = "txtEnrolmentNum";
            this.txtEnrolmentNum.PasswordChar = '\0';
            this.txtEnrolmentNum.PlaceholderText = "";
            this.txtEnrolmentNum.SelectedText = "";
            this.txtEnrolmentNum.Size = new System.Drawing.Size(252, 38);
            this.txtEnrolmentNum.TabIndex = 8;
            this.txtEnrolmentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEnrolmentNum.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Student Login";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enrollment Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // instPanel
            // 
            this.instPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.instPanel.Controls.Add(this.checkBoxShowHideIns);
            this.instPanel.Controls.Add(this.btnInstructorLogin);
            this.instPanel.Controls.Add(this.insPassword);
            this.instPanel.Controls.Add(this.txtUserName);
            this.instPanel.Controls.Add(this.wrongLabel);
            this.instPanel.Controls.Add(this.label5);
            this.instPanel.Controls.Add(this.label4);
            this.instPanel.Controls.Add(this.label3);
            this.instPanel.Location = new System.Drawing.Point(755, 274);
            this.instPanel.Margin = new System.Windows.Forms.Padding(4);
            this.instPanel.Name = "instPanel";
            this.instPanel.Size = new System.Drawing.Size(351, 399);
            this.instPanel.TabIndex = 11;
            // 
            // checkBoxShowHideIns
            // 
            this.checkBoxShowHideIns.AutoSize = true;
            this.checkBoxShowHideIns.Location = new System.Drawing.Point(117, 233);
            this.checkBoxShowHideIns.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowHideIns.Name = "checkBoxShowHideIns";
            this.checkBoxShowHideIns.Size = new System.Drawing.Size(122, 20);
            this.checkBoxShowHideIns.TabIndex = 7;
            this.checkBoxShowHideIns.Text = "show password";
            this.checkBoxShowHideIns.UseVisualStyleBackColor = true;
            this.checkBoxShowHideIns.CheckedChanged += new System.EventHandler(this.checkBoxShowHideIns_CheckedChanged);
            // 
            // btnInstructorLogin
            // 
            this.btnInstructorLogin.BorderRadius = 21;
            this.btnInstructorLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInstructorLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInstructorLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInstructorLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInstructorLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(107)))));
            this.btnInstructorLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructorLogin.ForeColor = System.Drawing.Color.White;
            this.btnInstructorLogin.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnInstructorLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnInstructorLogin.Location = new System.Drawing.Point(68, 270);
            this.btnInstructorLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstructorLogin.Name = "btnInstructorLogin";
            this.btnInstructorLogin.Size = new System.Drawing.Size(247, 44);
            this.btnInstructorLogin.TabIndex = 6;
            this.btnInstructorLogin.Text = "Login";
            this.btnInstructorLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // insPassword
            // 
            this.insPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.insPassword.DefaultText = "";
            this.insPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.insPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.insPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.insPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insPassword.ForeColor = System.Drawing.Color.Black;
            this.insPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.insPassword.Location = new System.Drawing.Point(63, 186);
            this.insPassword.Margin = new System.Windows.Forms.Padding(5);
            this.insPassword.Name = "insPassword";
            this.insPassword.PasswordChar = '*';
            this.insPassword.PlaceholderText = "";
            this.insPassword.SelectedText = "";
            this.insPassword.Size = new System.Drawing.Size(252, 38);
            this.insPassword.TabIndex = 5;
            this.insPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(60, 110);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(252, 38);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel.Location = new System.Drawing.Point(43, 335);
            this.wrongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(260, 20);
            this.wrongLabel.TabIndex = 3;
            this.wrongLabel.Text = "wrong \"user-name\" or \"password\"";
            this.wrongLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Instructor Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1133, 20);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSelectUser
            // 
            this.txtSelectUser.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSelectUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSelectUser.ForeColor = System.Drawing.Color.Black;
            this.txtSelectUser.ItemHeight = 30;
            this.txtSelectUser.Items.AddRange(new object[] {
            "Instructor",
            "Student"});
            this.txtSelectUser.Location = new System.Drawing.Point(171, 330);
            this.txtSelectUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectUser.Name = "txtSelectUser";
            this.txtSelectUser.Size = new System.Drawing.Size(275, 36);
            this.txtSelectUser.TabIndex = 7;
            this.txtSelectUser.SelectedIndexChanged += new System.EventHandler(this.txtSelectUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select User Type";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exam Managment System";
            // 
            // wrongLabelStd
            // 
            this.wrongLabelStd.AutoSize = true;
            this.wrongLabelStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongLabelStd.ForeColor = System.Drawing.Color.Red;
            this.wrongLabelStd.Location = new System.Drawing.Point(58, 335);
            this.wrongLabelStd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongLabelStd.Name = "wrongLabelStd";
            this.wrongLabelStd.Size = new System.Drawing.Size(248, 20);
            this.wrongLabelStd.TabIndex = 12;
            this.wrongLabelStd.Text = "wrong \"Enroll.No\" or \"password\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1365, 886);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stdPanel.ResumeLayout(false);
            this.stdPanel.PerformLayout();
            this.instPanel.ResumeLayout(false);
            this.instPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox txtSelectUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel stdPanel;
        private System.Windows.Forms.Panel instPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wrongLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtEnrolmentNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox insPassword;
        private Guna.UI2.WinForms.Guna2Button btnInstructorLogin;
        private System.Windows.Forms.CheckBox checkBoxShowHideIns;
        private Guna.UI2.WinForms.Guna2Button btnStudentLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox stdPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkShowHideStd;
        private System.Windows.Forms.Label wrongLabelStd;
    }
}

