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

namespace ExamManagmentSystem
{
    public partial class Instructor : Form
    {

        private int instId;
        public Instructor(int id)
        {
            InitializeComponent();
            instId = id;
        }

        public Instructor()
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_ViewQuestion1.Visible = true;
            uC_ViewQuestion1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_GenerateExam1.Visible = true;
            uC_GenerateExam1.BringToFront();


        }

        private void btnExitInst_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            uC_GenerateExam1.Visible = false;
            insUsernameLabel.Text=GetInstName(instId);
            uC_ViewQuestion1.Visible=false;
            uC_ViewRegisteredStudents1.Visible=false;
            uC_StudentsResults1.Visible=false;
            uC_CoursesList1.Visible=false;

        }

        private void uC_GenerateExam1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogoutIns_Click(object sender, EventArgs e)
        {
            Login insLog = new Login();
            insLog.Show();
            //insLog.txtSelectUser.SelectedIndex = 0;
            this.Hide();
        }


        private string GetInstName(int instId)
        {
            string instName = "Instructor"; // Default name
            string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT InsName FROM Instructor WHERE Ins_id = @InstructortId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@InstructortId", instId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // If student record is found
                        {
                            instName = $"{reader["InsName"]}";
                        }
                    }
                }
            }
            return instName;
        }

        private void insUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStud_Click(object sender, EventArgs e)
        {
            uC_ViewRegisteredStudents1.Visible=true;
            uC_ViewRegisteredStudents1.BringToFront();
        }

        private void btnViewCourseResult_Click(object sender, EventArgs e)
        {
            uC_ViewRegisteredStudents1.Visible = true;
            uC_StudentsResults1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_CoursesList1.Visible=true;
            uC_CoursesList1.BringToFront();    
        }
    }
}
