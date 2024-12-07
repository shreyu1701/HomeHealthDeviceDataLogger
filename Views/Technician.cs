using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger
{
    public partial class Technician : Form
    {
        private User _user;

        public Technician(User user)
        {
            InitializeComponent();
            _user = user;
            LoadAllHealthData();
        }

        // Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logged out from the system", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();  // Hide the current form
        }

        // Upload Image
        // Upload Image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picProfilePic.Image = Image.FromFile(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        // Add Health Data Button
        private void btnTechnicianAddHealthData_Click(object sender, EventArgs e)
        {
            TechnicianAddHealthData technicianAddHealthData = new TechnicianAddHealthData();
            technicianAddHealthData.Show();

        }


        // Load all health data for all patients (for Technician Dashboard)
        private void LoadAllHealthData()
        {
            // Assuming HealthDataAccess.GetAllHealthData() returns a list of health data objects
            var healthDataList = HealthDataAccess.GetAllHealthData();
            dataGridViewTechnicianDashboard.DataSource = healthDataList.Select(h => new
            {
                h.DataID,
                Date = h.DataDate.ToString("yyyy-MM-dd"),
                h.BloodPressure,
                h.SugarLevel,
                h.HeartRate,
                h.OxygenLevel,
                //h.Comments
            }).ToList();
            // Add action buttons dynamically
            AddActionButtonsDashboard();

            dataGridViewTechnicianHistory.DataSource = healthDataList.Select(h => new
            {
                h.DataID,
                Date = h.DataDate.ToString("yyyy-MM-dd"),
                h.BloodPressure,
                h.SugarLevel,
                h.HeartRate,
                h.OxygenLevel,
                //h.Comments
            }).ToList();
            // Add action buttons dynamically
            AddActionButtonsHistory();
        }

        private void AddActionButtonsDashboard()
        {
            if (!dataGridViewTechnicianDashboard.Columns.Contains("btnUpdate"))
            {
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Text = "Update",
                    Name = "btnUpdate",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewTechnicianDashboard.Columns.Add(updateButtonColumn);
            }

            if (!dataGridViewTechnicianDashboard.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Action",
                    Text = "Delete",
                    Name = "btnDelete",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewTechnicianDashboard.Columns.Add(deleteButtonColumn);
            }
        }

        private void AddActionButtonsHistory()
        {
            if (!dataGridViewTechnicianHistory.Columns.Contains("Update"))
            {
                dataGridViewTechnicianHistory.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Update",
                    Text = "Update",
                    UseColumnTextForButtonValue = true,
                    Name = "Update"
                });
            }

            if (!dataGridViewTechnicianHistory.Columns.Contains("Delete"))
            {
                dataGridViewTechnicianHistory.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "Delete"
                });
            }
        }

        private void DataGridViewTechnicianDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid cell (not the header or outside the grid)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the column name to determine which button was clicked
                string columnName = dataGridViewTechnicianDashboard.Columns[e.ColumnIndex].Name;

                // Retrieve the DataID from the clicked row (assuming DataID is a column)
                int selectedDataID = Convert.ToInt32(dataGridViewTechnicianDashboard.Rows[e.RowIndex].Cells["DataID"].Value);

                // Check if the clicked column is the "Update" button
                if (columnName == "btnUpdate")
                {
                    // Handle the update logic
                    HandleUpdateButtonClick(selectedDataID);
                }
                // Check if the clicked column is the "Delete" button
                else if (columnName == "btnDelete")
                {
                    // Handle the delete logic
                    HandleDeleteButtonClick(selectedDataID);
                }
            }
        }
        private void DataGridViewTechnicianHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid cell (not the header or outside the grid)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the column name to determine which button was clicked
                string columnName = dataGridViewTechnicianHistory.Columns[e.ColumnIndex].Name;

                // Retrieve the DataID from the clicked row (assuming DataID is a column)
                int selectedDataID = Convert.ToInt32(dataGridViewTechnicianHistory.Rows[e.RowIndex].Cells["DataID"].Value);

                // Check if the clicked column is the "Update" button
                if (columnName == "btnUpdate")
                {
                    // Handle the update logic
                    HandleUpdateButtonClick(selectedDataID);
                }
                // Check if the clicked column is the "Delete" button
                else if (columnName == "btnDelete")
                {
                    // Handle the delete logic
                    HandleDeleteButtonClick(selectedDataID);
                }
            }
        }


        private void HandleUpdateButtonClick(int dataID)
        {
            // Fetch data for the selected record
            var healthData = HealthDataAccess.GetHealthDataByID(dataID);

            if (healthData != null)
            {
                // Extract values from healthData object
                string systolic = healthData.BloodPressure?.Split('/')[0] ?? "N/A";  // Split systolic/diastolic
                string diastolic = healthData.BloodPressure?.Split('/')[1] ?? "N/A";
                string sugarLevel = healthData.SugarLevel ?? "N/A";
                string heartRate = healthData.HeartRate.ToString();
                string oxygenLevel = healthData.OxygenLevel.ToString();



                // Open the Update Form with the selected data
                var updateForm = new UpdateHealthDataTechnicianForm(dataID, systolic, diastolic, sugarLevel, heartRate, oxygenLevel);
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    // Refresh the DataGridView after successful update
                    LoadAllHealthData();
                }
            }
            else
            {
                MessageBox.Show("The selected record no longer exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void HandleDeleteButtonClick(int dataID)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                bool isDeleted = HealthDataAccess.DeleteHealthData(dataID);

                if (isDeleted)
                {
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllHealthData(); // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete the record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void btnFilter_Click(object sender, EventArgs e)
        {
            var healthDataList = HealthDataAccess.GetAllHealthData();
            var filteredData = healthDataList;

            // Apply Date Range Filter
            if (dateTimePickerHistoryFrom.Value <= dateTimePickerHistoryTo.Value)
            {
                filteredData = filteredData.Where(h =>
                    h.DataDate >= dateTimePickerHistoryFrom.Value && h.DataDate <= dateTimePickerHistoryTo.Value).ToList();
            }

            // Update DataGridView
            dataGridViewTechnicianHistory.DataSource = filteredData.Select(h => new
            {
                h.DataID,
                Date = h.DataDate.ToString("yyyy-MM-dd"),
                h.BloodPressure,
                h.SugarLevel,
                h.HeartRate,
                h.OxygenLevel,
                h.Comments,
                h.CreatedAt
            }).ToList();
        }

        // Add Patient Button - You can implement your patient addition logic here
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            // Example placeholder for adding a patient
            MessageBox.Show("Add Patient button clicked.");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllHealthData();
        }

    }
}
