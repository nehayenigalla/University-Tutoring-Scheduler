using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data.SqlClient;
using System.Configuration;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Web.Mvc;
using EFCode.Models;

namespace EFCode
{
    public class RegistrationValidation
    {
        public void ConnectToDatabase(RegisterViewModel model)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("INSERT INTO UserRegistration (FirstName,LastName,Username,Phone,Pwd,DOB,EmailId,UserType,Course,Level) VALUES (@Fn,@Ln,@Username,@pn,@Pwd,@dob,@email,@usertype,@dep,@lev)", connection);
                command.Parameters.AddWithValue("@Username", model.Username);
                command.Parameters.AddWithValue("@pn", model.Phone);
                command.Parameters.AddWithValue("@dep", model.Course);
                command.Parameters.AddWithValue("@lev", model.Level);
                command.Parameters.AddWithValue("@Pwd", model.Password);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Fn", model.FirstName);
                command.Parameters.AddWithValue("@Ln", model.LastName);
                command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                command.Parameters.AddWithValue("@usertype", model.UserType);
               // command.Parameters.AddWithValue("@Pwd", model.Password);

                //connection.Open();
                command.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand("INSERT INTO StudentProfile (Username,Phone,Major,Level) VALUES (@Username,@pn,@dep,@lev)", connection);
                command1.Parameters.AddWithValue("@Username", model.Username);
                command1.Parameters.AddWithValue("@pn", model.Phone);
                command1.Parameters.AddWithValue("@dep", model.Course);
                command1.Parameters.AddWithValue("@lev", model.Level);
               

