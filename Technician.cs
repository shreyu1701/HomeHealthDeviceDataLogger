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
        public Technician()
        {
            InitializeComponent();
        }

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
    }
}
