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

        // Constructor to pass the current health data
        public UpdateHealthDataForm(int healthDataId, string systolic, string diastolic, string sugarLevel, string heartRate, string oxygenLevel)
        {
            InitializeComponent();
            _healthDataId = healthDataId;
            _systolic = systolic;
            _diastolic = diastolic;
            _sugarLevel = sugarLevel;
            _heartRate = heartRate;
            _oxygenLevel = oxygenLevel;

            // Pre-fill the textboxes with the current data
            txtSystolic.Text = _systolic;
            txtDiastolic.Text = _diastolic;
            txtSugarLevel.Text = _sugarLevel;
            txtHeartRate.Text = _heartRate;
            txtOxygenLevel.Text = _oxygenLevel;
        }

        // Save Button Clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input data
                if (string.IsNullOrWhiteSpace(txtSystolic.Text) ||
                    string.IsNullOrWhiteSpace(txtDiastolic.Text) ||
                    string.IsNullOrWhiteSpace(txtSugarLevel.Text) ||
                    string.IsNullOrWhiteSpace(txtHeartRate.Text) ||
                    string.IsNullOrWhiteSpace(txtOxygenLevel.Text))
                {
                    MessageBox.Show("Please fill all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse and validate numeric fields
                if (!int.TryParse(txtSystolic.Text, out int systolic) ||
                    !int.TryParse(txtDiastolic.Text, out int diastolic) ||
                    !int.TryParse(txtSugarLevel.Text, out int sugarLevel) ||
                    !int.TryParse(txtHeartRate.Text, out int heartRate) ||
                    !int.TryParse(txtOxygenLevel.Text, out int oxygenLevel))
                {
                    MessageBox.Show("Please enter valid numeric values for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Combine Systolic and Diastolic into Blood Pressure
                string bloodPressure = systolic + "/" + diastolic;

                // Update health data in the database
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


        // Cancel Button Clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
