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

namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    public partial class UC_StudentsResults : UserControl
    {
        private int InsID;
        public UC_StudentsResults()
        {
            InitializeComponent();
        }

        private void generateExamLabel_Click(object sender, EventArgs e)
        {

        }

        private void courseResultList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadInstructorCourses(int InsID)
        {
            this.InsID = InsID;
            try
            {
                SqlConnection conn = SQLConnection.ConnectToSQL();

                if (conn != null)
                {

                    using (SqlCommand cmd = new SqlCommand("GetInstructorCourses", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@InsID", InsID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            courseResultList.Items.Clear();

                            while (reader.Read())
                            {
                                courseResultList.Items.Add(reader["CrName"]);
                            }
                        }
                    }

                    if (courseResultList.Items.Count > 0)
                        courseResultList.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Failed to connect to Database", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_StudentsResults_Load(object sender, EventArgs e)
        {
        }

        private void studentsResultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnViewStudentsResult_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCourse = courseResultList.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedCourse))
                {
                    MessageBox.Show("Please select a course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection connection = SQLConnection.ConnectToSQL())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand("GetStdsGradeInCourse", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Course", selectedCourse);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            studentsResultGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No students found for the selected course.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            studentsResultGridView.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
