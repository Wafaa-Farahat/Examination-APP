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
    public partial class UC_GenerateExam : UserControl
    {
        public UC_GenerateExam()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();//until applying generate
        }

        private void crsExamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_GenerateExam_Load(object sender, EventArgs e)
        {
            crsExamList.SelectedIndex = 1;
        }
    }
}
