using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Models
{
    public class HealthData
    {
        public int DataID { get; set; }
        public int UserID { get; set; }
        public DateTime DataDate { get; set; }
        public string BloodPressure { get; set; }
        public string SugarLevel { get; set; }
        public int HeartRate { get; set; }
        public int OxygenLevel { get; set; }
        public string Comments { get; set; }
    }

}
