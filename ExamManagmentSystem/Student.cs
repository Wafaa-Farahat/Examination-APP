using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamManagmentSystem.Student_UsrCtrl;

namespace ExamManagmentSystem
{
    public partial class Student : Form
    {
        private int studentId;
        public Student(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show the login screen again
            Login loginForm = Application.OpenForms.OfType<Login>().FirstOrDefault();

            if (loginForm != null)
            {
                loginForm.Show();  // Show the existing login form if it was hidden
            }
            else
            {
                loginForm = new Login();  // Create a new instance if it's not found
                loginForm.Show();
            }

            this.Close();  // Close the current form (Student or Instructor)
        }


        private void btnExitStd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            uC_TakeExam1.Visible=true;
            uC_TakeExam1.BringToFront();
            uC_TakeExam1.LoadStudentCourses(studentId);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            uC_TakeExam1.Visible=false;
            uC_ViewCourses1.Visible=false;
            stdUsernameLabel.Text = GetStudentName(studentId);
            uC_ExamScreen1.Visible=false;
            uC_ViewCourses1.Visible = false;
            uC_ViewResults1.Visible = false;
            uC_MyAnswers1.Visible = false;
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            uC_ViewCourses1.Visible=true;
            uC_ViewCourses1.BringToFront();
            uC_ViewCourses1.ShowStudentCourses(studentId);
        }


        private string GetStudentName(int studentId)
        {
            string studentName = "Student"; // Default name
            string connectionString = @"Server=SOLI\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Fname, Lname FROM Student WHERE SId = @StudentId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // If student record is found
                        {
                            studentName = $"{reader["Fname"]} {reader["Lname"]}";
                        }
                    }
                }
            }
            return studentName;
        }
        private void uC_ViewCourses1_Load(object sender, EventArgs e)
        {
            uC_ViewCourses1.Visible = true;
            uC_ViewCourses1.BringToFront();
            uC_ViewCourses1.ShowStudentCourses(studentId);
        }

        private void uC_ViewResults1_Load(object sender, EventArgs e)
        {
            
        }

        private void stdMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewResults_Click_1(object sender, EventArgs e)
        {
            uC_ViewResults1.Visible = true;
            uC_ViewResults1.BringToFront();
            uC_ViewResults1.LoadStudentCourses(studentId);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_MyAnswers1.Visible = false;
            uC_MyAnswers1.BringToFront();
            uC_MyAnswers1.ShowStudentCourses(studentId);
        }
    }
}
