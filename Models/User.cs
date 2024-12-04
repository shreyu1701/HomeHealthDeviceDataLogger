using System;

namespace Home_Health_Device_Data_Logger.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Age { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PasswordHint { get; set; }
        public string Role { get; set; }
        public byte[]? ProfileImage { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}