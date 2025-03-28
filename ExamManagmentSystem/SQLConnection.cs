using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagmentSystem
{
    internal class SQLConnection
    {
        public static SqlConnection ConnectToSQL()
        {
            string ConnectionString = @"Server=SOLI\SQLEXPRESS;Database=5th edition;Integrated Security=True;";

            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database connection failed: {ex.Message}");
                return null;
            }
        }

        public static bool execProcedure(string storedName, string param, string paramValue, SqlConnection connection)
        {
            if(connection != null)
            {

                try
                {
                    DataSet ds = new DataSet();
                    SqlCommand sqlCmd = new SqlCommand
                    {
                        CommandText = storedName,
                        CommandType = CommandType.StoredProcedure,
                        Connection = connection
                    };

                    sqlCmd.Parameters.AddWithValue(param, paramValue);
                    SqlDataAdapter da = new SqlDataAdapter
                    {
                        SelectCommand = sqlCmd
                    };
                    da.Fill(ds);
                    return true;
                }
                catch (Exception ex) {
                    Console.WriteLine($"Stored Procedure Execution Failed: {ex.Message}");
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("Database connection Failed ❌");
                return false;
            }
            
        }
    }
}
