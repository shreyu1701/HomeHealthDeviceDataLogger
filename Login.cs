using Home_Health_Device_Data_Logger.HandleUser;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Home_Health_Device_Data_Logger
{
    public partial class Login : Form
    {
        private HandleUser.User user;

        public Login()
        {
            InitializeComponent();

        }

        //Signup Button
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            //Sign Up GUI
            Signup signup = new Signup();
            signup.Show();
            Visible = false;

        }


        //Forget Password

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = ShowInputDialog("Enter your email:", "Forgot Password");

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load the user data from the JSON file
            List<HandleUser.User> users = HandleUser.User.LoadUsersFromFile();
            HandleUser.User foundUser = users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (foundUser != null)
            {
                // Display the password hint
                MessageBox.Show($"Password Hint: {foundUser.PasswordHint}", "Password Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ask if the user would like to reset their password
                DialogResult result = MessageBox.Show("Would you like to reset your password?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter your new password:", "Reset Password", "");

                    if (string.IsNullOrEmpty(newPassword))
                    {
                        MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (newPassword.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the password and save it
                    foundUser.Password = newPassword;
                    HandleUser.User.SaveUsersToFile(users); // Save all users, including the updated password
                    MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // If no user is found, show an error
                MessageBox.Show("No user found with this email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to show input dialog (implement as needed for your application)
        private string ShowInputDialog(string prompt, string title)
        {
            // Implementation of input dialog (can use a custom form or similar)
            return Microsoft.VisualBasic.Interaction.InputBox(prompt, title, "");
        }



    


    ////Show Dialog for Forget Password
    //private string ShowInputDialog(string text, string caption)
    //    {
    //        Form prompt = new Form()
    //        {
    //            Width = 300,
    //            Height = 150,
    //            Text = caption,
    //            StartPosition = FormStartPosition.CenterScreen
    //        };

    //        Label lblText = new Label() { Left = 10, Top = 20, Text = text };
    //        TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 250 };
    //        Button submitButton = new Button() { Text = "Submit", Left = 190, Width = 75, Top = 80 };

    //        submitButton.Click += (sender, e) => { prompt.Close(); };

    //        prompt.Controls.Add(lblText);
    //        prompt.Controls.Add(inputBox);
    //        prompt.Controls.Add(submitButton);

    //        prompt.ShowDialog();

    //        return inputBox.Text;
    //    }



        private void btnLogin_Click(object sender, EventArgs e)
        {


            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var loggedInUser = HandleUser.User.Login(email, password);

            // Basic validation for empty fields
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password field cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Placeholder login validation logic

            if (loggedInUser != null)
            {
                // Check the user's role and open the corresponding dashboard
                if (loggedInUser.Role.Equals("Patient", StringComparison.OrdinalIgnoreCase))
                {
                    Patient patientDashboard = new Patient(user);
                    patientDashboard.Show();
                    this.Hide();
                }
                else if (loggedInUser.Role.Equals("Technician", StringComparison.OrdinalIgnoreCase))
                {
                    Technician technicianDashboard = new Technician(user);
                    technicianDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            // Basic email format validation using regular expressions
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return emailRegex.IsMatch(email);
        }

        private bool IsValidPassword(string password)
        {
            // Simple password validation for minimum length
            return password.Length >= 6;
        }

    }
}
