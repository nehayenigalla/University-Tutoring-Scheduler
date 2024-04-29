using EFCode.Models;
using System.Data.SqlClient;

namespace EFCode
{
	public class StudentProfile
	{
		public List<string> ConnectToDatabase(string MyVariable)
		{
			string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Open the connection
				connection.Open();
				List<string> slots = new List<string>();

				// Prepare the SQL command to check the credentials
				SqlCommand command = new SqlCommand("SELECT Username,Phone,Major,Level FROM StudentProfile where UserName=@name", connection);
				//command.Parameters.AddWithValue("@date", date);
				command.Parameters.AddWithValue("@name", MyVariable);
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
						timeSlots.Add(reader.GetInt64(1).ToString());
						timeSlots.Add(reader.GetString(2));
						timeSlots.Add(reader.GetString(3));
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
			}
		}
		public void ConnectToDatabase1(string MyVariable, SlotsViewModel model)
		{
			string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Open the connection
				connection.Open();
				List<string> slots = new List<string>();

				// Prepare the SQL command to check the credentials
				SqlCommand command = new SqlCommand("UPDATE StudentProfile set Name=@n, Phone=@p, Major=@m, Level=@l where UserName=@un", connection);
				//command.Parameters.AddWithValue("@date", date);
				command.Parameters.AddWithValue("@un", MyVariable);
				command.Parameters.AddWithValue("@n", model.StudentInfo[0]);
				command.Parameters.AddWithValue("@p", model.StudentInfo[1]);
				command.Parameters.AddWithValue("@m", model.StudentInfo[2]);
				command.Parameters.AddWithValue("@l", model.StudentInfo[3]);
				//command.Parameters.AddWithValue("@password", password);

				// Execute the command and get the result
				// int count = (int)command.ExecuteScalar();

				// Close the connection
				command.ExecuteReader();


				//return timeSlots;
			}
		}
	}
}
