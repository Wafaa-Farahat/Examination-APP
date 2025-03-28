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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    public partial class UC_ViewRegisteredStudents : UserControl
    {
        int instId;
        function fn = new function();
        String query;
        public UC_ViewRegisteredStudents(int inds)
        {
            instId = inds;
            InitializeComponent();
        }
        public UC_ViewRegisteredStudents()
        {
            InitializeComponent();
        }

        private void UC_ViewRegisteredStudents_Load(object sender, EventArgs e)
        {
            Combo1.Items.Clear();
            query = $"GetInstructorCourses '{instId}'";
            query = "selectSpecificCourses";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Combo1.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
        

        private void selectExamLabel_Click(object sender, EventArgs e)
        {

        }

        private void crsExamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo1.SelectedIndex != 0)
            {
                query = $"GetStudentsInCourse '{Combo1.Text}'";
                DataSet ds = fn.GetData(query);
                Registeredstudents.DataSource = ds.Tables[0];
            }
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generateExamLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        internal void LoadInstructorCourses(int instId)
        {
            this.instId = instId; 
        }

        private void Registeredstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
