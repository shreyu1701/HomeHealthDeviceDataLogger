
using Home_Health_Device_Data_Logger.HandleUser;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace Home_Health_Device_Data_Logger
{
    public partial class Patient : Form
    {
        private HandleUser.User currentUser;
        private Patient _patient;

        public object Email { get; internal set; }

        public Patient(HandleUser.User user)
        {
            InitializeComponent();
            currentUser = user;
            //InitializePatientDashboard();
            //DisplayUserInfo();
        }


        //private void InitializePatientDashboard()
        //{
        //    // Load patient data (you can customize this with the data you want to display)
        //    lblFullName.Text = $"{currentUser.FirstName} {currentUser.LastName}";
        //    lblAge.Text = currentUser.Age.ToString();
        //    lblGender.Text = currentUser.Gender;
        //    lblBloodGroup.Text = currentUser.BloodGroup;

        //    // You can also load health data from a database or file here
        //    // Display health data like blood pressure, sugar levels, etc.
        //}

        //private void DisplayUserInfo()
        //{
        //    try
        //    {
        //        lblFullName.Text = $"Welcome, {loggedInUser.FirstName} + {loggedInUser.LastName}!";
        //        lblAgeNumber.Text = $"Age: {loggedInUser.Age}";
        //        lblGender.Text = $"Gender: {loggedInUser.Gender}";
        //        lblBloodGroup.Text = $"Blood Group:{loggedInUser.BloodGroup} ";

        //        // Display additional patient-specific data or options here.
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Displaying user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You are Logout from System", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        //Upload Image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picProfileImage.Image = Image.FromFile(open.FileName);
            }
        }
        //Personal Save Button
        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Information  Save in System", "Personal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Contact Save Button
        private void btnContactSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Information  Save in System", "Contact Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Health Save Button
        private void btnHealthSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Health Information  Save in System", "Health Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Account Save Button
        private void btnAccountSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Information  Save in System", "Account Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddHealthData_Click(object sender, EventArgs e)
        {
            PatientAddHealthData addHealthDataForm = new PatientAddHealthData(_patient);
            addHealthDataForm.ShowDialog();
        }

    }
}
