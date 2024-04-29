using EFCode.Models;
using System.Data.SqlClient;
namespace EFCode
{
    public class CheckUpcomingAppointments
    {
        public List<string> ConnectToDatabase(string tutorname)
        {
            List<string> l = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Open the connection
                connection.Open();
                var command = new SqlCommand("select slotdate, timeslots, studentusername from TutorRequestsStatus where tutorusername=@name and requeststatus=@status", connection);
                //command.Parameters.AddWithValue("@timeSlots", timeSlot);
                //command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@name", tutorname);
                command.Parameters.AddWithValue("@status", "Approved");
                //command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime value1 = reader.GetDateTime(0);
                        string value2 = reader.GetString(1);
                        string value3 = reader.GetString(2);
                        l.Add("Upcoming Appointment on: " + value1 + " at " + value2 + " requested by: " + value3);

                    }
                }
                //}

                connection.Close();

                // return dataList;

            }
            return l;
        }
        public List<string> ConnectToDatabase1(SlotsViewModel model)
        {
            List<string> l = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Open the connection
                connection.Open();
                var command = new SqlCommand("select slotdate, timeslots from TutorRequestsStatus where tutorusername=@name and requeststatus=@status and studentusername=@sun", connection);
                //command.Parameters.AddWithValue("@timeSlots", timeSlot);
                //command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@name", model.TutorUserName[0]);
                command.Parameters.AddWithValue("@status", "Approved");
                command.Parameters.AddWithValue("@sun", model.studentUsernameList[0]);
                //command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime value2 = reader.GetDateTime(0);
                        //string value2 = reader.GetString(0);
                        string value3 = reader.GetString(1);
                        l.Add(value2.ToString());
                        l.Add(value3);

                    }
                }
                //}

                connection.Close();

                // return dataList;

            }
            return l;
        }
    }
}
