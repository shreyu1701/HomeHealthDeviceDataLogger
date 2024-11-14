using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.HandleUser
{
    public class Founder
    {
        private List<User> users = new List<User>();

        public Founder()
        {
            LoadUsersFromFile(); // Load existing users at startup
        }

        public void AddUser(User newUser)
        {
            users.Add(newUser);
            SaveUsersToFile();
        }

        private void SaveUsersToFile()
        {
            string jsonFilePath = "users.json";
            string jsonData = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, jsonData);
        }

        public void LoadUsersFromFile()
        {
            string jsonFilePath = "users.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                users = JsonSerializer.Deserialize<List<User>>(jsonData) ?? new List<User>();
            }
        }

        public bool IsEmailRegistered(string email)
        {
            return users.Exists(user => user.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
    }
