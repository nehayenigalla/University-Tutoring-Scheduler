using EFCode.Models;
using System.Data.SqlClient;

namespace EFCode
{
    public class GetSlots
    {
        public List<string> ConnectToDatabase(DateTime date,string tutorname)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                List<string> slots = new List<string>();

                // Prepare the SQL command to check the credentials
                SqlCommand command = new SqlCommand("SELECT time_slot FROM TimeSlots where dateselected=@date and Tutor_Name =@tutorname", connection);
                 command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@tutorname", tutorname);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                // int count = (int)command.ExecuteScalar();

                // Close the connection
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    var timeSlots = new List<string>();

                    while (reader.Read())
                    {
                        timeSlots.Add(reader.GetString(0));
                        /*var timeSlot = new TimeSlot
                        {
                            //Date = reader.GetDateTime(0),
                            Time = reader.GetString(0)
                        };

                        timeSlots.Add(reader.GetString(0));
                        */
                    }

                    return timeSlots;
                }


                connection.Close();

                //return dataList;

            }
            
        }
		public void ConnectToDatabase1(SlotsViewModel model)
		{
			string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Open the connection
				connection.Open();
				List<string> slots = new List<string>();

				// Prepare the SQL command to check the credentials
				SqlCommand command = new SqlCommand("delete FROM TutorRequestsStatus where requeststatus=@status and tutorusername =@tutorname and studentusername=@sun and timeslots=@slots and slotdate=@date", connection);
				command.Parameters.AddWithValue("@status", "Approved");
				command.Parameters.AddWithValue("@tutorname", model.Name);
				command.Parameters.AddWithValue("@sun", model.StudentUserName);
				command.Parameters.AddWithValue("@slots", model.Requests[1]);
				command.Parameters.AddWithValue("@date", model.Requests[0]);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                // int count = (int)command.ExecuteScalar();

                // Close the connection
                command.ExecuteReader();
				

				connection.Close();

				//return dataList;

			}

		}
	}
}

