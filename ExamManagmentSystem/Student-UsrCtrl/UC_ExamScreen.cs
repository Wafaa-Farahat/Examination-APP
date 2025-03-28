using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace ExamManagmentSystem.Student_UsrCtrl
{
    public partial class UC_ExamScreen : UserControl
    {
        private int modelId;
        private string courseName;
        private int studentId;

        private List<Label> mcqQuestionLabels = new List<Label>();
        private List<GroupBox> mcqAnswerGroups = new List<GroupBox>();

        private List<Label> tfQuestionLabels = new List<Label>();
        private List<GroupBox> tfAnswerGroups = new List<GroupBox>();

        private Dictionary<int, string> studentAnswers = new Dictionary<int, string>();
        private Dictionary<int, int> qes_order = new Dictionary<int, int>();
        private int Qind;
        function fn = new function();
        String query;

        public UC_ExamScreen()
        {
            InitializeComponent();
        }
        private void UC_ExamScreen_Load(object sender, EventArgs e)
        {
            // TODO: Load exam questions using modelId
            //LoadQuestions();

        }

        public UC_ExamScreen(int selectedModelId, string selectedCourseName, int loggedInStudentId) : this()
        {
            this.modelId = selectedModelId;
            this.courseName = selectedCourseName;
            this.studentId = loggedInStudentId;
            this.Qind = 1;
            examCrsName.Text = selectedCourseName;
            InitializeUILists();
            LoadQuestions();
        }

        private void InitializeUILists()
        {
            mcqQuestionLabels.AddRange(new Label[] { lblMCQ1, lblMCQ2, lblMCQ3, lblMCQ4, lblMCQ5,
                                                     lblMCQ6, lblMCQ7, lblMCQ8, lblMCQ9, lblMCQ10,
                                                     lblMCQ11, lblMCQ12, lblMCQ13, lblMCQ14, lblMCQ15 });

            mcqAnswerGroups.AddRange(new GroupBox[] { grpMCQ1, grpMCQ2, grpMCQ3, grpMCQ4, grpMCQ5,
                                                      grpMCQ6, grpMCQ7, grpMCQ8, grpMCQ9, grpMCQ10,
                                                      grpMCQ11, grpMCQ12, grpMCQ13, grpMCQ14, grpMCQ15 });

            tfQuestionLabels.AddRange(new Label[] { lblTF1, lblTF2, lblTF3, lblTF4, lblTF5,
                                                    lblTF6, lblTF7, lblTF8, lblTF9, lblTF10 });

            tfAnswerGroups.AddRange(new GroupBox[] { grpTF1, grpTF2, grpTF3, grpTF4, grpTF5,
                                                     grpTF6, grpTF7, grpTF8, grpTF9, grpTF10 });
        }
        private void saveAnswers()
        {
            Qind = 1;
            for (int mcqIndex = 0; mcqIndex < 15; mcqIndex++)
            {
                GroupBox groupBox = mcqAnswerGroups[mcqIndex];
                RadioButton[] options = groupBox.Controls.OfType<RadioButton>().ToArray();

                foreach (RadioButton option in options)
                {
                    option.CheckedChanged += (sender, e) =>
                    {
                        query = "EXEC insertStd_Answers @StudentId, @ModelId, @Answer";

                        if (option.Checked)
                        {

                            var parameters = new Dictionary<string, object>
                             {
                            { "@StudentId", this.studentId },
                            { "@ModelId", this.modelId },
                            { "@Answer", option.Text }
                            };
                            
                            fn.SetData(query, "Insert student answers", parameters);

                        }
                        else
                        {
                            var parameters = new Dictionary<string, object>
                             {
                            { "@StudentId", this.studentId },
                            { "@ModelId", this.modelId },
                            { "@Answer","not seleted" }
                            };

                            fn.SetData(query, "Insert student answers", parameters);
                        }
                       
                    };
                }
            }
            for (int TFIndex = 0; TFIndex < 10; TFIndex++)
            {
                GroupBox groupBox = tfAnswerGroups[TFIndex];
                RadioButton[] options = groupBox.Controls.OfType<RadioButton>().ToArray();

                foreach (RadioButton option in options)
                {

                    option.CheckedChanged += (sender, e) =>
                    {
                        query = "EXEC insertStd_Answers @StudentId, @ModelId, @Answer";

                        if (option.Checked)
                        {
                            var parameters = new Dictionary<string, object>
                                 {
                                 { "@StudentId", this.studentId },
                                 { "@ModelId", this.modelId },
                                 { "@Answer", option.Text }
                                  };

                            // Execute the query
                            fn.SetData(query, "Insert student answers", parameters);
                        }
                        else
                        {
                            var parameters = new Dictionary<string, object>
                                 {
                                 { "@StudentId", this.studentId },
                                 { "@ModelId", this.modelId },
                                 { "@Answer", "not selected" }
                                  };

                            // Execute the query
                            fn.SetData(query, "Insert student answers", parameters);
                        }
                    };
                   

                }
            }
            

        }
        private void LoadQuestions()
        {
            string connectionString = @"Server=SOLI\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRandomModelAndExam", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@coursename", courseName);

                    SqlParameter outputParam = new SqlParameter("@student_selected_model", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameter value
                    int modelId = (int)cmd.Parameters["@student_selected_model"].Value;
                    this.modelId= modelId;
                    SqlDataReader reader = cmd.ExecuteReader();
                    int mcqIndex = 0, tfIndex = 0;

                    while (reader.Read())
                    {
                        int questionId = reader.GetInt32(0);
                        qes_order[Qind++] = questionId;
                        string questionText = reader.GetString(1);
                        string questionType = reader.GetString(2);

                        string choiceA = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                        string choiceB = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);
                        string choiceC = reader.IsDBNull(7) ? string.Empty : reader.GetString(7);
                        string choiceD = reader.IsDBNull(8) ? string.Empty : reader.GetString(8);



                        if (questionType == "MCQ" && mcqIndex < 15)
                        {
                            mcqQuestionLabels[mcqIndex].Text = $"{mcqIndex + 1}. {questionText}";
                            GroupBox groupBox = mcqAnswerGroups[mcqIndex];
                            RadioButton[] options = groupBox.Controls.OfType<RadioButton>().ToArray();

                            options[0].Text = choiceA;
                            options[1].Text = choiceB;
                            options[2].Text = choiceC;
                            options[3].Text = choiceD;
                                          
                            mcqIndex++;
                        }
                        else if (questionType == "True/False" && tfIndex < 10)
                        {
                            tfQuestionLabels[tfIndex].Text = $"{tfIndex + 1}. {questionText}";
                            GroupBox groupBox = tfAnswerGroups[tfIndex];
                            RadioButton[] options = groupBox.Controls.OfType<RadioButton>().ToArray();

                            options[0].Text = "True";
                            options[1].Text = "False";

                            tfIndex++;
                        }
                    }
                }
            }
        }

        private void btnSubmitAnswers_Click(object sender, EventArgs e)
        {
            try
            {
                saveAnswers();
                MessageBox.Show("Exam submitted successfully! Your score has been recorded.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*string connectionString = @"Server=SOLI\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (var entry in studentAnswers)
                {
                    int questionId = entry.Key;
                    string studentAnswer = entry.Value;

                    using (SqlCommand cmd = new SqlCommand("insertStd_Answers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@stid", studentId);
                        cmd.Parameters.AddWithValue("@mid", modelId);
                        cmd.Parameters.AddWithValue("@stAns", studentAnswer);

                      //  cmd.ExecuteNonQuery();
                    }
                }

                // Call insertStd_Scores to calculate the final score
                using (SqlCommand scoreCmd = new SqlCommand("insertStd_Scores", con))
                {
                    scoreCmd.CommandType = CommandType.StoredProcedure;
                    scoreCmd.Parameters.AddWithValue("@stid", studentId);
                    scoreCmd.Parameters.AddWithValue("@mid", modelId);

                  //  scoreCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Exam submitted successfully! Your score has been recorded.");*/
        }

        private void panelQuestions_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTF1_Click(object sender, EventArgs e)
        {

        }

        private void lblTF4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTF5_Click(object sender, EventArgs e)
        {

        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ExamManagmentSystem.Student_UsrCtrl
//{
//    public partial class UC_ExamScreen : UserControl
//    {
//        private int modelId;
//        private string courseName; // Store the course name

//        // Default constructor (for drag-and-drop in UI)
//        public UC_ExamScreen()
//        {
//            InitializeComponent();
//        }

//        // Overloaded constructor to receive model ID and course name
//        public UC_ExamScreen(int selectedModelId, string selectedCourseName) : this()
//        {
//            this.modelId = selectedModelId;
//            this.courseName = selectedCourseName;

//            // Display the course name in the label
//            examCrsName.Text = selectedCourseName;
//        }

//        private void UC_ExamScreen_Load(object sender, EventArgs e)
//        {
//            // TODO: Load exam questions using modelId
//        }

//        private void panelQuestions_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void label6_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnSubmitAnswers_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
