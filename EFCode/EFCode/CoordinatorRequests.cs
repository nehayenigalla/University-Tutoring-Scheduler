using EFCode.Models;
using System.Data.SqlClient;

namespace EFCode
{
    public class CoordinatorRequests
    {
        public void ConnectToDatabase(SlotsViewModel model)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("INSERT INTO CoordinatorRequests VALUES (@uname,@utype,@msg,@status)", connection);
                command.Parameters.AddWithValue("@uname", model.StudentUserName);
                command.Parameters.AddWithValue("@utype", model.UserType);
                command.Parameters.AddWithValue("@msg", model.UserMessage);
                command.Parameters.AddWithValue("@status", "MarkUnread");

                command.ExecuteNonQuery();



                //command.Parameters.AddWithValue("@username", username);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                //int count = (int)command.ExecuteScalar();

                // Close the connection
                connection.Close();

                // Check if the credentials are valid
                //if (count == 1)
                //{
                // Redirect to the home page or a success page
                //return RedirectToAction("Index", "Home");
                //return count;
                //}
                //else
                //{
                // Add an error message to the model state
                //ModelState.AddModelError("", "Invalid username or password.");
                //  return 0;
                //}
            }
        }
        public List<string> ConnectToDatabase()
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("select UserName, UserMessage from CoordinatorRequests where UserType=@std and MessageStatus=@status", connection);
                command.Parameters.AddWithValue("@std", "Student");
                command.Parameters.AddWithValue("@status", "MarkUnread");
                //command.Parameters.AddWithValue("@utype", model.UserType);
                //command.Parameters.AddWithValue("@msg", model.UserMessage);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> Messages = new List<string>();

                    while (reader.Read())
                    {
                        Messages.Add("Request from: " + reader.GetString(0) + " .....Message: " + reader.GetString(1));
                        /*var timeSlot = new TimeSlot
                        {
                            //Date = reader.GetDateTime(0),
                            Time = reader.GetString(0)
                        };

                        timeSlots.Add(reader.GetString(0));
                        */
                    }

                    return Messages;
                }
            }
        }
                public void ConnectToDatabase3(SlotsViewModel model)
                {
                    string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // Prepare the SQL command to check the credentials
                        //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                        //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                        for (int i = 0; i < model.MessageStatus.Count; i++)
                        {
                            SqlCommand command = new SqlCommand("update CoordinatorRequests set MessageStatus = @status where UserMessage=@msg", connection);
                            //command.Parameters.AddWithValue("@std", "Student");
                            command.Parameters.AddWithValue("@status", model.MessageStatus[i]);
                            command.Parameters.AddWithValue("@msg", model.Requests[i]);
                            command.ExecuteNonQuery();
                        }


                        connection.Close();

                        
                    }
                } 
        public List<string> ConnectToDatabase1()
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("select UserName, UserMessage from CoordinatorRequests where UserType=@std and MessageStatus=@status", connection);
                command.Parameters.AddWithValue("@std", "Tutor");
                command.Parameters.AddWithValue("@status", "MarkUnread");

                //command.Parameters.AddWithValue("@utype", model.UserType);
                //command.Parameters.AddWithValue("@msg", model.UserMessage);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<string> Messages = new List<string>();

                    while (reader.Read())
                    {
                        Messages.Add("Request from: " + reader.GetString(0) + " .....Message: " + reader.GetString(1));
                        /*var timeSlot = new TimeSlot
                        {
                            //Date = reader.GetDateTime(0),
                            Time = reader.GetString(0)
                        };

                        timeSlots.Add(reader.GetString(0));
                        */
                    }

                    return Messages;
                }



                //command.Parameters.AddWithValue("@username", username);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                //int count = (int)command.ExecuteScalar();

                // Close the connection
                connection.Close();

                // Check if the credentials are valid
                //if (count == 1)
                //{
                // Redirect to the home page or a success page
                //return RedirectToAction("Index", "Home");
                //return count;
                //}
                //else
                //{
                // Add an error message to the model state
                //ModelState.AddModelError("", "Invalid username or password.");
                //  return 0;
                //}
            }
        }
    }
}
