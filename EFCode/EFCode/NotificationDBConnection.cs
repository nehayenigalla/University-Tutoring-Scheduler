using System.Data.SqlClient;

namespace EFCode
{
    public class NotificationDBConnection
    {
        public List<string> ConnectToDatabase(string TutorName, List<string> datalist1)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                List<string> dataList = new List<string>();
                List<string> dataList2 = new List<string>();

                // Prepare the SQL command to check the credentials
                SqlCommand command = new SqlCommand("SELECT SlotDate,timeslot,professorname,studentusername from StudentRequest where professorname=@TutorName", connection);
                command.Parameters.AddWithValue("@TutorName", TutorName);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                // int count = (int)command.ExecuteScalar();

                // Close the connection
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        DateTime value1 = reader.GetDateTime(0);
                        string value2 = reader.GetString(1);
                        string value3 = reader.GetString(3);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        dataList.Add(" Student with username: " + value3 + " has requested for a slot at " + value2 + " on Date: " + value1);
                        datalist1.Add(value1.ToString());
                        datalist1.Add(value2);
                        datalist1.Add(value3);
                        datalist1.Add(TutorName);
                        //ConnectToDatabase3(dataList2);

                    }
                }


                connection.Close();

                return dataList;

            }
        }
        public List<string> ConnectToDatabase3(List<string> studentinfo)
        {
            return studentinfo;
        }
        public List<string> ConnectToDatabase1(string TutorName)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                // List<string> dataList = new List<string>();
                List<string> dataList2 = new List<string>();

                // Prepare the SQL command to check the credentials
                SqlCommand command = new SqlCommand("SELECT SlotDate,timeslot,studentusername from StudentRequest where professorname=@TutorName", connection);
                command.Parameters.AddWithValue("@TutorName", TutorName);
                //command.Parameters.AddWithValue("@password", password);

                // Execute the command and get the result
                // int count = (int)command.ExecuteScalar();

                // Close the connection
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        //DateTime value1 = reader.GetDateTime(0);
                        //string value2 = reader.GetString(1);
                        string value3 = reader.GetString(0);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        //dataList.Add(" Student with username: " + value3 + " has requested for a slot at " + value2 + " on Date: " + value1);
                        dataList2.Add(value3);

                    }
                }


                connection.Close();

                return dataList2;

            }
        }

    }
}

