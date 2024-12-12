using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using Microsoft.Data.SqlClient;

namespace Home_Health_Device_Data_Logger.Data
{
    public static class UserDataAccess
    {
        public static bool AddUser(User user)
        {
            string query = "INSERT INTO Users (FirstName, LastName, Age, BloodGroup, Gender, Email, Password, PasswordHint, Role, ProfileImage, CreatedAt) " +
                   "VALUES (@FirstName, @LastName, @Age, @BloodGroup, @Gender, @Email, @Password, @PasswordHint, @Role, @ProfileImage, @CreatedAt)";
            try
            {
                using (var connection = DbConnection.GetConnection())
                {

                    System.Diagnostics.Debug.WriteLine("DB service");
                    connection.Open();

                    var command = new SqlCommand(query, connection);
                    {
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = user.FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = user.LastName;
                        command.Parameters.Add("@Age", SqlDbType.Int).Value = user.Age;
                        command.Parameters.Add("@BloodGroup", SqlDbType.NVarChar).Value = user.BloodGroup;
                        command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = user.Gender;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                        command.Parameters.Add("@PasswordHint", SqlDbType.NVarChar).Value = user.PasswordHint;
                        command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = user.Role;
                        command.Parameters.Add("@ProfileImage", SqlDbType.VarBinary).Value = user.ProfileImage ?? (object)DBNull.Value;
                        command.Parameters.Add("@CreatedAt", SqlDbType.DateTime).Value = DateTime.Now;

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"Sql Error :");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return false;
            }


        }


        public static User Login(string email, string password)
        {
            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = (int)reader["UserID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                Age = reader["Age"].ToString(),
                                BloodGroup = reader["BloodGroup"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Email = reader["Email"].ToString(),
                                Password = reader["Password"].ToString(),
                                PasswordHint = reader["PasswordHint"].ToString(),
                                Role = reader["Role"].ToString(),
                                ProfileImage = reader["ProfileImage"] as byte[],
                                CreatedAt = (DateTime)reader["CreatedAt"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return null;
        }



        public static string GetPasswordHint(string email)
        {
            string query = "SELECT PasswordHint FROM Users WHERE Email = @Email";
            try
            {
                using (var connection = DbConnection.GetConnection())
                {
                    connection.Open();
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public static List<User> GetAllPatients()
        {
            var patients = new List<User>();

            using (var connection = DbConnection.GetConnection())
            {
                
                string query = "SELECT UserID, FirstName, LastName, Email, Age, Gender, BloodGroup FROM Users WHERE Role = 'Patient'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            patients.Add(new User
                            {
                                UserID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                            });
                        }
                    }
                }
            }

            return patients;
        }




        public static int GetUserIDByEmail(string email)
        {
            string query = "SELECT UserID FROM Users WHERE Email = @Email";
            using (var connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }


        public static bool UpdateUserProfile(User patient)
        {
            using (var connection = DbConnection.GetConnection())
            {
                try
                {
                    string query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Age = @Age, " +
                                   "Gender = @Gender, BloodGroup = @BloodGroup, Email = @Email, Password = @Password, " +
                                   "PasswordHint = @PasswordHint, ProfileImage = @ProfileImage WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    cmd.Parameters.AddWithValue("@Age", patient.Age);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
                    cmd.Parameters.AddWithValue("@Email", patient.Email);
                    cmd.Parameters.AddWithValue("@Password", patient.Password);
                    cmd.Parameters.AddWithValue("@PasswordHint", patient.PasswordHint);
                    cmd.Parameters.AddWithValue("@ProfileImage", patient.ProfileImage);
                    cmd.Parameters.AddWithValue("@UserID", patient.UserID);  // Make sure to include the UserID in the WHERE clause

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception
                    return false;
                }
            }
        }

        public static List<PatientInfo> GetPatientNames()
        {
            var patientList = new List<PatientInfo>();
            using (var connection = DbConnection.GetConnection())
            {
                var query = "SELECT UserID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Users WHERE Role = 'Patient'";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var patient = new PatientInfo
                            {
                                UserID = reader.GetInt32("UserID"),
                                FullName = reader.GetString("FullName")
                            };
                            patientList.Add(patient);
                        }
                    }
                }
            }
            return patientList;
        }



        public static bool DeletePatient(int userID)
        {
            bool isDeleted = false;

            using (var connection = DbConnection.GetConnection())
            {
                // First, delete associated health data
                string deleteHealthDataQuery = "DELETE FROM HealthData WHERE UserID = @UserID";
                SqlCommand cmdHealthData = new SqlCommand(deleteHealthDataQuery, connection);
                cmdHealthData.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();

                    // Execute the health data deletion
                    cmdHealthData.ExecuteNonQuery();

                    // Then delete the patient from Users table
                    string deletePatientQuery = "DELETE FROM Users WHERE UserID = @UserID AND Role = 'Patient'";
                    SqlCommand cmdPatient = new SqlCommand(deletePatientQuery, connection);
                    cmdPatient.Parameters.AddWithValue("@UserID", userID);

                    int rowsAffected = cmdPatient.ExecuteNonQuery();
                    isDeleted = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting patient: " + ex.Message);
                }
            }

            return isDeleted;
        }







    }

}