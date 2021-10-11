using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRG282Project.DataLayer
{
    class DataHandler
    {
        string connectionString = @"Server=(local); Initial Catalog=; Integrated Security=SSPI;";
        public DataHandler() { }
        public string TestConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                return "Connection open";
                
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }

        }

        public DataTable GetStudent()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudent", connectionString);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //@StudentNumber, @StudentName, @StudentSurname, @DateofBirth, @Gender, @StudentPhoneNumber, @StudentAddress
        public void InsertStudent(int studentNum, string name, string surname, string dateOfBirth, string phone, string address,)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddstudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNumber", studentNum);
            }
        }
    }
}
