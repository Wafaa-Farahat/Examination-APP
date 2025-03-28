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

namespace ExamManagmentSystem.Student_UsrCtrl
{
    public partial class UC_ViewCourses : UserControl
    {
        public UC_ViewCourses()
        {
            InitializeComponent();
        }

        private void UC_ViewCourses_Load(object sender, EventArgs e)
        {

        }
        public void ShowStudentCourses(int studentId)
        {
            try
            {
                
                using (SqlConnection connection = SQLConnection.ConnectToSQL())
                {
                    if (connection == null)
                    {
                        MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand("GetStdtCourses", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@student_id", studentId);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            studentCoursesGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Courses Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            studentCoursesGridView.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentCoursesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
