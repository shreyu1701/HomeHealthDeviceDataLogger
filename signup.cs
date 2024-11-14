using Forge.OpenAI.Models.Files;
using Forge.OpenAI.Models.Messages;
using Home_Health_Device_Data_Logger.Encryption_and_Decryption;
using Home_Health_Device_Data_Logger.HandleUser;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using SixLabors.ImageSharp.Drawing.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Home_Health_Device_Data_Logger
{
    public partial class Signup : Form
    {
        private Founder Founder = new Founder();
        private const string FilePath = "users.json";

        public Signup()
        {
            InitializeComponent();
        }

        //Validation of Sign up
        private void btnSignup_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "Other";
            string? bloodGroup = cmbBloodGroup.SelectedItem?.ToString();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string passwordHint = txtPasswordHint.Text.Trim();
            string role = rdoPatient.Checked ? "Patient" : "Technician";
            string profileImage = picUploadImage.ImageLocation;


            var errorMessages = ValidateRegistrationForm(firstName, lastName, age, gender, bloodGroup, email, password, confirmPassword, passwordHint, role);

            if (errorMessages.Any())
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ageInput = int.Parse(age); // Safe to parse since we validated it earlier

            if (HandleUser.User.IsEmailRegistered(email))
            {
                MessageBox.Show("This email is already registered.");
                return;
            }

            // Create new user
            HandleUser.User newUser = new HandleUser.User(firstName, lastName, age, gender, bloodGroup, email, password, confirmPassword, passwordHint, role, profileImage);


            // Add user to JSON file
            try
            {
                var users = LoadUsersFromFile();
                users.Add(newUser);
                SaveUsersToFile(users);

                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the Signup form after successful signup
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Clear form fields
            ClearRegistrationForm();
            Close();

            //Login GUI
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        //Help to Validate Registration Form
        private List<string> ValidateRegistrationForm(string firstName, string lastName, string age, string gender, string bloodGroup,
                                              string email, string password, string confirmPassword,
                                              string passwordHint, string role)
        {
            var errorMessages = new List<string>();

            // Validate name fields
            if (string.IsNullOrEmpty(firstName)) errorMessages.Add("First name cannot be empty.");
            if (string.IsNullOrEmpty(lastName)) errorMessages.Add("Last name cannot be empty.");

            // Validate age
            if (!int.TryParse(age, out int ageInput) || ageInput < 0 || ageInput > 120)
                errorMessages.Add("Please enter a valid age between 0 and 120.");

            // Validate gender
            if (string.IsNullOrEmpty(gender)) errorMessages.Add("Please select a gender.");

            // Validate blood group
            if (string.IsNullOrEmpty(bloodGroup)) errorMessages.Add("Please select a valid blood group.");

            // Validate email
            if (!IsValidEmail(email)) errorMessages.Add("Please enter a valid email address.");

            // Validate password and confirm password
            if (password.Length < 6) errorMessages.Add("Password must be at least 6 characters long.");
            if (password != confirmPassword) errorMessages.Add("Password and Confirm Password must match.");

            // Validate password hint
            if (string.IsNullOrEmpty(passwordHint)) errorMessages.Add("Password hint cannot be empty.");

            // Validate role
            if (string.IsNullOrEmpty(role)) errorMessages.Add("Please select a role (Patient or Technician).");

            return errorMessages;
        }

        //Help to Valid Email
        private static bool IsValidEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }
        //Help to Valid Password
        private static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }


        //Upload Profile Image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picUploadImage.ImageLocation = open.FileName;
            }
        }

        //Clear form fields
        private void ClearRegistrationForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoOther.Checked = false;
            cmbBloodGroup.SelectedIndex = -1;
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPasswordHint.Clear();
            rdoPatient.Checked = false;
            rdoTechnician.Checked = false;
            picUploadImage.Image = null; // Reset profile picture
        }

        // Method to load users from JSON
        private List<HandleUser.User> LoadUsersFromFile()
        {
            string jsonFilePath = "users.json";
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<HandleUser.User>>(jsonData) ?? new List<HandleUser.User>();
                //return Newtonsoft.Json.JsonSerializer.Deserialize<List<HandleUser.User>>(jsonData) ?? new List<HandleUser.User>();
            }
            return new List<HandleUser.User>();
        }


        // Method to save users to JSON
        private void SaveUsersToFile(List<HandleUser.User> users)
        {
            string jsonFilePath = "users.json";
            string jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            //string jsonData = Newtonsoft.Json.JsosnSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, jsonData);
        }

    }
}
