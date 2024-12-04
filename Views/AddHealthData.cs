using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using System;
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
    public partial class AddHealthData : Form
    {
        public AddHealthData()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            try
            {
                // Fetch the UserID from the session
                int currentUserId = UserSession.CurrentUserID;

                // Create the HealthData object
                var healthData = new HealthData
                {
                    UserID = currentUserId,
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

        private void ClearFields()
        {
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
    }
}
