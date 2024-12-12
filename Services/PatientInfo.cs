using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Health_Device_Data_Logger.Services
{
    public class PatientInfo
    {
        public int UserID { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return FullName;  // This will be displayed in the ComboBox
        }
    }
}
