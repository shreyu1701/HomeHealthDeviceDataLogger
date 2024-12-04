
using Home_Health_Device_Data_Logger.Data;
using Home_Health_Device_Data_Logger.Models;
using Home_Health_Device_Data_Logger.Views;

namespace Home_Health_Device_Data_Logger
{
    public partial class Patient : Form
    {
        private User _user;
        private User LoggedInUser;

        public Patient(User user)
        {
            InitializeComponent();
            _user = user;
            LoggedInUser = user;
            LoadHealthData();
        }

        //Logout Button
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You are Logout from System", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginPage login = new LoginPage();
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


        private void LoadHealthData()
        {
            var healthData = HealthDataAccess.GetHealthDataByUserId(LoggedInUser.UserID);
            dataGridView1.DataSource = healthData;
        }
        //Personal Save Button
        private void btnPersonalSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personal Information  Save in System", "Peronal Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            AddHealthData addHealthData = new AddHealthData();
            addHealthData.Show();
            Visible= true;
        }
    }
}
