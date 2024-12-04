using Home_Health_Device_Data_Logger.Views;
using Home_Health_Device_Data_Logger.Services;

namespace Home_Health_Device_Data_Logger
{
    public partial class Signup : Form
    {
        // Static list to hold registered users
        private List<Models.User> Users;
        private byte[] ProfileImageData;

        public Signup()
        {
            InitializeComponent();
            Users = new List<Models.User>();
        }


        //Upload Profile Image
        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                picUploadImage.ImageLocation = open.FileName;

                // Convert image file to byte array
                using (var stream = new System.IO.FileStream(open.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    using (var reader = new System.IO.BinaryReader(stream))
                    {
                        ProfileImageData = reader.ReadBytes((int)stream.Length);
                    }
                }
            }
        }

        //Validation of Sign up
        private void btnSignup_Click(object sender, EventArgs e)
        {

            // Collect user input
            var user = new Models.User
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Age = txtAge.Text.Trim(),
                Gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : rdoOther.Checked ? "Other" : null,
                BloodGroup = cmbBloodGroup.SelectedItem?.ToString(),
                Email = txtEmail.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                ConfirmPassword = txtConfirmPassword.Text.Trim(),
                PasswordHint = txtPasswordHint.Text.Trim(),
                Role = rdoPatient.Checked ? "Patient" : rdoTechnician.Checked ? "Technician" : null,
                ProfileImage = ProfileImageData
            };

            // Validate inputs
            var errorMessages = ValidateRegistrationForm(
                user.FirstName,
                user.LastName,
                user.Age,
                user.Gender,
                user.BloodGroup,
                user.Email,
                user.Password,
                user.ConfirmPassword,
                user.PasswordHint,
                user.Role
            );

            if (errorMessages.Any())
            {
                MessageBox.Show(string.Join("\n", errorMessages), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call user service to register the user
            var userService = new UserService();
            if (userService.Register(user))
            {
                MessageBox.Show($"Successfully registered as {user.Role}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearRegistrationForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Help to Valid Email
        private static bool IsValidEmail(string email)
        {
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }
        //Help to Valid Password
        private static bool IsValidPassword(string password)
        {
            var passwordRegex = new System.Text.RegularExpressions.Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$");
            return passwordRegex.IsMatch(password);

        }


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
            if (password.Length < 6) errorMessages.Add("Password must be require at least one digit, one uppercase letter, and one special character)");
            if (password != confirmPassword) errorMessages.Add("Password and Confirm Password must match.");

            // Validate password hint
            if (string.IsNullOrEmpty(passwordHint)) errorMessages.Add("Password hint cannot be empty.");

            // Validate role
            if (string.IsNullOrEmpty(role)) errorMessages.Add("Please select a role (Patient or Technician).");

            return errorMessages;
        }
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
            rdoPatient.Checked= false;
            rdoTechnician.Checked = false;
            picUploadImage.Image = null; // Reset profile picture
        }
    }

}
