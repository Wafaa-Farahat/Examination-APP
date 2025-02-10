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
            Login stdLog = new Login();
            stdLog.Show();
            //stdLog.txtSelectUser.SelectedIndex = 1;
            this.Hide();

        }

        private void btnExitStd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            uC_TakeExam1.Visible=true;
            uC_TakeExam1.BringToFront();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            uC_TakeExam1.Visible=false;
            uC_ViewCourses1.Visible=false;
            stdUsernameLabel.Text = GetStudentName(studentId);
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            uC_ViewCourses1.Visible=true;
            uC_ViewCourses1.BringToFront();
        }


        private string GetStudentName(int studentId)
        {
            string studentName = "Student"; // Default name
<<<<<<< Updated upstream
            string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
=======
            string connectionString = "data source=DESKTOP-GN7HN93\\SQLEXPRESS;Database=Examination_System;Integrated Security=True;";
>>>>>>> Stashed changes

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


    }
}
