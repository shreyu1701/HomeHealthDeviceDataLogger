using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Models
{
    public class Patient
    {
            public int UserID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string BloodGroup { get; set; }
       
        public Patient(User user) { }

        public Patient(int userId, string firstName, string lastName, string email, int age, string gender, string bloodGroup)
        {
            UserID = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Gender = gender;
            BloodGroup = bloodGroup;
        }
    }
        
}
