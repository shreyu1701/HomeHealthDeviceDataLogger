using Home_Health_Device_Data_Logger.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger.Views
{
    public partial class UpdateHealthDataTechnicianForm: Form
    {
        private int _dataID;

        public UpdateHealthDataTechnicianForm(int dataID, string systolic, string diastolic, string sugarLevel, string heartRate, string oxygenLevel)
        {
            InitializeComponent();

            _dataID = dataID;

            // Populate text fields with current data
            txtSystolic.Text = systolic;
            txtDiastolic.Text = diastolic;
            txtSugarLevel.Text = sugarLevel;
            txtHeartRate.Text = heartRate;
            txtOxygenLevel.Text = oxygenLevel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Gather updated data
            string updatedSystolic = txtSystolic.Text;
            string updatedDiastolic = txtDiastolic.Text;
            string updatedSugarLevel = txtSugarLevel.Text;
            string updatedHeartRate = txtHeartRate.Text;
            string updatedOxygenLevel = txtOxygenLevel.Text;

            string updatedBloodPressure = updatedSystolic + "/" + updatedDiastolic;

            HealthDataAccess.UpdateHealthData(_dataID, updatedBloodPressure, updatedSugarLevel, updatedHeartRate, updatedOxygenLevel);

            MessageBox.Show("Health data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
