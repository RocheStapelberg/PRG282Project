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
        string connectionString = @"Server=(local); Initial Catalog=BelgiumStudents; Integrated Security=SSPI;";
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

        public DataTable getStudents()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("spGetStudents", connectionString);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //@StudentNumber, @StudentName, @StudentSurname, @DateofBirth, @Gender, @StudentPhoneNumber, @StudentAddress
        public void insertStudent(int studentNum, string name, string surname, string gender, string dateOfBirth, string phone, string address)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddstudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNumber", studentNum);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@StudentSurname", surname);
                cmd.Parameters.AddWithValue("@DateofBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@StudentPhoneNumber", phone);
                cmd.Parameters.AddWithValue(" @StudentAddress", address);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void insertModule(string Mcode, int sNum, string Mname, string Mdesc, string link)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"INSERT INTO Module VALUES ('{Mcode}',{sNum},'{Mname}','{Mdesc}','{link}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void updateStudent(int studentNum, string name, string surname, string gender, string dateOfBirth, string phone, string address)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNumber", studentNum);
                cmd.Parameters.AddWithValue("@StudentName", name);
                cmd.Parameters.AddWithValue("@StudentSurname", surname);
                cmd.Parameters.AddWithValue("@DateofBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@StudentPhoneNumber", phone);
                cmd.Parameters.AddWithValue("@StudentAddress", address);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteData(int studentNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable searchStudent(int studentNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spSearchStudent", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);

                connection.Open();
                DataTable dt = new DataTable();

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }
    }
}
