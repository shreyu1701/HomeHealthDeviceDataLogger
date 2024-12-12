using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using Home_Health_Device_Data_Logger.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Home_Health_Device_Data_Logger
{
    public partial class Technician : Form
    {
        private User _user;
        private User LoggedInUser;
        private bool _isEditing;
        private ChartsService _chartService;

        public Technician(User user)
        {
            InitializeComponent();
            _user = user;
            LoggedInUser = user;
            _chartService = new ChartsService();
            LoadAllHealthData();
            LoadPatientNames();
            SetEditMode(false);
            LoadProfileData();

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
                h.UserID,
                Date = h.DataDate.ToString("yyyy-MM-dd"),
                h.BloodPressure,
                h.SugarLevel,
                h.HeartRate,
                h.OxygenLevel,
                //h.Comments
            }).ToList();

            // Hide DataID column in Technician Dashboard
            if (dataGridViewTechnicianDashboard.Columns.Contains("DataID"))
            {
                dataGridViewTechnicianDashboard.Columns["DataID"].Visible = false;
            }

            // Add action buttons dynamically
            AddActionButtonsDashboard();

            dataGridViewTechnicianHistory.DataSource = healthDataList.Select(h => new
            {
                h.DataID,
                h.UserID,
                Date = h.DataDate.ToString("yyyy-MM-dd"),
                h.BloodPressure,
                h.SugarLevel,
                h.HeartRate,
                h.OxygenLevel,
                //h.Comments
            }).ToList();

            // Hide DataID column in Technician History
            if (dataGridViewTechnicianHistory.Columns.Contains("DataID"))
            {
                dataGridViewTechnicianHistory.Columns["DataID"].Visible = false;
            }

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
            // Add Update Button if not already present
            if (!dataGridViewTechnicianHistory.Columns.Contains("Update"))
            {
                var updateButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Actions",
                    Text = "Update",
                    UseColumnTextForButtonValue = true,
                    Name = "Update",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridViewTechnicianHistory.Columns.Add(updateButtonColumn);
            }

            // Add Delete Button if not already present
            if (!dataGridViewTechnicianHistory.Columns.Contains("Delete"))
            {
                var deleteButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Actions",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "Delete",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridViewTechnicianHistory.Columns.Add(deleteButtonColumn);
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
        private void dataGridViewTechnicianHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or a non-button column
            if (e.RowIndex < 0) return;

            string columnName = dataGridViewTechnicianHistory.Columns[e.ColumnIndex].Name;

            if (columnName == "Update")
            {
                int dataID = Convert.ToInt32(dataGridViewTechnicianHistory.Rows[e.RowIndex].Cells["DataID"].Value);
                HandleUpdateButtonClick(dataID);
            }
            else if (columnName == "Delete")
            {
                int dataID = Convert.ToInt32(dataGridViewTechnicianHistory.Rows[e.RowIndex].Cells["DataID"].Value);
                HandleDeleteButtonClick(dataID);
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
                try
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
                catch (Exception ex)
                {
                    // Log the exception for debugging
                    Console.WriteLine($"Error while deleting record: {ex.Message}");
                    MessageBox.Show("An unexpected error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Load Patient Name
        private void LoadPatientNames()
        {
            try
            {
                var patientNames = UserDataAccess.GetPatientNames();
                cmbPatientNames.DataSource = patientNames;
                cmbPatientNames.DisplayMember = "FullName";  // Display patient names
                cmbPatientNames.ValueMember = "UserID";     // Use UserID as the value
                cmbPatientNames.SelectedIndex = -1;         // Default to no selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load patient names: " + ex.Message);
            }
        }


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate patient name selection
                if (cmbPatientNames.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a patient name to search.");
                    return;
                }

                // Validate date range selection
                DateTime fromDate = dateTimePickerChartsFrom.Value;
                DateTime toDate = dateTimePickerChartsTo.Value;

                if (fromDate > toDate)
                {
                    MessageBox.Show("The 'From' date cannot be later than the 'To' date.");
                    return;
                }

                string selectedPatientName = cmbPatientNames.SelectedItem?.ToString();

                // Fetch filtered health data based on patient name
                var filteredHealthData = HealthDataAccess.GetHealthDataByPatientName(selectedPatientName);

                if (filteredHealthData == null || filteredHealthData.Count == 0)
                {
                    MessageBox.Show("No health data found for the selected patient.");
                    return;
                }

                // Filter data further by date range
                var dateFilteredData = filteredHealthData
                    .Where(h => h.DataDate >= fromDate && h.DataDate <= toDate)
                    .ToList();

                if (dateFilteredData == null || dateFilteredData.Count == 0)
                {
                    MessageBox.Show("No health data found for the selected patient within the specified date range.");
                    return;
                }

                // Bind data to DataGridView
                //dgvHealthData.AutoGenerateColumns = true;
                //dgvHealthData.DataSource = dateFilteredData;

                // Update charts with filtered data
                _chartService.UpdateBloodPressureChart(chtBloodPressure, dateFilteredData, fromDate, toDate);
                _chartService.UpdateSugarLevelChart(chtSugarLevel, dateFilteredData, fromDate, toDate);
                _chartService.UpdateHeartRateChart(chtHeartRate, dateFilteredData, fromDate, toDate);
                _chartService.UpdateOxygenLevelChart(chtOxygenLevel, dateFilteredData, fromDate, toDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}");
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            string userIdInput = txtID.Text.Trim();

            // Validate User ID input
            if (string.IsNullOrWhiteSpace(userIdInput))
            {
                MessageBox.Show("Please enter a User ID.");
                return;
            }

            if (!int.TryParse(userIdInput, out int userId))
            {
                MessageBox.Show("Invalid User ID. Please enter a valid integer.");
                return;
            }

            // Validate date range
            DateTime? startDate = dateTimePickerHistoryFrom.Checked ? dateTimePickerHistoryFrom.Value.Date : (DateTime?)null;
            DateTime? endDate = dateTimePickerHistoryTo.Checked ? dateTimePickerHistoryTo.Value.Date : (DateTime?)null;

            if (startDate.HasValue && endDate.HasValue && startDate > endDate)
            {
                MessageBox.Show("Invalid date range. Please select a valid 'From' and 'To' date.");
                return;
            }

            try
            {
                // Fetch data from database
                DataTable healthDataTable = HealthDataAccess.GetHealthHistoryByUserId(userId, startDate, endDate);

                // Check if data exists
                if (healthDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the specified criteria.");
                    dataGridViewTechnicianHistory.DataSource = null; // Clear DataGridView
                    return;
                }

                // Bind data to DataGridView
                dataGridViewTechnicianHistory.DataSource = healthDataTable;
                dataGridViewTechnicianHistory.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving health data: {ex.Message}");
            }
        }

        //reports
        private void btnDownload_Click(object sender, EventArgs e)
        {
            PatientInfo selectedPatient = cmbPatientNames.SelectedItem as PatientInfo;
            if (selectedPatient != null)
            {
                int selectedPatientUserID = selectedPatient.UserID;
                string patientName = cmbPatientNames.Text;  // Or get from the selected item
                string userId = cmbPatientNames.SelectedValue.ToString();

                DateTime startDate = dateTimePickerTechnicianGenerateFrom.Value;
                DateTime endDate = dateTimePickerTechnicianGenerateTo.Value;

                DataTable healthData = HealthDataAccess.GetHealthDataForPatient(selectedPatientUserID, startDate, endDate);

                // Generate the report (PDF or Excel) based on selected format
                if (rdoPDF.Checked)
                {
                    ReportGenerationService.ExportReport(healthData, true, patientName, userId);
                }
                else if (rdoExcel.Checked)
                {
                    ReportGenerationService.ExportReport(healthData, false, patientName, userId);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient name to search.");
            }
        }


        // Add Patient Button - You can implement your patient addition logic here
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Visible = true;
        }

        private void LoadProfileData()
        {
            // Personal Info (make UserID non-editable)
            lblUserID.Text = LoggedInUser.UserID.ToString();  // Display UserID, but don't allow editing
            txtFirstName.Text = LoggedInUser.FirstName;
            txtLastName.Text = LoggedInUser.LastName;
            txtAge.Text = LoggedInUser.Age;
            cmbGender.SelectedItem = LoggedInUser.Gender;
            cmbBloodGroup.SelectedItem = LoggedInUser.BloodGroup;
            txtEmail.Text = LoggedInUser.Email;
            txtPassword.Text = LoggedInUser.Password;
            txtPasswordHint.Text = LoggedInUser.PasswordHint;

            // Profile Image
            if (LoggedInUser.ProfileImage != null)
            {
                picProfilePic.Image = Image.FromStream(new MemoryStream(LoggedInUser.ProfileImage));
            }
        }

        private void SetEditMode(bool isEditing)
        {
            _isEditing = isEditing;

            // Enable/Disable textboxes and combo boxes
            txtFirstName.Enabled = isEditing;
            txtLastName.Enabled = isEditing;
            txtAge.Enabled = isEditing;
            cmbGender.Enabled = isEditing;
            cmbBloodGroup.Enabled = isEditing;
            txtEmail.Enabled = isEditing;
            txtPassword.Enabled = isEditing;
            txtPasswordHint.Enabled = isEditing;

            // Enable/Disable upload button and save button
            btnUploadImage.Enabled = isEditing;
            btnPersonalSave.Enabled = isEditing;

            // Toggle the Edit button text
            btnPersonalEdit.Text = isEditing ? "Cancel" : "Edit";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllHealthData();
        }

       
    }
}