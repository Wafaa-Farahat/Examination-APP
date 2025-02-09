using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            txtSelectUser.SelectedIndex = 0;
            instPanel.Visible=true;
            stdPanel.Visible=false;
            wrongLabel.Visible=false;
            wrongLabelStd.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void imgComp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (txtSelectUser.SelectedIndex == 0) {
                instPanel.Visible = true;
                stdPanel.Visible = false;
            }else if(txtSelectUser.SelectedIndex == 1) 
            { 
                instPanel.Visible = false;
                stdPanel.Visible = true;
            }  
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void chkShowHideStd_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowHideStd.Checked == true)
            {
                stdPassword.PasswordChar = '\0';
                checkBoxShowHideIns.Text = "Hide Password";
            }
            else
            {
                stdPassword.PasswordChar = '*';
                checkBoxShowHideIns.Text="Show Password";
            }
        }

        private void checkBoxShowHideIns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHideIns.Checked == true)
            {
                insPassword.PasswordChar = '\0';
                checkBoxShowHideIns.Text = "Hide Password";
            }
            else
            {
                insPassword.PasswordChar = '*';
                checkBoxShowHideIns.Text = "Show Password";
            }
            {
                
            }
        }
        private void btnStudentRegisteration_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            if (txtEnrolmentNum.Text == "1500" && stdPassword.Text == "441")
            {
                wrongLabelStd.Visible = false;
                //StudDashboard std = new StudDashboard();  
                //std.Show();
                this.Hide();
            }
            else
            {
                wrongLabelStd.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="ramy" && insPassword.Text=="123")
            {
                wrongLabel.Visible = false;
                //InstDashbord inst = new InstDashbord();
                Instructor inst = new Instructor();
                inst.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible=true;
            }
        }

    }
}
