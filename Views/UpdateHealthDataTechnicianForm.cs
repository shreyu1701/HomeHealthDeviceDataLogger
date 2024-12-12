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
    public partial class UpdateHealthDataTechnicianForm : Form
    {
        private int _dataID;

        public UpdateHealthDataTechnicianForm(int dataID, string systolic, string diastolic, string sugarLevel, string heartRate, string oxygenLevel)
        {
            InitializeComponent();

            _dataID = dataID;

            txtSystolic.Text = systolic;
            txtDiastolic.Text = diastolic;
            txtSugarLevel.Text = sugarLevel;
            txtHeartRate.Text = heartRate;
            txtOxygenLevel.Text = oxygenLevel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string updatedSystolic = txtSystolic.Text;
            string updatedDiastolic = txtDiastolic.Text;
            string updatedSugarLevel = txtSugarLevel.Text;
            string updatedHeartRate = txtHeartRate.Text;
            string updatedOxygenLevel = txtOxygenLevel.Text;

            if (!DataValidation.ValidateRequiredField("Systolic", updatedSystolic, true) ||
                !DataValidation.ValidateRequiredField("Diastolic", updatedDiastolic, true) ||
                !DataValidation.ValidateRequiredField("Sugar Level", updatedSugarLevel, true) ||
                !DataValidation.ValidateRequiredField("Heart Rate", updatedHeartRate, true) ||
                !DataValidation.ValidateRequiredField("Oxygen Level", updatedOxygenLevel, true))
            {
                return;
            }

            int systolic, diastolic, sugarLevel, heartRate, oxygenLevel;

            if (!DataValidation.TryParseMetric("Systolic", updatedSystolic, out systolic, true) ||
                !DataValidation.TryParseMetric("Diastolic", updatedDiastolic, out diastolic, true) ||
                !DataValidation.TryParseMetric("Sugar Level", updatedSugarLevel, out sugarLevel, true) ||
                !DataValidation.TryParseMetric("Heart Rate", updatedHeartRate, out heartRate, true) ||
                !DataValidation.TryParseMetric("Oxygen Level", updatedOxygenLevel, out oxygenLevel, true))
            {
                return;
            }

            if (!DataValidation.ValidateMetricRange("Systolic", systolic, 90, 180) ||
                !DataValidation.ValidateMetricRange("Diastolic", diastolic, 60, 120) ||
                !DataValidation.ValidateMetricRange("Sugar Level", sugarLevel, 70, 200) ||
                !DataValidation.ValidateMetricRange("Heart Rate", heartRate, 30, 180) ||
                !DataValidation.ValidateMetricRange("Oxygen Level", oxygenLevel, 85, 100))
            {
                return;
            }

            // Combine Systolic and Diastolic into Blood Pressure
            string updatedBloodPressure = $"{systolic}/{diastolic}";

            try
            {
                HealthDataAccess.UpdateHealthData(_dataID, updatedBloodPressure, updatedSugarLevel, updatedHeartRate.ToString(), updatedOxygenLevel.ToString());

                MessageBox.Show("Health data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
