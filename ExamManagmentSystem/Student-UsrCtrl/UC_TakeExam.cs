//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ExamManagmentSystem.Student_UsrCtrl
//{
//    public partial class UC_TakeExam : UserControl
//    {
//        private int studentId;

//        public UC_TakeExam()
//        {
//            InitializeComponent();
//        }

//        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void takeExamLabel_Click(object sender, EventArgs e)
//        {

//        }

//        private void selectExamLabel_Click(object sender, EventArgs e)
//        {

//        }

//          public void LoadStudentCourses(int studentId)
//        {
//            string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                con.Open();

//                using (SqlCommand cmd = new SqlCommand("GetStudentCoursesWithModelsAndNoExam", con))
//                {
//                    cmd.CommandType = CommandType.StoredProcedure;
//                    cmd.Parameters.AddWithValue("@student_id", studentId);

//                    SqlDataReader reader = cmd.ExecuteReader();
//                    Dictionary<int, string> courses = new Dictionary<int, string>();

//                    while (reader.Read())
//                    {
//                        int courseId = reader.GetInt32(0);
//                        string courseName = reader.GetString(1);
//                        courses.Add(courseId, courseName);
//                    }

//                    // Temporarily disable event handling to prevent unwanted triggers
//                    crsExamList.SelectedIndexChanged -= crsExamList_SelectedIndexChanged;

//                    if (courses.Count > 0)
//                    {
//                        // Populate the list only if there are available courses
//                        crsExamList.DataSource = new BindingSource(courses, null);
//                        crsExamList.DisplayMember = "Value";
//                        crsExamList.ValueMember = "Key";

//                        crsExamList.SelectedIndex = -1; // No item selected by default
//                        crsExamList.Text = "Select Course"; // Set placeholder text

//                        btnTakeExam.Enabled = false;
//                        crsExamList.Enabled = true; // Enable the ComboBox

//                    }
//                    else
//                    {
//                        // Show message, clear the dropdown, and disable the button
//                        MessageBox.Show("No exams or courses available.");
//                        crsExamList.DataSource = null; // Keep the dropdown empty
//                        crsExamList.Items.Clear(); // Ensure list is cleared
//                        crsExamList.Text = "No Courses Available"; // Placeholder text

//                        btnTakeExam.Enabled = false;
//                        crsExamList.Enabled = false; // Disable the ComboBox

//                    }

//                    // Re-enable event handling after data is loaded
//                    crsExamList.SelectedIndexChanged += crsExamList_SelectedIndexChanged;
//                }
//            }
//        }

//        private void crsExamList_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Prevent unnecessary message when no valid selection is made
//            if (crsExamList.SelectedIndex == -1 || crsExamList.SelectedValue == null)
//            {
//                btnTakeExam.Enabled = false;
//                return;
//            }

//            int selectedCourseId;
//            if (int.TryParse(crsExamList.SelectedValue.ToString(), out selectedCourseId))
//            {
//                btnTakeExam.Enabled = true;
//                Console.WriteLine($"Course ID: {selectedCourseId}");
//            }
//            else
//            {
//                btnTakeExam.Enabled = false;
//                MessageBox.Show("Invalid course selected.");
//            }
//        }





//        private void btnTakeExam_Click(object sender, EventArgs e)
//        {
//            if (crsExamList.SelectedIndex == -1 || crsExamList.SelectedValue == null)
//            {
//                MessageBox.Show("Please select a course first.");
//                return;
//            }

//            string selectedCourse = crsExamList.Text; // Get course name
//            int selectedModelId = GetRandomExamModel(selectedCourse); // Get model ID

//            if (selectedModelId == -1)
//            {
//                MessageBox.Show("No exam model found for this course.");
//                return;
//            }

//            // ✅ Pass model ID and course name
//            UC_ExamScreen examScreen = new UC_ExamScreen(selectedModelId, selectedCourse, studentId);

//            // ✅ Access stdHomePanel from the parent form
//            Form parentForm = this.FindForm(); // Get the parent form
//            if (parentForm != null)
//            {
//                Panel stdHomePanel = parentForm.Controls.Find("stdHomePanel", true).FirstOrDefault() as Panel;

