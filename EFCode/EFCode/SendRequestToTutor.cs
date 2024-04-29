using System.Data.SqlClient;

namespace EFCode
{
    public class SendRequestToTutor
    {
        public void ConnectToDatabase(DateTime date, string timeSlot, string name, string studentname)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                var command = new SqlCommand("INSERT INTO StudentRequest (SlotDate, timeslot, professorname,studentusername) VALUES (@date, @timeSlot, @name,@studentname)", connection);
                command.Parameters.AddWithValue("@timeSlot", timeSlot);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@studentname", studentname);
                command.ExecuteNonQuery();
                var command1 = new SqlCommand("INSERT INTO StudentRequestwithstatus (SlotDate, timeslot, professorname,studentusername,appointmentstatus) VALUES (@date, @timeSlot, @name,@studentname,@status)", connection);
                command1.Parameters.AddWithValue("@timeSlot", timeSlot);
                command1.Parameters.AddWithValue("@date", date);
                command1.Parameters.AddWithValue("@name", name);
                command1.Parameters.AddWithValue("@studentname", studentname);
                command1.Parameters.AddWithValue("@status", "Pending");
                command1.ExecuteNonQuery();

                connection.Close();

                // return dataList;

            }
        }
    
    }
}
