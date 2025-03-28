using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ExamManagmentSystem.Student_UsrCtrl
{
    public partial class UC_MyAnswers : UserControl
    {
        private int Student_Id;
        public UC_MyAnswers()
        {
            InitializeComponent();
        }

        private void answersReport_Load(object sender, EventArgs e)
        {

        }

        public void ShowStudentCourses(int StID)
        {
            Student_Id = StID;
            try
            {
                SqlConnection conn = SQLConnection.ConnectToSQL();

                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand("GetStdtCourses", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@student_id", StID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            stdCoursesList.Items.Clear();

                            while (reader.Read())
                            {
                                stdCoursesList.Items.Add(reader["CrName"].ToString());
                            }
                        }
                    }
                    if (stdCoursesList.Items.Count > 0)
                        stdCoursesList.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Failed to connect to DataBase", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UC_MyAnswers_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewExamAnswers_Click(object sender, EventArgs e)
        {
            if (stdCoursesList.SelectedItem != null)
            {
                string selectedCourse = stdCoursesList.SelectedItem.ToString();
                int studentId = Student_Id; 

                try
                {
                    // Connect to SQL Database
                    SqlConnection conn = SQLConnection.ConnectToSQL();
                    if (conn == null)
                    {
                        MessageBox.Show("Database connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 1: Get MID using GetStudentModel procedure
                    SqlCommand cmdGetMID = new SqlCommand("GetStudentModel", conn);
                    cmdGetMID.CommandType = CommandType.StoredProcedure;
                    cmdGetMID.Parameters.AddWithValue("@course_name", selectedCourse);
                    cmdGetMID.Parameters.AddWithValue("@student_id", studentId);

                    object result = cmdGetMID.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show("No exam found for this course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int examMid = Convert.ToInt32(result);

                    // Step 2: Fetch Exam Questions & Student Answers using examQues_stdAnswer
                    SqlCommand cmdExamAnswers = new SqlCommand("examQues_stdAnswer", conn);
                    cmdExamAnswers.CommandType = CommandType.StoredProcedure;
                    cmdExamAnswers.Parameters.AddWithValue("@MID", examMid);
                    cmdExamAnswers.Parameters.AddWithValue("@StID", studentId);

                    SqlDataAdapter da = new SqlDataAdapter(cmdExamAnswers);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Step 3: Set Report Path
                    string reportPath = Path.Combine(Application.StartupPath, "Reports", "Student_Answer.rdl");
                    answersReport.LocalReport.ReportPath = reportPath;

                    // Step 4: Pass Data to Report
                    ReportDataSource rds = new ReportDataSource("Student_Answers", dt);
                    answersReport.LocalReport.DataSources.Clear();
                    answersReport.LocalReport.DataSources.Add(rds);

                    // Step 5: Refresh Report
                    answersReport.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void stdCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
