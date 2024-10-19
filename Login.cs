using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Home_Health_Device_Data_Logger
{
    public partial class Login : Form
    {
        private List<User> Users;



        public Login()
        {
            InitializeComponent();
            Users = new List<User>();

           Users.Add(new User("Alice", "Smith", "30", "Female", "O+", "alice@example.com", "Password123", "Password123", "Hint for Alice", "Patient", ""));
           Users.Add(new User("Bob", "Johnson", "45", "Male", "A-", "bob@example.com", "Password456", "Password456", "Hint for Bob", "Technician", ""));

        }

        //Signup Button
        private void btnSignup_Click(object sender, EventArgs e)
        {
            //Sign Up GUI
            Signup signup = new Signup();
            signup.Show();
            Visible = false;

        }


        //Forget Password

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = ShowInputDialog("Please enter your email:", "Forgot Password");
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User foundUser = Users.FirstOrDefault(u => u.Email == email);

            // Validate the entered email
            if (foundUser != null)
            {
                // Logic to send a password reset link (this would typically involve backend services)
                MessageBox.Show($"Password Hint: {foundUser.PasswordHint}","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show("Would you like to reset your password?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string newPassword = Interaction.InputBox("Enter your new password:", "Reset Password", "");

                    if (string.IsNullOrEmpty(newPassword))
                    {
                        MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate the new password (e.g., minimum length)
                    if (newPassword.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the user's password
                    foundUser.Password = newPassword;
                    MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // If the email is invalid, show an error message
                MessageBox.Show("No user found with this email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //Show Dialog for Forget Password
        private string ShowInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblText = new Label() { Left = 10, Top = 20, Text = text };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 250 };
            Button submitButton = new Button() { Text = "Submit", Left = 190, Width = 75, Top = 80 };

            submitButton.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(lblText);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(submitButton);

            prompt.ShowDialog();

            return inputBox.Text;
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();


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
            User loggedInUser = Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (loggedInUser != null)
            {
                // Check the user's role and open the corresponding dashboard
                if (loggedInUser.Role == "Patient")
                {
                    Patient patientDashboard = new Patient();
                    patientDashboard.Show();
                }
                else if (loggedInUser.Role == "Technician")
                {
                    Technician technicianDashboard = new Technician();
                    technicianDashboard.Show();
                }

                // Optionally close the login form
                this.Hide(); // Hides the login form
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
