﻿using System.Data.SqlClient;

namespace EFCode
{
    public class TutorFeedback
    {
        public void ConnectToDatabase(int rating)
        {
            string connectionString = "Data Source=DESKTOP-AGRLESG\\SQLEXPRESS;Initial Catalog=UniversityTutoringWebsiteDatabase;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();
                //foreach (string timeSlot in timeSlots)
                //{
                var command = new SqlCommand("INSERT INTO UserRegistration (rating) VALUES (@rating)", connection);
                command.Parameters.AddWithValue("@rating", rating);
                // command.Parameters.AddWithValue("@date", date);
                //command.Parameters.AddWithValue("@name", name);
                //command.ExecuteNonQuery();
                //}

                connection.Close();

                // return dataList;

            }
        }
    }
}
