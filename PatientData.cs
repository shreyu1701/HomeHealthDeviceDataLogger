using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeHealthDeviceDataLogger
{
    public class PatientData
    {
        // Properties for health data
        public DateTime Date { get; set; }
        public String? BloodPressure { get; set; }
        public int? SugarLevel { get; set; }
        public int? HeartRate { get; set; }
        public int? OxygenLevel { get; set; }



        public PatientData()
        {
            Date = DateTime.Today;
            BloodPressure = "";
            SugarLevel = 0;
            HeartRate = 0;
            OxygenLevel = 0;

        }

        // Method to save data
        public void SaveData()
        {
            // Implement the saving logic, e.g., writing to a database or file
        }

    }
}

