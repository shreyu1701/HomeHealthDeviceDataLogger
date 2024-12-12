
using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Services;
using Home_Health_Device_Data_Logger.Views;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger
{
    public partial class Patient : Form
    {
        private User _user;
        private User LoggedInUser;
        private bool _isEditing;
        private ChartsService _chartService;

        public Patient(User user)
        {
            InitializeComponent();
            _user = user;
            LoggedInUser = user;
            _chartService = new ChartsService();
            DisableActionButtonsAfterTimeLimit();
            LoadPatientDashboard();
            LoadHealthHistory();
            SetEditMode(false);
            LoadProfileData();
            DisplaySideProfile();
            LoadAndUpdateCharts();


        }


        // Logout Button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are logged out from the system.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close(); // Properly close the current form.
        }



        //-------------------------------------------------------DASHBOARD-------------------------------------------------------------------


        // Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPatientDashboard();
        }

        // Load Patient Dashboard
        private void LoadPatientDashboard()
        {
            try
            {
                // Fetch health data
                var healthMetrics = HealthDataAccess.GetRecentHealthDataByUserId(LoggedInUser.UserID);
                dataGridViewPatientDashboard.DataSource = healthMetrics.Select(h => new
                {
                    h.DataID,
                    Date = h.DataDate.ToString("yyyy-MM-dd"),
                    h.BloodPressure,
                    h.SugarLevel,
                    h.HeartRate,
                    h.OxygenLevel,
                    h.CreatedAt
                }).ToList();

                // Add action buttons dynamically
                AddActionButtons();

                // Disable action buttons based on time limit
                DisableActionButtonsAfterTimeLimit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load health metrics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Action Buttons (Update/Delete)
        private void AddActionButtons()
        {
            if (!dataGridViewPatientDashboard.Columns.Contains("Update"))
            {
                dataGridViewPatientDashboard.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Update",
                    Text = "Update",
                    UseColumnTextForButtonValue = true,
                    Name = "Update"
                });
            }

            if (!dataGridViewPatientDashboard.Columns.Contains("Delete"))
            {
                dataGridViewPatientDashboard.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Name = "Delete"
                });
            }
        }

        // Disable Buttons After Time Limit
        private void DisableActionButtonsAfterTimeLimit()
        {
            foreach (DataGridViewRow row in dataGridViewPatientDashboard.Rows)
            {
                if (row.Cells["CreatedAt"].Value != null &&
                    DateTime.TryParse(row.Cells["CreatedAt"].Value.ToString(), out DateTime createdAt))
                {
                    if ((DateTime.Now - createdAt).TotalMinutes > 10)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGray;

                        if (row.Cells["Update"] is DataGridViewButtonCell updateCell)
                        {
                            updateCell.FlatStyle = FlatStyle.Flat;
                            updateCell.Style.ForeColor = Color.Gray;
                            updateCell.ReadOnly = true;
                        }

                        if (row.Cells["Delete"] is DataGridViewButtonCell deleteCell)
                        {
                            deleteCell.FlatStyle = FlatStyle.Flat;
                            deleteCell.Style.ForeColor = Color.Gray;
                            deleteCell.ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void DataGridViewPatientDashboard_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPatientDashboard.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridViewPatientDashboard.Rows[e.RowIndex].Cells["CreatedAt"].Value is DateTime createdAt)
            {
                // Check if the time limit has passed
                var elapsedTime = DateTime.Now - createdAt;
                if (elapsedTime.TotalMinutes > 10)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.DarkGray;
                    e.CellStyle.SelectionBackColor = Color.LightGray;
                    e.CellStyle.SelectionForeColor = Color.DarkGray;
                }
            }
        }

        // Handle Update/Delete Button Clicks
        private void dataGridViewPatientDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPatientDashboard.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
            {
                if (DateTime.TryParse(dataGridViewPatientDashboard.Rows[e.RowIndex].Cells["CreatedAt"].Value?.ToString(), out DateTime createdAt) &&
                    (DateTime.Now - createdAt).TotalMinutes > 10)
                {
                    MessageBox.Show("You can no longer update or delete this record after 10 minutes.",
                                    "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve the health data for the selected row
                var selectedRow = dataGridViewPatientDashboard.Rows[e.RowIndex];
                int dataId = Convert.ToInt32(selectedRow.Cells["dataId"].Value);
                string bloodPressure = selectedRow.Cells["BloodPressure"].Value.ToString();
                string sugarLevel = selectedRow.Cells["SugarLevel"].Value.ToString();
                string heartRate = selectedRow.Cells["HeartRate"].Value.ToString();
                string oxygenLevel = selectedRow.Cells["OxygenLevel"].Value.ToString();

                // Split BloodPressure into Systolic and Diastolic
                string[] bloodPressureParts = bloodPressure.Split('/');
                string systolic = bloodPressureParts.Length > 0 ? bloodPressureParts[0] : "0";
                string diastolic = bloodPressureParts.Length > 1 ? bloodPressureParts[1] : "0";

                // Handle Update logic
                if (buttonColumn.Name == "Update")
                {
                    // Open Update Form and pass the data for updating
                    var updateForm = new UpdateHealthDataForm(dataId, systolic, diastolic, sugarLevel, heartRate, oxygenLevel);
                    updateForm.ShowDialog();  // Open the form as a dialog so the user can't interact with other forms
                    if (updateForm.IsUpdated)
                    {
                        MessageBox.Show("Health data updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HealthDataAccess.GetRecentHealthDataByUserId(LoggedInUser.UserID);  // Refresh data after update
                    }
                }
                // Handle Delete logic
                else if (buttonColumn.Name == "Delete")
                {
                    // Confirm deletion before proceeding
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            // Call the delete method to remove the record from the database
                            bool success = HealthDataAccess.DeleteHealthDataById(dataId);
                            if (success)
                            {
                                MessageBox.Show("Health data deleted successfully!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                HealthDataAccess.GetRecentHealthDataByUserId(LoggedInUser.UserID);  // Refresh data after deletion
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------HISTORY-------------------------------------------------------------------
        private void LoadHealthHistory(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                // Assuming LoggedInUser.UserID holds the current user's ID
                var historyData = HealthDataAccess.GetHealthHistoryByUserId(LoggedInUser.UserID, startDate, endDate);

                // Bind data to DataGridView
                dataGridViewPatientHistory.DataSource = historyData;

                // Format columns if necessary
                dataGridViewPatientHistory.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewPatientHistory.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load health history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime? startDate = dateTimePicker5.Value.Date;
            DateTime? endDate = dateTimePicker1.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be later than the end date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadHealthHistory(startDate, endDate);

        }
        //-------------------------------------------------------CHARTS AND REPORTS-------------------------------------------------------------------


        private void LoadAndUpdateCharts()
        {
            try
            {
                // Fetch health data for the logged-in user from the database (or service)
                var healthData = HealthDataAccess.GetHealthDataByUserId(LoggedInUser.UserID);

                //// Assuming the healthData contains a list of HealthData objects
                //_chartService.UpdateBloodPressureChart(BloodPressureLineCharts, healthData);
                //_chartService.UpdateSugarLevelChart(SugarLevelLineCharts, healthData);
                //_chartService.UpdateHeartRateChart(HeartRateLineCharts, healthData);
                //_chartService.UpdateOxygenLevelChart(OxygenLevelLineCharts, healthData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Health History";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var data = dataGridViewPatientHistory.DataSource as DataTable;
                        if (data == null)
                        {
                            MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DateTime fromDate = dateTimePickerFromReports.Value.Date;
                        DateTime toDate = dateTimePickerToReports.Value.Date;

                        DataView dv = new DataView(data);
                        dv.RowFilter = $"Date >= #{fromDate.ToString("yyyy-MM-dd")}# AND Date <= #{toDate.ToString("yyyy-MM-dd")}#";
                        DataTable filteredData = dv.ToTable();

                        if (filteredData.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found in the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //ReportGenerationService.ExportToCsv(filteredData, saveFileDialog.FileName);
                        MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        MessageBox.Show("Access denied. Please choose a different location or file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to export data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //-------------------------------------------------------PROFILE-------------------------------------------------------------------


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
                picProfileImage.Image = Image.FromStream(new MemoryStream(LoggedInUser.ProfileImage));
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
        //Personal Save Button
        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            // Update the patient data (except UserID)
            LoggedInUser.FirstName = txtFirstName.Text;
            LoggedInUser.LastName = txtLastName.Text;
            LoggedInUser.Age = txtAge.Text;
            LoggedInUser.Gender = cmbGender.SelectedItem.ToString();
            LoggedInUser.BloodGroup = cmbBloodGroup.SelectedItem.ToString();
            LoggedInUser.Email = txtEmail.Text;
            LoggedInUser.Password = txtPassword.Text;
            LoggedInUser.PasswordHint = txtPasswordHint.Text;


            // Profile Image
            if (picProfileImage.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    picProfileImage.Image.Save(ms, picProfileImage.Image.RawFormat);
                    LoggedInUser.ProfileImage = ms.ToArray();
                }
            }

            // Save updated data to the database
            bool success = UserDataAccess.UpdateUserProfile(LoggedInUser);
            if (success)
            {
                

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetEditMode(false); // Disable editing after saving
                DisplaySideProfile();
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplaySideProfile()
        {
            lblFullName.Text = $"{LoggedInUser.FirstName} {LoggedInUser.LastName}";
            lblAgeNumber.Text = $"{LoggedInUser.Age}";
            lblGenderOptions.Text = $"{LoggedInUser.Gender}";
            lblBlood.Text = $"{LoggedInUser.BloodGroup}";

            // Load profile image if available
            if (LoggedInUser.ProfileImage != null)
            {
                picProfileImage.Image = Image.FromStream(new MemoryStream(LoggedInUser.ProfileImage));
            }
            else
            {
                // Default image if no profile image is available
                picProfileImage.Image = Properties.Resources.images;
            }
        }

        // Upload Profile Image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog())
                {
                    open.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        picProfileImage.Image = Image.FromFile(open.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to upload image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddHealthData_Click(object sender, EventArgs e)
        {
            AddHealthData addHealthData = new AddHealthData();
            addHealthData.Show();
            Visible = true;
        }

        private void btnPersonalEdit_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                // Cancel editing, reload data, and disable fields
                LoadProfileData();
                SetEditMode(false);
            }
            else
            {
                // Enable editing mode
                SetEditMode(true);
            }
        }
    }
}