//                if (stdHomePanel != null)
//                {
//                    stdHomePanel.Controls.Clear();
//                    stdHomePanel.Controls.Add(examScreen);
//                    examScreen.Dock = DockStyle.Fill;
//                    examScreen.BringToFront();
//                }
//                else
//                {
//                    MessageBox.Show("Panel stdHomePanel not found.");
//                }
//            }
//        }


//        // Function to execute the stored procedure and get the model ID
//        private int GetRandomExamModel(string courseName)
//        {
//            string connectionString = @"Server=DESKTOP-K467VME\SQLEXPRESS;Database=5th edition;Integrated Security=True;";
//            int modelId = -1;

//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                con.Open();
//                using (SqlCommand cmd = new SqlCommand("GetRandomModelAndExam", con))
//                {
//                    cmd.CommandType = CommandType.StoredProcedure;
//                    cmd.Parameters.AddWithValue("@coursename", courseName);

//                    // Output parameter to store the selected model ID
//                    SqlParameter outputModelId = new SqlParameter("@student_selected_model", SqlDbType.Int)
//                    {
//                        Direction = ParameterDirection.Output
//                    };
//                    cmd.Parameters.Add(outputModelId);

//                    // Execute procedure
//                    using (SqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        if (reader.HasRows)
//                        {
//                            // Read the first row to get model ID
//                            reader.Read();
//                            modelId = Convert.ToInt32(outputModelId.Value);
//                        }
//                    }
//                }
//            }

//            return modelId;
//        }

//    }
//}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ExamManagmentSystem.Student_UsrCtrl
{
    public partial class UC_TakeExam : UserControl
    {
        private int studentId;

        public UC_TakeExam() // Keep default constructor
        {
            InitializeComponent();
        }

        public UC_TakeExam(int stdId) // Overloaded constructor (optional usage)
        {
            InitializeComponent();
            studentId = stdId;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void takeExamLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectExamLabel_Click(object sender, EventArgs e)
        {

        }

        public void LoadStudentCourses(int studentId)
        {
            this.studentId = studentId;
            string connectionString = @"Server=SOLI\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetStudentCoursesWithModelsAndNoExam", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@student_id", studentId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    Dictionary<int, string> courses = new Dictionary<int, string>();

                    while(reader.Read())
                    {
                        int modelId = reader.GetInt32(0);  // Model ID (was courseId before)
                        string courseName = reader.GetString(1);
                        courses.Add(modelId, courseName); // Store Model ID, not Course ID
                    }

                    crsExamList.SelectedIndexChanged -= crsExamList_SelectedIndexChanged;

                    if (courses.Count > 0)
                    {
                        crsExamList.DataSource = new BindingSource(courses, null);
                        crsExamList.DisplayMember = "Value";
                        crsExamList.ValueMember = "Key";
                        crsExamList.SelectedIndex = -1;
                        crsExamList.Text = "Select Course";

                        btnTakeExam.Enabled = false;
                        crsExamList.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("No exams or courses available.");
                        crsExamList.DataSource = null;
                        crsExamList.Items.Clear();
                        crsExamList.Text = "No Courses Available";

                        btnTakeExam.Enabled = false;
                        crsExamList.Enabled = false;
                    }

                    crsExamList.SelectedIndexChanged += crsExamList_SelectedIndexChanged;
                }
            }
        }

        private void crsExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTakeExam.Enabled = crsExamList.SelectedIndex != -1 && crsExamList.SelectedValue != null;
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            if (crsExamList.SelectedIndex == -1 || crsExamList.SelectedValue == null)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show(
            "Are you sure you want to take this exam?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
                   );

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Good luck!");

                    int selectedModelId = Convert.ToInt32(crsExamList.SelectedValue); // Use Model ID
                    string selectedCourse = crsExamList.Text;

                    UC_ExamScreen examScreen = new UC_ExamScreen(selectedModelId, selectedCourse, this.studentId);
                    Form parentForm = this.FindForm();

                    if (parentForm != null)
                    {
                        Panel stdHomePanel = parentForm.Controls.Find("stdHomePanel", true).FirstOrDefault() as Panel;
                        if (stdHomePanel != null)
                        {
                            stdHomePanel.Controls.Clear();
                            stdHomePanel.Controls.Add(examScreen);
                            examScreen.Dock = DockStyle.Fill;
                            examScreen.BringToFront();
                        }
                    }
                }
                
                
            }


        }

        private void UC_TakeExam_Load(object sender, EventArgs e)
        {

        }
    }
}

