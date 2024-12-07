using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Data
{
    internal class HealthDataAccess
    {

        public static List<HealthData> GetHealthDataByUserId(int userId)
        {
            var healthDataList = new List<HealthData>();
            string query = "SELECT * FROM HealthData WHERE UserID = @UserID";

            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var healthData = new HealthData
                                {
                                    DataID = reader.GetInt32(reader.GetOrdinal("DataID")),
                                    UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                    DataDate = reader.GetDateTime(reader.GetOrdinal("DataDate")),
                                    BloodPressure = reader.IsDBNull(reader.GetOrdinal("BloodPressure")) ? null : reader.GetString(reader.GetOrdinal("BloodPressure")),
                                    SugarLevel = reader.IsDBNull(reader.GetOrdinal("SugarLevel")) ? null : reader.GetString(reader.GetOrdinal("SugarLevel")),
                                    HeartRate = reader.IsDBNull(reader.GetOrdinal("HeartRate")) ? 0 : reader.GetInt32(reader.GetOrdinal("HeartRate")),
                                    OxygenLevel = reader.IsDBNull(reader.GetOrdinal("OxygenLevel")) ? 0 : reader.GetInt32(reader.GetOrdinal("OxygenLevel")),
                                    Comments = reader.IsDBNull(reader.GetOrdinal("Comments")) ? null : reader.GetString(reader.GetOrdinal("Comments"))
                                };
                                healthDataList.Add(healthData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                MessageBox.Show($"Error retrieving health data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return healthDataList;
        }

        public static List<HealthData> GetRecentHealthDataByUserId(int userId)
        {
            List<HealthData> healthDataList = new List<HealthData>();
            string query = "SELECT TOP 5  DataID, UserID, DataDate, BloodPressure, SugarLevel, HeartRate, OxygenLevel, Comments, CreatedAt FROM HealthData WHERE UserID = @UserID ORDER BY CreatedAt DESC" ;

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
                                UserID = (int)reader["UserID"],
                                DataDate = (DateTime)reader["DataDate"],
                                BloodPressure = reader["BloodPressure"] as string,
                                SugarLevel = reader["SugarLevel"] as string,
                                HeartRate = reader["HeartRate"] == DBNull.Value ? 0 : (int)reader["HeartRate"],
                                OxygenLevel = reader["OxygenLevel"] == DBNull.Value ? 0 : (int)reader["OxygenLevel"],
                                Comments = reader["Comments"] as string,
                                CreatedAt = (DateTime)reader["CreatedAt"]
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


        // Fetch all health data for all patients
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
                    Console.WriteLine($"Executing query: {query}");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var healthData = new HealthData
                            {
                                DataID = (int)reader["DataID"],
                                UserID = (int)reader["UserID"],
                                DataDate = (DateTime)reader["DataDate"],
                                BloodPressure = reader["BloodPressure"] as string,
                                SugarLevel = reader["SugarLevel"] as string,
                                HeartRate = reader["HeartRate"] == DBNull.Value ? 0 : (int)reader["HeartRate"],
                                OxygenLevel = reader["OxygenLevel"] == DBNull.Value ? 0 : (int)reader["OxygenLevel"],
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


        // Delete health data by DataID
        public static bool DeleteHealthData(int dataID)
        {
            string query = "DELETE FROM HealthData WHERE DataID = @DataID";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DataID", dataID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
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

        public static bool UpdateHealthData(int healthDataId, string bloodPressure, int sugarLevel, int heartRate, int oxygenLevel)
        {
            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    string query = @"UPDATE HealthData
                             SET BloodPressure = @BloodPressure, 
                                 SugarLevel = @SugarLevel, 
                                 HeartRate = @HeartRate, 
                                 OxygenLevel = @OxygenLevel
                             WHERE DataId = @DataId";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BloodPressure", bloodPressure);
                    command.Parameters.AddWithValue("@SugarLevel", sugarLevel);
                    command.Parameters.AddWithValue("@HeartRate", heartRate);
                    command.Parameters.AddWithValue("@OxygenLevel", oxygenLevel);
                    command.Parameters.AddWithValue("@DataId", healthDataId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., log error)
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // Method to delete a health data record by its ID
        public static bool DeleteHealthDataById(int healthDataId)
        {
            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();

                    // SQL query to delete the health data record
                    string query = "DELETE FROM HealthData WHERE DataID = @DataID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the healthDataId parameter to the query
                        command.Parameters.AddWithValue("@DataID", healthDataId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Return true if at least one row was affected, false otherwise
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                Console.WriteLine($"An error occurred while deleting health data: {ex.Message}");
                return false;
            }
        }

        public static DataTable GetHealthHistoryByUserId(int userId, DateTime? startDate = null, DateTime? endDate = null)
        {
            string query = @"SELECT 
                        DataDate AS Date,
                        BloodPressure AS BloodPressure,
                        SugarLevel AS SugarLevel,
                        HeartRate AS HeartRate,
                        OxygenLevel AS OxygenLevel,
                        Comments AS Comments
                     FROM HealthData
                     WHERE UserId = @UserID";

            if (startDate.HasValue && endDate.HasValue)
            {
                query += " AND DataDate BETWEEN @StartDate AND @EndDate";
            }

            query += " ORDER BY DataDate DESC";

            using (var conn = DbConnection.GetConnection())
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);

                    if (startDate.HasValue && endDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value);
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value);
                    }

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public static HealthData GetHealthDataByID(int dataID)
        {
            HealthData healthData = null;

            string query = "SELECT DataID, UserID, DataDate, BloodPressure, SugarLevel, HeartRate, OxygenLevel, Comments, CreatedAt " +
                           "FROM HealthData WHERE DataID = @DataID";

            using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DataID", dataID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            healthData = new HealthData
                            {
                                DataID = (int)reader["DataID"],
                                UserID = (int)reader["UserID"],
                                DataDate = (DateTime)reader["DataDate"],
                                BloodPressure = reader["BloodPressure"] as string,
                                SugarLevel = reader["SugarLevel"] as string,
                                HeartRate = reader["HeartRate"] == DBNull.Value ? 0 : (int)reader["HeartRate"],
                                OxygenLevel = reader["OxygenLevel"] == DBNull.Value ? 0 : (int)reader["OxygenLevel"],
                                Comments = reader["Comments"] as string,
                                //CreatedAt = reader["CreatedAt"] as string
                            };
                        }
                    }
                }
            }

            return healthData;
        }

        public static void UpdateHealthData(int dataID, string bloodPressure, string sugarLevel, string heartRate, string oxygenLevel)
        {
            using (SqlConnection connection = DbConnection.GetConnection())
            {
                string query = @"
            UPDATE HealthData
            SET BloodPressure = @BloodPressure,
                SugarLevel = @SugarLevel,
                HeartRate = @HeartRate,
                OxygenLevel = @OxygenLevel
            WHERE DataID = @DataID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BloodPressure", bloodPressure);
                    cmd.Parameters.AddWithValue("@SugarLevel", sugarLevel);
                    cmd.Parameters.AddWithValue("@HeartRate", heartRate);
                    cmd.Parameters.AddWithValue("@OxygenLevel", oxygenLevel);
                    cmd.Parameters.AddWithValue("@DataID", dataID);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
