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
    public partial class UC_ViewResults : UserControl
    {
        function fn = new function();
        String query;
        public UC_ViewResults()
        {
            InitializeComponent();
        }
        public void LoadStudentCourses(int stid)
        {
            query = $"GetStudentCoursesAndScores {stid}";
            DataSet ds = fn.GetData(query);
            studentCoursesGridView1.DataSource = ds.Tables[0];
        }
        private void UC_ViewResults_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentCoursesGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
