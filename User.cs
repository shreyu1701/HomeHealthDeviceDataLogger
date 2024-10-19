using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger
{
    internal class User
    {
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
        public string? ProfileImage { get; set; }



        //Constructor
        public User(string firstName, string lastName, string age, string gender,
        string bloodGroup, string email,  string password, string confirmPassword,
        string passwordHint, string role, string profileImage)
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
        //Default Constructor
        public User() { }

    }
}