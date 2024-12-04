using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Data
{
    internal class HealthDataAccess
    {


        public static List<HealthData> GetHealthDataByUserId(int userId)
        {
            List<HealthData> healthDataList = new List<HealthData>();
            string query = "SELECT * FROM HealthData WHERE UserID = @UserID";

            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var healthData = new HealthData
                            {
                                DataID = (int)reader["DataID"],
                                UserID = (int)reader["UserID"],  // Updated to cast as int
                                DataDate = (DateTime)reader["DataDate"],
                                BloodPressure = reader["BloodPressure"] as string,
                                SugarLevel = reader["SugarLevel"] as string,
                                HeartRate = (int)reader["HeartRate"],
                                OxygenLevel = (int)reader["OxygenLevel"],
                                Comments = reader["Comments"] as string
                            };
                            healthDataList.Add(healthData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return healthDataList;
        }


        public static List<HealthData> GetAllHealthData()
        {
            List<HealthData> healthDataList = new List<HealthData>();
            string query = "SELECT * FROM HealthData";

            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var healthData = new HealthData
                            {
                                DataID = (int)reader["DataID"],
                                UserID = (int)reader["UserID"],  // Casting UserID to int
                                DataDate = (DateTime)reader["DataDate"],
                                BloodPressure = reader["BloodPressure"] as string,
                                SugarLevel = reader["SugarLevel"] as string,
                                HeartRate = (int)reader["HeartRate"],
                                OxygenLevel = (int)reader["OxygenLevel"],
                                Comments = reader["Comments"] as string
                            };
                            healthDataList.Add(healthData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return healthDataList;
        }


        public static void SaveHealthData(HealthData healthData)
        {
            using (var connection = DbConnection.GetConnection())
            {
                string query = @"
            INSERT INTO HealthData 
                (UserID, DataDate, BloodPressure, SugarLevel, HeartRate, OxygenLevel, Comments, CreatedAt) 
            VALUES 
                (@UserID, @DataDate, @BloodPressure, @SugarLevel, @HeartRate, @OxygenLevel, @Comments, @CreatedAt)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@UserID", healthData.UserID);
                    command.Parameters.AddWithValue("@DataDate", healthData.DataDate);
                    command.Parameters.AddWithValue("@BloodPressure", (object)healthData.BloodPressure ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SugarLevel", (object)healthData.SugarLevel ?? DBNull.Value);
                    command.Parameters.AddWithValue("@HeartRate", healthData.HeartRate == 0 ? DBNull.Value : (object)healthData.HeartRate);
                    command.Parameters.AddWithValue("@OxygenLevel", healthData.OxygenLevel == 0 ? DBNull.Value : (object)healthData.OxygenLevel);
                    command.Parameters.AddWithValue("@Comments", string.IsNullOrEmpty(healthData.Comments) ? DBNull.Value : (object)healthData.Comments);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    // Execute the query
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
