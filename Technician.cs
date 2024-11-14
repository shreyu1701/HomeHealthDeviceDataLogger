using Home_Health_Device_Data_Logger.Utils;
using Newtonsoft.Json;
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
    public partial class Technician : Form
    {


        public Technician(HandleUser.User user)
        {
            InitializeComponent();
            //InitializeTechnicianDashboard();
            //DisplayUserInfo();
        }

        //private void InitializeTechnicianDashboard()
        //{
        //    // Load and display a list of all patients (You can get this data from your file or database)
        //    var allPatients = LoadPatientsFromFile(); // Assume this method loads all patients
        //    dataGridViewHistory.DataSource = allPatients;

        //    // Set up the DataGridView to show necessary columns like Name, Age, etc.
        //}

        private List<HandleUser.User> LoadPatientsFromFile()
        {
            // This should load all patients from the JSON file or a database
            string jsonFilePath = "users.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<HandleUser.User>>(jsonData) ?? new List<HandleUser.User>();
                //return Newtonsoft.Json.JsonSerializer.Deserialize<List<HandleUser.User>>(jsonData) ?? new List<HandleUser.User>();
            }
            return new List<HandleUser.User>();
        }

        //private void DisplayUserInfo()
        //{
        //    lblFullName.Text = $"Welcome, {loggedInUser.FirstName} + {loggedInUser.LastName}!";
        //    lblAgeNumber.Text = $"Age: {loggedInUser.Age}";
        //    lblGender.Text = $"Gender: {loggedInUser.Gender}";
        //    lblBloodGroup.Text = $"Blood Group:{loggedInUser.BloodGroup} ";

        //    // Display additional patient-specific data or options here.
        //}

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You are Logout from System", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picProfilePic.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnTechnicianAddHealthData_Click(object sender, EventArgs e)
        {
            TechnicianAddHealthData technicianAddHealthData = new TechnicianAddHealthData();
            technicianAddHealthData.Show();
            Visible = true;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.SelectedRows.Count > 0)
            {
                var selectedPatient = (HandleUser.User)dataGridViewHistory.SelectedRows[0].DataBoundItem;
                EditPatientForm editPatientForm = new EditPatientForm(selectedPatient);
                editPatientForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TechnicianAddHealthData technicianAddHealthData = new TechnicianAddHealthData();
            technicianAddHealthData.Show();
            Visible = true;
        }
    }
}
