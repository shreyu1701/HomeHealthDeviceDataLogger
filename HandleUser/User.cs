using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using Home_Health_Device_Data_Logger.Encryption_and_Decryption;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;

namespace Home_Health_Device_Data_Logger.HandleUser
{
    public class User
    {
        // Properties for user data
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PasswordHint { get; set; }
        public string Role { get; set; }
        public string ProfileImage { get; set; }

        // Constructor for creating a new user
        public User(string firstName, string lastName, string age, string gender, string bloodGroup, string email, string password, string confirmPassword, string passwordHint, string role, string profileImage)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            BloodGroup = bloodGroup;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            PasswordHint = passwordHint;
            Role = role;
            ProfileImage = profileImage;
        }

        // Default constructor for deserialization
        public User() { }

        // File path for JSON storage
        private static readonly string filePath = "users.json";

        // Static method to save all users to JSON file
        public static void SaveUsersToFile(List<User> users)
        {
            string jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        // Static method to load all users from JSON file
        public static List<User> LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(jsonData) ?? new List<User>();
            }
            return new List<User>();
        }

        // Method to add a new user to the list and save to JSON
        public static void AddUser(User newUser)
        {
            var users = LoadUsersFromFile();
            users.Add(newUser);
            SaveUsersToFile(users);
        }

        // Login method to find user by email and password
        public static User? Login(string email, string password)
        {
            var users = LoadUsersFromFile(); // Load existing users

            foreach (var user in users)
            {
                if (user.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && user.Password == password)
                {
                    return user; // Return the matching user
                }
            }
            return null; // Return null if no match is found
        }

        public static bool IsEmailRegistered(string email)
        {
            List<User> users = LoadUsersFromFile();
            foreach (var user in users)
            {
                if (user.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

    }
}