using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManagmentSystem
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = SOLI\\SQLEXPRESS;database = 5th edition;integrated security = True";

            return con;
        }

        public DataSet GetData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void SetData(string query, string msg, Dictionary<string, object> parameters = null)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters if provided
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Show success message
              //  MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr=cmd.ExecuteReader();
            return sdr;
        }
    }
}
