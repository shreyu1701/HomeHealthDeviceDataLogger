using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Services
{
    public class UserService
    {
        public bool Register(User user)
        {
            System.Diagnostics.Debug.WriteLine("User service");
            return UserDataAccess.AddUser(user);
        }
    }
}
