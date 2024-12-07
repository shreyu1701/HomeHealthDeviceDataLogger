using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using SixLabors.ImageSharp.Drawing;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger
{
    public partial class TechnicianAddHealthData : Form
    {
        private const int MinHeartRate = 40, MaxHeartRate = 180;
        private const int MinOxygenLevel = 70, MaxOxygenLevel = 100;
        private const int MinBloodPressureSystolic = 90, MaxBloodPressureSystolic = 180;
        private const int MinBloodPressureDiastolic = 60, MaxBloodPressureDiastolic = 120;
        private const int MinSugarLevel = 70, MaxSugarLevel = 300;


        public TechnicianAddHealthData()
        {
            InitializeComponent();
            SetDefaultStates();
            LoadPatientDropdown();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if at least one checkbox is selected
            if (!chkBoxBloodPressure.Checked && !chkBoxHeartRate.Checked &&
                !chkBoxSugarLevel.Checked && !chkBoxOxygenLevel.Checked)
            {
                MessageBox.Show("Please select at least one health metric to save data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPatientName.SelectedValue == null || !int.TryParse(cmbPatientName.SelectedValue.ToString(), out int selectedUserID))
            {
                MessageBox.Show("Please select a valid patient from the dropdown.");
                return;
            }


            int systolic = 0, diastolic = 0, heartRate = 0, sugar = 0, oxygenLevel = 0;
            string bloodPressure = null, sugarLevel = null;

            try
            {
                if (chkBoxBloodPressure.Checked)
                {
                    if (!DataValidation.ValidateRequiredField("Systolic Blood Pressure", txtSystolic.Text, chkBoxBloodPressure.Checked) ||
                        !DataValidation.ValidateRequiredField("Diastolic Blood Pressure", txtDiastolic.Text, chkBoxBloodPressure.Checked) ||
                        !DataValidation.TryParseMetric("Systolic Blood Pressure", txtSystolic.Text, out systolic, chkBoxBloodPressure.Checked) ||
                        !DataValidation.TryParseMetric("Diastolic Blood Pressure", txtDiastolic.Text, out diastolic, chkBoxBloodPressure.Checked) ||
                        !DataValidation.ValidateMetricRange("Systolic Blood Pressure", systolic, MinBloodPressureSystolic, MaxBloodPressureSystolic) ||
                        !DataValidation.ValidateMetricRange("Diastolic Blood Pressure", diastolic, MinBloodPressureDiastolic, MaxBloodPressureDiastolic))
                    {
                        return;
                    }
                }

                // Validate Heart Rate
                if (chkBoxHeartRate.Checked)
                {
                    if (!DataValidation.ValidateRequiredField("Heart Rate", txtHeartRate.Text, chkBoxHeartRate.Checked) ||
                        !DataValidation.TryParseMetric("Heart Rate", txtHeartRate.Text, out heartRate, chkBoxHeartRate.Checked) ||
                        !DataValidation.ValidateMetricRange("Heart Rate", heartRate, MinHeartRate, MaxHeartRate))
                    {
                        return;
                    }
                }

                // Validate Sugar Level
                if (chkBoxSugarLevel.Checked)
                {
                    if (!DataValidation.ValidateRequiredField("Sugar Level", txtSugarLevel.Text, chkBoxSugarLevel.Checked) ||
                        !DataValidation.TryParseMetric("Sugar Level", txtSugarLevel.Text, out sugar, chkBoxSugarLevel.Checked) ||
                        !DataValidation.ValidateMetricRange("Sugar Level", sugar, MinSugarLevel, MaxSugarLevel))
                    {
                        return;
                    }
                }

                // Validate Oxygen Level
                if (chkBoxOxygenLevel.Checked)
                {
                    if (!DataValidation.ValidateRequiredField("Oxygen Level", txtOxygenLevel.Text, chkBoxOxygenLevel.Checked) ||
                        !DataValidation.TryParseMetric("Oxygen Level", txtOxygenLevel.Text, out oxygenLevel, chkBoxOxygenLevel.Checked) ||
                        !DataValidation.ValidateMetricRange("Oxygen Level", oxygenLevel, MinOxygenLevel, MaxOxygenLevel))
                    {
                        return;
                    }
                }

                var healthData = new HealthData
                {
                    UserID = selectedUserID,
                    DataDate = dateTimePicker1.Value,
                    BloodPressure = systolic.ToString() + "/" + diastolic.ToString(),
                    SugarLevel = sugar.ToString(),
                    HeartRate = heartRate,
                    OxygenLevel = oxygenLevel,
                    Comments = string.IsNullOrWhiteSpace(richTxtComments.Text.Trim()) ? null : richTxtComments.Text.Trim()
                };

                HealthDataAccess.SaveHealthData(healthData);
                MessageBox.Show("Health data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error]: {ex}");
                MessageBox.Show("An unexpected error occurred while saving health data.");
            }

            ClearFields();
        }

        private void LoadPatientDropdown()
        {
            // Fetch patients from the database
            List<User> patients = UserDataAccess.GetAllPatients();

            // Bind the dropdown (ComboBox)
            cmbPatientName.DataSource = patients;
            cmbPatientName.DisplayMember = "FullName"; // Combine FirstName and LastName for display
            cmbPatientName.ValueMember = "UserID";    // Use UserID as the value
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected patient's UserID
            int selectedUserID = (int)cmbPatientName.SelectedValue;

            // (Optional) Display or use the UserID as needed
            Console.WriteLine($"Selected Patient UserID: {selectedUserID}");
        }



        private void ClearFields()
        {
            cmbPatientName.SelectedIndex = -1;
            txtSystolic.Clear();
            txtDiastolic.Clear();
            txtSugarLevel.Clear();
            txtHeartRate.Clear();
            txtOxygenLevel.Clear();

            // Reset checkbox states
            chkBoxBloodPressure.Checked = false;
            chkBoxHeartRate.Checked = false;
            chkBoxSugarLevel.Checked = false;
            chkBoxOxygenLevel.Checked = false;
        }

        private void SetDefaultStates()
        {
            txtSystolic.Enabled = false;
            txtDiastolic.Enabled = false;
            txtSugarLevel.Enabled = false;
            txtHeartRate.Enabled = false;
            txtOxygenLevel.Enabled = false;
        }

        private void chkBoxBloodPressure_CheckedChanged(object sender, EventArgs e)
        {
            txtSystolic.Enabled = chkBoxBloodPressure.Checked;
            txtDiastolic.Enabled = chkBoxBloodPressure.Checked;
        }

        private void chkBoxSugarLevel_CheckedChanged(object sender, EventArgs e)
        {
            txtSugarLevel.Enabled = chkBoxSugarLevel.Checked;
        }

        private void chkBoxHeartRate_CheckedChanged(object sender, EventArgs e)
        {
            txtHeartRate.Enabled = chkBoxHeartRate.Checked;
        }

        private void chkBoxOxygenLevel_CheckedChanged(object sender, EventArgs e)
        {
            txtOxygenLevel.Enabled = chkBoxOxygenLevel.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
