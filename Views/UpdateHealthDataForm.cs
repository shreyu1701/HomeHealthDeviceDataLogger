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
    public partial class UpdateHealthDataForm : Form
    {
        private int _healthDataId;
        private string _systolic;
        private string _diastolic;
        private string _sugarLevel;
        private string _heartRate;
        private string _oxygenLevel;

        public bool IsUpdated { get; private set; }

        public UpdateHealthDataForm(int healthDataId, string systolic, string diastolic, string sugarLevel, string heartRate, string oxygenLevel)
        {
            InitializeComponent();
            _healthDataId = healthDataId;
            _systolic = systolic;
            _diastolic = diastolic;
            _sugarLevel = sugarLevel;
            _heartRate = heartRate;
            _oxygenLevel = oxygenLevel;

            txtSystolic.Text = _systolic;
            txtDiastolic.Text = _diastolic;
            txtSugarLevel.Text = _sugarLevel;
            txtHeartRate.Text = _heartRate;
            txtOxygenLevel.Text = _oxygenLevel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataValidation.ValidateRequiredField("Systolic", txtSystolic.Text, true) ||
                    !DataValidation.ValidateRequiredField("Diastolic", txtDiastolic.Text, true) ||
                    !DataValidation.ValidateRequiredField("Sugar Level", txtSugarLevel.Text, true) ||
                    !DataValidation.ValidateRequiredField("Heart Rate", txtHeartRate.Text, true) ||
                    !DataValidation.ValidateRequiredField("Oxygen Level", txtOxygenLevel.Text, true))
                {
                    return; 
                }

                if (!DataValidation.TryParseMetric("Systolic", txtSystolic.Text, out int systolic, true) ||
                    !DataValidation.TryParseMetric("Diastolic", txtDiastolic.Text, out int diastolic, true) ||
                    !DataValidation.TryParseMetric("Sugar Level", txtSugarLevel.Text, out int sugarLevel, true) ||
                    !DataValidation.TryParseMetric("Heart Rate", txtHeartRate.Text, out int heartRate, true) ||
                    !DataValidation.TryParseMetric("Oxygen Level", txtOxygenLevel.Text, out int oxygenLevel, true))
                {
                    return;
                }

                if (!DataValidation.ValidateMetricRange("Systolic Blood Pressure", systolic, 90, 180) ||
                    !DataValidation.ValidateMetricRange("Diastolic Blood Pressure", diastolic, 60, 120) ||
                    !DataValidation.ValidateMetricRange("Sugar Level", sugarLevel, 70, 140) ||
                    !DataValidation.ValidateMetricRange("Heart Rate", heartRate, 60, 100) ||
                    !DataValidation.ValidateMetricRange("Oxygen Level", oxygenLevel, 95, 100))
                {
                    return;
                }

                string bloodPressure = systolic + "/" + diastolic;

                bool success = HealthDataAccess.UpdateHealthData(_healthDataId, bloodPressure, sugarLevel, heartRate, oxygenLevel);

                if (success)
                {
                    IsUpdated = true;
                    MessageBox.Show("Health data updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update the health data. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
