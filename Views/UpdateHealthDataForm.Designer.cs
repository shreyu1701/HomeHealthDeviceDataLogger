namespace Home_Health_Device_Data_Logger.Views
{
    partial class UpdateHealthDataForm
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
            txtSystolic = new TextBox();
            txtSugarLevel = new TextBox();
            txtHeartRate = new TextBox();
            txtOxygenLevel = new TextBox();
            lblBloodPressure = new Label();
            lblSugarLevel = new Label();
            lblHeartRate = new Label();
            lblOxygenLevel = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtDiastolic = new TextBox();
            lblSystolic = new Label();
            lblDiastolic = new Label();
            SuspendLayout();
            // 
            // txtSystolic
            // 
            txtSystolic.Location = new Point(207, 113);
            txtSystolic.Name = "txtSystolic";
            txtSystolic.Size = new Size(97, 23);
            txtSystolic.TabIndex = 0;
            // 
            // txtSugarLevel
            // 
            txtSugarLevel.Location = new Point(207, 153);
            txtSugarLevel.Name = "txtSugarLevel";
            txtSugarLevel.Size = new Size(200, 23);
            txtSugarLevel.TabIndex = 1;
            // 
            // txtHeartRate
            // 
            txtHeartRate.Location = new Point(207, 193);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.Size = new Size(200, 23);
            txtHeartRate.TabIndex = 2;
            // 
            // txtOxygenLevel
            // 
            txtOxygenLevel.Location = new Point(207, 233);
            txtOxygenLevel.Name = "txtOxygenLevel";
            txtOxygenLevel.Size = new Size(200, 23);
            txtOxygenLevel.TabIndex = 3;
            // 
            // lblBloodPressure
            // 
            lblBloodPressure.AutoSize = true;
            lblBloodPressure.Location = new Point(107, 116);
            lblBloodPressure.Name = "lblBloodPressure";
            lblBloodPressure.Size = new Size(88, 15);
            lblBloodPressure.TabIndex = 4;
            lblBloodPressure.Text = "Blood Pressure:";
            // 
            // lblSugarLevel
            // 
            lblSugarLevel.AutoSize = true;
            lblSugarLevel.Location = new Point(107, 156);
            lblSugarLevel.Name = "lblSugarLevel";
            lblSugarLevel.Size = new Size(70, 15);
            lblSugarLevel.TabIndex = 5;
            lblSugarLevel.Text = "Sugar Level:";
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Location = new Point(107, 196);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(65, 15);
            lblHeartRate.TabIndex = 6;
            lblHeartRate.Text = "Heart Rate:";
            // 
            // lblOxygenLevel
            // 
            lblOxygenLevel.AutoSize = true;
            lblOxygenLevel.Location = new Point(107, 236);
            lblOxygenLevel.Name = "lblOxygenLevel";
            lblOxygenLevel.Size = new Size(81, 15);
            lblOxygenLevel.TabIndex = 7;
            lblOxygenLevel.Text = "Oxygen Level:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(207, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(332, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtDiastolic
            // 
            txtDiastolic.Location = new Point(310, 113);
            txtDiastolic.Name = "txtDiastolic";
            txtDiastolic.Size = new Size(97, 23);
            txtDiastolic.TabIndex = 10;
            // 
            // lblSystolic
            // 
            lblSystolic.AutoSize = true;
            lblSystolic.Location = new Point(222, 87);
            lblSystolic.Name = "lblSystolic";
            lblSystolic.Size = new Size(47, 15);
            lblSystolic.TabIndex = 11;
            lblSystolic.Text = "Systolic";
            // 
            // lblDiastolic
            // 
            lblDiastolic.AutoSize = true;
            lblDiastolic.Location = new Point(332, 87);
            lblDiastolic.Name = "lblDiastolic";
            lblDiastolic.Size = new Size(52, 15);
            lblDiastolic.TabIndex = 12;
            lblDiastolic.Text = "Diastolic";
            // 
            // UpdateHealthDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            Controls.Add(lblDiastolic);
            Controls.Add(lblSystolic);
            Controls.Add(txtDiastolic);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblOxygenLevel);
            Controls.Add(lblHeartRate);
            Controls.Add(lblSugarLevel);
            Controls.Add(lblBloodPressure);
            Controls.Add(txtOxygenLevel);
            Controls.Add(txtHeartRate);
            Controls.Add(txtSugarLevel);
            Controls.Add(txtSystolic);
            Name = "UpdateHealthDataForm";
            Text = "Update Health Data";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox txtSystolic;
        private System.Windows.Forms.TextBox txtSugarLevel;
        private System.Windows.Forms.TextBox txtHeartRate;
        private System.Windows.Forms.TextBox txtOxygenLevel;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.Label lblSugarLevel;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.Label lblOxygenLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private TextBox txtDiastolic;
        private Label lblSystolic;
        private Label lblDiastolic;
    }
}