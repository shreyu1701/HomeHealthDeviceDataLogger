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
        public Login()
        {
            InitializeComponent();
        }

        //Signup Button
        private void button2_Click(object sender, EventArgs e)
        {
            //Sign Up GUI
            signup s = new signup();
            s.Show();
            Visible = false;

        }

        //Submit Button
        private void button1_Click(object sender, EventArgs e)
        {

            //IF you want to change to GUI comment on Patient/Technician


            Technician technician = new Technician();
            technician.Show();
            Visible = false;

            //Patient patient = new Patient();
            //patient.Show();
            //Visible = false;

        }

        //Forget Password

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = ShowInputDialog("Please enter your email:", "Forgot Password");

            // Validate the entered email
            if (!string.IsNullOrEmpty(email) && IsValidEmail(email))
            {
                // Logic to send a password reset link (this would typically involve backend services)
                MessageBox.Show("A password reset link has been sent to: " + email, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If the email is invalid, show an error message
                MessageBox.Show("Invalid email address. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //Email valid 
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }


        //Show Dialog
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
    }
}
