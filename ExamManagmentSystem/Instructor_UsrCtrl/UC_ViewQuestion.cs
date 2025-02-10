using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< Updated upstream
using System.Drawing;
=======
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
>>>>>>> Stashed changes
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using Microsoft.Reporting.WinForms;
>>>>>>> Stashed changes

namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    public partial class UC_ViewQuestion : UserControl
    {
        public UC_ViewQuestion()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        private void examModelsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_ViewQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnection.ConnectToSQL();

                if (conn != null)
                {
                    using (SqlCommand cmd = new SqlCommand("selectCoursesModels", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            examModelsList.Items.Clear();

                            while (reader.Read())
                            {
                                string modelInfo = $"{reader["CrName"]} Model {reader["Mid"]} ";
                                examModelsList.Items.Add(modelInfo);
                                //examModelsList.Items.Add(reader["Mid"].ToString());
                            }
                        }
                    }
                    if (examModelsList.Items.Count > 0)
                        examModelsList.SelectedIndex = 0;
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

        private void btnViewExamQuestions_Click(object sender, EventArgs e)
        {
            if (examModelsList.SelectedItem != null)
            {
                string selectedModel = examModelsList.SelectedItem.ToString();

                // Extract Mid from "CourseName Model Mid"
                string[] parts = selectedModel.Split(new string[] { " Model " }, StringSplitOptions.None);
                //MessageBox.Show($"{parts[1]}");

                if (parts.Length == 2 && int.TryParse(parts[1], out int examMid))
                {
                    try
                    {
                        // Connect to SQL Database
                        SqlConnection conn = SQLConnection.ConnectToSQL();
                        if (conn == null)
                        {
                            MessageBox.Show("Database connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Execute Stored Procedure
                        SqlCommand cmd = new SqlCommand("examQuestions", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MID", examMid);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        
                        // Set Report Path
                        string reportPath = Path.Combine(Application.StartupPath, "Reports", "Exam_Questions.rdl");
                        reportViewer1.LocalReport.ReportPath = reportPath;

                        // Pass Data to Report
                        ReportDataSource rds = new ReportDataSource("DataSet1", dt); // Change "ExamDataSet" to match your dataset name in the report
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);

                        // Refresh Report
                        reportViewer1.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Model Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
>>>>>>> Stashed changes
    }
}