                //connection.Open();
                command1.ExecuteNonQuery();

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
        public List<decimal> ConnectToDatabase1()
        {
            List<decimal> dataList = new List<decimal>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("select rating from UserRegistration", connection);
                //  command.Parameters.AddWithValue("@Username", model.Username);
                /* command.Parameters.AddWithValue("@Pwd", model.Password);
                 command.Parameters.AddWithValue("@Email", model.Email);
                 command.Parameters.AddWithValue("@Fn", model.FirstName);
                 command.Parameters.AddWithValue("@Ln", model.LastName);
                 command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                 command.Parameters.AddWithValue("@usertype", model.UserType);
                 // command.Parameters.AddWithValue("@Pwd", model.Password);

                 //connection.Open();
                */
              
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        decimal value1 = reader.GetDecimal(0);
                        //string value2 = reader.GetString(1);
                        //string value3 = reader.GetString(2);
                        //string value4 = reader.GetString(4);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        dataList.Add(value1);
                        //datalist1.Add(value1.ToString());
                        ////datalist1.Add(value2);
                        //datalist1.Add(value3);
                        //datalist1.Add(TutorName);
                        //ConnectToDatabase3(dataList2);

                    }
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
            return dataList;
        }
        public List<string> ConnectToDatabase4()
        {
            List<string> dataList = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("select Major from StudentProfile", connection);
                //  command.Parameters.AddWithValue("@Username", model.Username);
                /* command.Parameters.AddWithValue("@Pwd", model.Password);
                 command.Parameters.AddWithValue("@Email", model.Email);
                 command.Parameters.AddWithValue("@Fn", model.FirstName);
                 command.Parameters.AddWithValue("@Ln", model.LastName);
                 command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                 command.Parameters.AddWithValue("@usertype", model.UserType);
                 // command.Parameters.AddWithValue("@Pwd", model.Password);

                 //connection.Open();
                */

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        string value1 = reader.GetString(0);
                        //string value2 = reader.GetString(1);
                        //string value3 = reader.GetString(2);
                        //string value4 = reader.GetString(4);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        dataList.Add(value1);
                        //datalist1.Add(value1.ToString());
                        ////datalist1.Add(value2);
                        //datalist1.Add(value3);
                        //datalist1.Add(TutorName);
                        //ConnectToDatabase3(dataList2);

                    }
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
            return dataList;
        }
        public List<string> ConnectToDatabase2()
        {
            List<string> dataList = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("SELECT DISTINCT Username FROM UserRegistration where UserType=@t", connection);
                  command.Parameters.AddWithValue("@t","Student");
                /* command.Parameters.AddWithValue("@Pwd", model.Password);
                 command.Parameters.AddWithValue("@Email", model.Email);
                 command.Parameters.AddWithValue("@Fn", model.FirstName);
                 command.Parameters.AddWithValue("@Ln", model.LastName);
                 command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                 command.Parameters.AddWithValue("@usertype", model.UserType);
                 // command.Parameters.AddWithValue("@Pwd", model.Password);

                 //connection.Open();
                */

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        string value1 = reader.GetString(0);
                        //string value2 = reader.GetString(1);
                        //string value3 = reader.GetString(2);
                        //string value4 = reader.GetString(4);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        dataList.Add(value1);
                        //datalist1.Add(value1.ToString());
                        ////datalist1.Add(value2);
                        //datalist1.Add(value3);
                        //datalist1.Add(TutorName);
                        //ConnectToDatabase3(dataList2);

                    }
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
            return dataList;
        }

        public List<string> ConnectToDatabase3()
        {
            List<string> dataList = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("SELECT DISTINCT Username FROM UserRegistration where UserType=@t", connection);
                command.Parameters.AddWithValue("@t", "Tutor");
                /* command.Parameters.AddWithValue("@Pwd", model.Password);
                 command.Parameters.AddWithValue("@Email", model.Email);
                 command.Parameters.AddWithValue("@Fn", model.FirstName);
                 command.Parameters.AddWithValue("@Ln", model.LastName);
                 command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                 command.Parameters.AddWithValue("@usertype", model.UserType);
                 // command.Parameters.AddWithValue("@Pwd", model.Password);

                 //connection.Open();
                */

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // read the values from the columns and add them to the list
                        string value1 = reader.GetString(0);
                        //string value2 = reader.GetString(1);
                        //string value3 = reader.GetString(2);
                        //string value4 = reader.GetString(4);
                        //dataList.Add(value1);
                        //dataList.Add(value2);
                        //dataList.Add(value3);
                        //dataList.Add(value1);
                        //string value3=reader.GetValue
                        dataList.Add(value1);
                        //datalist1.Add(value1.ToString());
                        ////datalist1.Add(value2);
                        //datalist1.Add(value3);
                        //datalist1.Add(TutorName);
                        //ConnectToDatabase3(dataList2);

                    }
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
            return dataList;
        }

        public List<object> ConnectToDatabase5()
        {
            List<string> dataList = new List<string>();
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Prepare the SQL command to check the credentials
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                //SqlCommand command = new SqlCommand("INSERT INTO UserRegistration VALUES ()SELECT COUNT(*) FROM UserCredentials WHERE username = @username AND pwd = @password", connection);
                SqlCommand command = new SqlCommand("SELECT FirstName,Lastname, UserName, Course, Rating FROM UserRegistration where UserType=@t", connection);
                command.Parameters.AddWithValue("@t", "Tutor");
                /* command.Parameters.AddWithValue("@Pwd", model.Password);
                 command.Parameters.AddWithValue("@Email", model.Email);
                 command.Parameters.AddWithValue("@Fn", model.FirstName);
                 command.Parameters.AddWithValue("@Ln", model.LastName);
                 command.Parameters.AddWithValue("@dob", model.DateOfBirth);
                 command.Parameters.AddWithValue("@usertype", model.UserType);
                 // command.Parameters.AddWithValue("@Pwd", model.Password);

                 //connection.Open();
                */

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    var tutors = new List<object>();
                    while (reader.Read())
                    {
                        var tutor = new
                        {
                            FirstName = reader.GetString(0),
                            LastName = reader.GetString(1),
                            Username=reader.GetString(2),
                            Rating = reader.GetDecimal(4),
                            Course = reader.GetString(3),
                            //Email = reader.GetString(5)
                            //Course = reader.GetString(2)
                        };

                        tutors.Add(tutor);
                    }
                    return tutors;

                   // ViewBag.Tutors = tutors;
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
            //return dataList;
        }




    }
}
