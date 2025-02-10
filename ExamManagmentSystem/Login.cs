using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ExamManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtSelectUser.SelectedIndex = 0;
            instPanel.Visible=true;
            stdPanel.Visible=false;
            wrongLabel.Visible=false;
            wrongLabelStd.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (txtSelectUser.SelectedIndex == 0) {
                instPanel.Visible = true;
                stdPanel.Visible = false;
            }else if(txtSelectUser.SelectedIndex == 1) 
            { 
                instPanel.Visible = false;
                stdPanel.Visible = true;
            }  
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void chkShowHideStd_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowHideStd.Checked == true)
            {
                stdPassword.PasswordChar = '\0';
                checkBoxShowHideIns.Text = "Hide Password";
            }
            else
            {
                stdPassword.PasswordChar = '*';
                checkBoxShowHideIns.Text="Show Password";
            }
        }

        private void checkBoxShowHideIns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHideIns.Checked == true)
            {
                insPassword.PasswordChar = '\0';
                checkBoxShowHideIns.Text = "Hide Password";
            }
            else
            {
                insPassword.PasswordChar = '*';
                checkBoxShowHideIns.Text = "Show Password";
            }
            {
                
            }
        }
        private void btnStudentRegisteration_Click(object sender, EventArgs e)
        {

        }


<<<<<<< Updated upstream
<<<<<<< Updated upstream
        //private string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
=======
        //private string connectionString = @"Server=DESKTOP-GN7HN93\\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
>>>>>>> Stashed changes
=======
        //private string connectionString = @"Server=DESKTOP-GN7HN93\\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
>>>>>>> Stashed changes
        //private bool AuthenticateUser(string tableName, string username, string password)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        con.Open();
        //        string query = $"SELECT COUNT(*) FROM {tableName} WHERE UserName = @UserName AND Password = @Password";

        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@UserName", username);
        //            cmd.Parameters.AddWithValue("@Password", password);

        //            int count = (int)cmd.ExecuteScalar();
        //            return count > 0;
        //        }
        //    }
        //}

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
=======
        private string connectionString = "data source=DESKTOP-GN7HN93\\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
>>>>>>> Stashed changes
=======
        private string connectionString = "data source=DESKTOP-GN7HN93\\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
>>>>>>> Stashed changes
        private int? AuthenticateUser(string tableName, string username, string password, out string userType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string idColumn = tableName == "Student" ? "SId" : "Ins_id"; // Choose correct ID column
                string query = $"SELECT {idColumn} FROM {tableName} WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        userType = tableName; // Set user type (Student or Instructor)
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        userType = null;
                        return null;
                    }
                }
            }
        }

       

        // Student login button
        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string userType;
            int? studentId = AuthenticateUser("Student", txtEnrolmentNum.Text, stdPassword.Text, out userType);

            if (studentId.HasValue && userType == "Student")
            {
                wrongLabelStd.Visible = false;
                Student std = new Student(studentId.Value); // Pass Student ID
                std.Show();
                this.Hide();
            }
            else
            {
                wrongLabelStd.Visible = true;
            }
        }

        // instructor loginBtn
        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            string userType;
            int? userId = AuthenticateUser("Instructor", txtUserName.Text, insPassword.Text, out userType);

            if (userId.HasValue && userType == "Instructor")
            {
                wrongLabel.Visible = false;
                Instructor inst = new Instructor(userId.Value); // Pass Instructor ID
                inst.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void imgComp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}
