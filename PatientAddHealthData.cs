using HomeHealthDeviceDataLogger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Home_Health_Device_Data_Logger
{
    public partial class PatientAddHealthData : Form
    {

        private Patient _patient;
        

        public PatientAddHealthData(Patient patient)
        {
            InitializeComponent();
            InitializeChart();
            _patient = patient;
        }

        private void AddHealthDataForm_Load(object sender, EventArgs e)
        {
            // Attach event handlers for checkbox changes
            txtBloodPressure.Enabled = chkBoxBloodPressure.Checked;
            txtSugarLevel.Enabled = chkBoxSugarLevel.Checked;
            txtHeartRate.Enabled = chkBoxHeartRate.Checked;
            txtOxygenLevel.Enabled = chkBoxOxygenLevel.Checked;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Validate checkbox selections
            if (!chkBoxBloodPressure.Checked && !chkBoxSugarLevel.Checked &&
                !chkBoxHeartRate.Checked && !chkBoxOxygenLevel.Checked)
            {
                MessageBox.Show("Please select at least one health metric.", "Add Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Blood Pressure validation
            if (chkBoxBloodPressure.Checked)
            {
                string bloodPressurePattern = @"^\d{2,3}/\d{2,3}$";
                bool validBP = Regex.IsMatch(txtBloodPressure.Text, bloodPressurePattern);
                SetValidationColor(txtBloodPressure, validBP);
                if (!validBP)
                {
                    MessageBox.Show("Please enter blood pressure as systolic/diastolic, e.g., 120/80.", "Blood Pressure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBloodPressure.Focus();
                    isValid = false;
                }
            }

            // Sugar Level validation
            if (chkBoxSugarLevel.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSugarLevel.Text) ||
                    !int.TryParse(txtSugarLevel.Text, out int sugarLevel) ||
                    sugarLevel < 70 || sugarLevel > 200)
                {
                    MessageBox.Show("Please enter a valid sugar level between 70 and 200 mg/dL.", "Sugar Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSugarLevel.Focus();
                    isValid = false;
                }
            }

            // Heart Rate validation
            if (chkBoxHeartRate.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtHeartRate.Text) ||
                    !int.TryParse(txtHeartRate.Text, out int heartRate) ||
                    heartRate < 40 || heartRate > 180)
                {
                    MessageBox.Show("Please enter a valid heart rate between 40 and 180 bpm.", "Heart Rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHeartRate.Focus();
                    isValid = false;
                }
            }

            // Oxygen Level validation
            if (chkBoxOxygenLevel.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtOxygenLevel.Text) ||
                    !int.TryParse(txtOxygenLevel.Text, out int oxygenLevel) ||
                    oxygenLevel < 90 || oxygenLevel > 100)
                {
                    MessageBox.Show("Please enter a valid oxygen level between 90 and 100%.", "Oxygen Level", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOxygenLevel.Focus();
                    isValid = false;
                }
            }

            if (!isValid)
            {
                return; // Stop if validation fails
            }

            // Save data if validation passes
            PatientData patientData = new PatientData
            {
                Date = dateTimePicker1.Value,
                BloodPressure = chkBoxBloodPressure.Checked ? txtBloodPressure.Text : null,
                SugarLevel = chkBoxSugarLevel.Checked ? int.Parse(txtSugarLevel.Text) : (int?)null,
                HeartRate = chkBoxHeartRate.Checked ? int.Parse(txtHeartRate.Text) : (int?)null,
                OxygenLevel = chkBoxOxygenLevel.Checked ? int.Parse(txtOxygenLevel.Text) : (int?)null
            };
            //patientData.Add(patientData);
            //SavePatientDataToFile();

            //MessageBox.Show("Health data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close(); // Close the form after adding the data

            patientData.SaveData(); // Save data
            MessageBox.Show("Data saved successfully!");
            UpdateChart(patientData);
            ClearForm(); // Clear the form after saving
            chtOverallHealth.Invalidate();
            this.Close();
        }

        // Method to set validation color for controls
        private void SetValidationColor(Control control, bool isValid)
        {
            control.BackColor = isValid ? Color.White : Color.LightPink;
        }

        // Method to clear the form
        private void ClearForm()
        {
            // Reset date picker to today's date
            dateTimePicker1.Value = DateTime.Today;

            // Uncheck all checkboxes
            chkBoxBloodPressure.Checked = false;
            chkBoxSugarLevel.Checked = false;
            chkBoxHeartRate.Checked = false;
            chkBoxOxygenLevel.Checked = false;

            // Clear all text fields
            txtBloodPressure.Clear();
            txtSugarLevel.Clear();
            txtHeartRate.Clear();
            txtOxygenLevel.Clear();

            // Disable all text fields
            txtBloodPressure.Enabled = false;
            txtSugarLevel.Enabled = false;
            txtHeartRate.Enabled = false;
            txtOxygenLevel.Enabled = false;
        }

        private Chart chtOverallHealth;

        private void UpdateChart(PatientData patientData)
        {
            if (chkBoxBloodPressure.Checked)
            {
                chtOverallHealth.Series["Blood Pressure"].Points.AddXY(patientData.Date, patientData.BloodPressure.Split('/')[0]);
            }

            if (chkBoxSugarLevel.Checked)
            {
                chtOverallHealth.Series["Sugar Level"].Points.AddXY(patientData.Date, patientData.SugarLevel);
            }

            if (chkBoxHeartRate.Checked)
            {
                chtOverallHealth.Series["Heart Rate"].Points.AddXY(patientData.Date, patientData.HeartRate);
            }

            if (chkBoxOxygenLevel.Checked)
            {
                chtOverallHealth.Series["Oxygen Level"].Points.AddXY(patientData.Date, patientData.OxygenLevel);
            }
        }
        

        private void InitializeChart()
        {
            chtOverallHealth = new Chart(); // Initialize chart if not done through Designer

            chtOverallHealth.Series.Clear();
            chtOverallHealth.ChartAreas.Clear();

            // Create chart area
            var chartArea = new ChartArea("MainArea");
            chtOverallHealth.ChartAreas.Add(chartArea);

            // Create series for each metric
            var bloodPressureSeries = new Series("Blood Pressure")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };

            var sugarLevelSeries = new Series("Sugar Level")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };

            var heartRateSeries = new Series("Heart Rate")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };

            var oxygenLevelSeries = new Series("Oxygen Level")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Orange,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };

            chtOverallHealth.Series.Add(bloodPressureSeries);
            chtOverallHealth.Series.Add(sugarLevelSeries);
            chtOverallHealth.Series.Add(heartRateSeries);
            chtOverallHealth.Series.Add(oxygenLevelSeries);

            chtOverallHealth.ChartAreas[0].AxisX.Title = "Date";
            chtOverallHealth.ChartAreas[0].AxisY.Title = "Values";

            // Add chart to the form's controls
            this.Controls.Add(chtOverallHealth); // If added dynamically
        }


        


        private void SavePatientDataToFile()
        {
            try
            {
                var patients = LoadPatientsFromFile();
                var patientIndex = patients.FindIndex(p => p.Email == _patient.Email);

                if (patientIndex >= 0)
                {
                    // Update the existing patient data
                    patients[patientIndex] = _patient;
                    SavePatientsToFile(patients);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving patient data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save the patients to the file (JSON format)
        private void SavePatientsToFile(List<Patient> patients)
        {
            string jsonFilePath = "patients.json";
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);
        }

        // Load the patients from the file (JSON format)
        private List<Patient> LoadPatientsFromFile()
        {
            string jsonFilePath = "patients.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Patient>>(jsonData) ?? new List<Patient>();
            }
            return new List<Patient>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
