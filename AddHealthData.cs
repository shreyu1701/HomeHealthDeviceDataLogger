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
    public partial class AddHealthData : Form
    {
        public AddHealthData()
        {
            InitializeComponent();
        }

        private void chkBoxHeartRate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Health Data Added into System", "Add Health Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
