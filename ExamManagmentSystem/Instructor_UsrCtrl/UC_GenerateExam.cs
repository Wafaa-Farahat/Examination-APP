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
    public partial class UC_GenerateExam : UserControl
    {
        public UC_GenerateExam()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string selectedCourse = crsExamList.SelectedItem.ToString();
            SqlConnection connection = SQLConnection.ConnectToSQL();
            bool isExecuted = SQLConnection.execProcedure("generate_exam", "@crs", selectedCourse, connection);
            if(isExecuted) 
                MessageBox.Show("Exam generated successfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed to generate exam try later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void crsExamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_GenerateExam_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnection.ConnectToSQL();
                
                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand("selectSpecificCourses", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            crsExamList.Items.Clear();

                            while (reader.Read())
                            {
                                crsExamList.Items.Add(reader["CrName"].ToString());
                            }
                        }
                    }
                    if (crsExamList.Items.Count > 0)
                        crsExamList.SelectedIndex = 0;
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

    }
}
