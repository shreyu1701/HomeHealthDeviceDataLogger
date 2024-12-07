namespace Home_Health_Device_Data_Logger.Views
{
    partial class UpdateHealthDataTechnicianForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBloodPressure = new Label();
            lblSugarLevel = new Label();
            lblHeartRate = new Label();
            lblOxygenLevel = new Label();
            txtSystolic = new TextBox();
            txtDiastolic = new TextBox();
            txtSugarLevel = new TextBox();
            txtHeartRate = new TextBox();
            txtOxygenLevel = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Location = new Point(14, 58);
            lblBloodPressure.Margin = new Padding(4, 0, 4, 0);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new Size(82, 15);
            lblBloodPressure.TabIndex = 1;
            lblBloodPressure.Text = "BloodPressure";
            // 
            // lblSugarLevel
            // 
            lblSugarLevel.AutoSize = true;
            lblSugarLevel.Location = new Point(14, 98);
            lblSugarLevel.Margin = new Padding(4, 0, 4, 0);
            lblSugarLevel.Name = "lblSugarLevel";
            lblSugarLevel.Size = new Size(67, 15);
            lblSugarLevel.TabIndex = 2;
            lblSugarLevel.Text = "Sugar Level";
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Location = new Point(14, 138);
            lblHeartRate.Margin = new Padding(4, 0, 4, 0);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(62, 15);
            lblHeartRate.TabIndex = 3;
            lblHeartRate.Text = "Heart Rate";
            // 
            // lblOxygenLevel
            // 
            lblOxygenLevel.AutoSize = true;
            lblOxygenLevel.Location = new Point(14, 179);
            lblOxygenLevel.Margin = new Padding(4, 0, 4, 0);
            lblOxygenLevel.Name = "lblOxygenLevel";
            lblOxygenLevel.Size = new Size(78, 15);
            lblOxygenLevel.TabIndex = 4;
            lblOxygenLevel.Text = "Oxygen Level";
            // 
            // txtSystolic
            // 
            txtSystolic.Location = new Point(128, 55);
            txtSystolic.Margin = new Padding(4, 3, 4, 3);
            txtSystolic.Name = "txtSystolic";
            txtSystolic.Size = new Size(68, 23);
            txtSystolic.TabIndex = 5;
            // 
            // txtDiastolic
            // 
            txtDiastolic.Location = new Point(227, 55);
            txtDiastolic.Margin = new Padding(4, 3, 4, 3);
            txtDiastolic.Name = "txtDiastolic";
            txtDiastolic.Size = new Size(75, 23);
            txtDiastolic.TabIndex = 6;
            // 
            // txtSugarLevel
            // 
            txtSugarLevel.Location = new Point(128, 95);
            txtSugarLevel.Margin = new Padding(4, 3, 4, 3);
            txtSugarLevel.Name = "txtSugarLevel";
            txtSugarLevel.Size = new Size(174, 23);
            txtSugarLevel.TabIndex = 7;
            // 
            // txtHeartRate
            // 
            txtHeartRate.Location = new Point(128, 135);
            txtHeartRate.Margin = new Padding(4, 3, 4, 3);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.Size = new Size(174, 23);
            txtHeartRate.TabIndex = 8;
            // 
            // txtOxygenLevel
            // 
            txtOxygenLevel.Location = new Point(128, 175);
            txtOxygenLevel.Margin = new Padding(4, 3, 4, 3);
            txtOxygenLevel.Name = "txtOxygenLevel";
            txtOxygenLevel.Size = new Size(174, 23);
            txtOxygenLevel.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 219);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 27);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // UpdateHealthDataTechnicianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 267);
            Controls.Add(btnSave);
            Controls.Add(txtOxygenLevel);
            Controls.Add(txtHeartRate);
            Controls.Add(txtSugarLevel);
            Controls.Add(txtDiastolic);
            Controls.Add(txtSystolic);
            Controls.Add(lblOxygenLevel);
            Controls.Add(lblHeartRate);
            Controls.Add(lblSugarLevel);
            Controls.Add(lblBloodPressure);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateHealthDataTechnicianForm";
            Text = "Update Health Data";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSystolic;
        private System.Windows.Forms.Label lblDiastolic;
        private System.Windows.Forms.Label lblSugarLevel;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.Label lblOxygenLevel;
        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtDiastolic;
        private System.Windows.Forms.TextBox txtSugarLevel;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtOxygenLevel;
        private System.Windows.Forms.Button btnSave;
        private Label lblBloodPressure;
    }
}