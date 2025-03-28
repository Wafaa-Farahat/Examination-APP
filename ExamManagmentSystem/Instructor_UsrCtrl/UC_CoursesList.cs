using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagmentSystem.Instructor_UsrCtrl
{
    public partial class UC_CoursesList : UserControl
    {
        int instId;
        function fn = new function();
        String query;
        public UC_CoursesList()
        {
            InitializeComponent();
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_CoursesList_Load(object sender, EventArgs e)
        {
            Combo1.Items.Clear();
            query = "select tname from track";
            DataSet ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Combo1.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo1.SelectedIndex != 0)
            {
                query = $"GetCoursesByTrack '{Combo1.Text}'";
                DataSet ds = fn.GetData(query);
                StudentView.DataSource = ds.Tables[0];
            }
        }

        private void StudentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
