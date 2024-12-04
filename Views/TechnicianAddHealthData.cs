using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
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
        public TechnicianAddHealthData()
        {
            InitializeComponent();
            LoadPatientDropdown();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if at least one checkbox is checked
            if (!chkBoxBloodPressure.Checked && !chkBoxHeartRate.Checked && !chkBoxSugarLevel.Checked && !chkBoxOxygenLevel.Checked)
            {
                MessageBox.Show("Please select at least one health metric to save data.");
                return;
            }

            // Validate inputs based on selected metrics
            if (chkBoxBloodPressure.Checked && (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Please enter valid blood pressure values.");
                return;
            }

            if (chkBoxHeartRate.Checked && string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid heart rate.");
                return;
            }

            if (chkBoxSugarLevel.Checked && string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter a valid sugar level.");
                return;
            }

            if (chkBoxOxygenLevel.Checked && string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter a valid oxygen level.");
                return;
            }

            if (cmbPatientName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient from the dropdown.");
                return;
            }

            try
            {
                // Fetch the UserID from the session
                int selectedUserID = (int)cmbPatientName.SelectedValue;

                // Create the HealthData object
                var healthData = new HealthData
                {
                    UserID = selectedUserID,
                    DataDate = dateTimePicker1.Value,
                    BloodPressure = chkBoxBloodPressure.Checked ? $"{textBox1.Text}/{textBox2.Text}" : null,
                    SugarLevel = chkBoxSugarLevel.Checked ? textBox4.Text : null,
                    HeartRate = chkBoxHeartRate.Checked && int.TryParse(textBox3.Text, out var hr) ? hr : 0,
                    OxygenLevel = chkBoxOxygenLevel.Checked && int.TryParse(textBox5.Text, out var ol) ? ol : 0,
                    Comments = string.IsNullOrEmpty(richTxtComments.Text) ? null : richTxtComments.Text
                };

                // Save the health data
                HealthDataAccess.SaveHealthData(healthData);
                MessageBox.Show("Health data saved successfully.");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving health data: {ex.Message}");
            }
            // Optionally clear the fields after saving
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
            cmbPatientName.SelectedIndex = -1 ;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            // Reset checkbox states
            chkBoxBloodPressure.Checked = false;
            chkBoxHeartRate.Checked = false;
            chkBoxSugarLevel.Checked = false;
            chkBoxOxygenLevel.Checked = false;
        }

        private void chkBoxBloodPressure_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = chkBoxBloodPressure.Checked;
            textBox2.Enabled = chkBoxBloodPressure.Checked;
        }

        private void chkBoxHeartRate_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = chkBoxHeartRate.Checked;
        }

        private void chkBoxSugarLevel_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = chkBoxSugarLevel.Checked;
        }

        private void chkBoxOxygenLevel_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = chkBoxOxygenLevel.Checked;
        }

    }
}
