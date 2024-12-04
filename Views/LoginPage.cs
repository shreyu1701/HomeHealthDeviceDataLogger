using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Health_Device_Data_Logger.Views
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loggedInUser = UserDataAccess.Login(email, password);
            if (loggedInUser != null)
            {
                MessageBox.Show($"Welcome {loggedInUser.FirstName} {loggedInUser.LastName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to role-specific dashboard
                if (loggedInUser.Role.Trim().ToLower() == "patient") // Normalize and compare role
                {
                    UserSession.CurrentUserID = loggedInUser.UserID;
                    Patient patient = new Patient(loggedInUser);
                    patient.Show();
                    this.Hide(); // Close login form
                }
                else if (loggedInUser.Role.Trim().ToLower() == "technician") // Normalize and compare role
                {
                    UserSession.CurrentUserID = loggedInUser.UserID;
                    Technician technician = new Technician(loggedInUser);
                    technician.Show();
                    this.Hide(); // Close login form
                }
                else
                {
                    MessageBox.Show("Role not recognized.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();   
            forgotPasswordForm.ShowDialog();

        }
    }
}
