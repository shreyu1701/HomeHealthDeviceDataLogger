namespace Home_Health_Device_Data_Logger
{
    partial class PatientAddHealthData
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
            grpAddHealthData = new GroupBox();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            txtOxygenLevel = new TextBox();
            txtHeartRate = new TextBox();
            txtSugarLevel = new TextBox();
            txtBloodPressure = new TextBox();
            chkBoxOxygenLevel = new CheckBox();
            chkBoxHeartRate = new CheckBox();
            chkBoxSugarLevel = new CheckBox();
            chkBoxBloodPressure = new CheckBox();
            grpAddHealthData.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddHealthData
            // 
            grpAddHealthData.Controls.Add(btnCancel);
            grpAddHealthData.Controls.Add(dateTimePicker1);
            grpAddHealthData.Controls.Add(btnSave);
            grpAddHealthData.Controls.Add(txtOxygenLevel);
            grpAddHealthData.Controls.Add(txtHeartRate);
            grpAddHealthData.Controls.Add(txtSugarLevel);
            grpAddHealthData.Controls.Add(txtBloodPressure);
            grpAddHealthData.Controls.Add(chkBoxOxygenLevel);
            grpAddHealthData.Controls.Add(chkBoxHeartRate);
            grpAddHealthData.Controls.Add(chkBoxSugarLevel);
            grpAddHealthData.Controls.Add(chkBoxBloodPressure);
            grpAddHealthData.Location = new Point(162, 77);
            grpAddHealthData.Name = "grpAddHealthData";
            grpAddHealthData.Size = new Size(467, 284);
            grpAddHealthData.TabIndex = 0;
            grpAddHealthData.TabStop = false;
            grpAddHealthData.Text = "Add Health Data";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.HotTrack;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(232, 239);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(126, 239);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtOxygenLevel
            // 
            txtOxygenLevel.Location = new Point(307, 184);
            txtOxygenLevel.Name = "txtOxygenLevel";
            txtOxygenLevel.Size = new Size(139, 23);
            txtOxygenLevel.TabIndex = 8;
            // 
            // txtHeartRate
            // 
            txtHeartRate.Location = new Point(307, 152);
            txtHeartRate.Name = "txtHeartRate";
            txtHeartRate.Size = new Size(137, 23);
            txtHeartRate.TabIndex = 7;
            // 
            // txtSugarLevel
            // 
            txtSugarLevel.Location = new Point(307, 119);
            txtSugarLevel.Name = "txtSugarLevel";
            txtSugarLevel.Size = new Size(137, 23);
            txtSugarLevel.TabIndex = 6;
            // 
            // txtBloodPressure
            // 
            txtBloodPressure.Location = new Point(306, 86);
            txtBloodPressure.Name = "txtBloodPressure";
            txtBloodPressure.Size = new Size(138, 23);
            txtBloodPressure.TabIndex = 4;
            // 
            // chkBoxOxygenLevel
            // 
            chkBoxOxygenLevel.AutoSize = true;
            chkBoxOxygenLevel.Location = new Point(19, 186);
            chkBoxOxygenLevel.Name = "chkBoxOxygenLevel";
            chkBoxOxygenLevel.Size = new Size(97, 19);
            chkBoxOxygenLevel.TabIndex = 3;
            chkBoxOxygenLevel.Text = "Oxygen Level";
            chkBoxOxygenLevel.UseVisualStyleBackColor = true;
            // 
            // chkBoxHeartRate
            // 
            chkBoxHeartRate.AutoSize = true;
            chkBoxHeartRate.Location = new Point(19, 152);
            chkBoxHeartRate.Name = "chkBoxHeartRate";
            chkBoxHeartRate.Size = new Size(81, 19);
            chkBoxHeartRate.TabIndex = 2;
            chkBoxHeartRate.Text = "Heart Rate";
            chkBoxHeartRate.UseVisualStyleBackColor = true;
            // 
            // chkBoxSugarLevel
            // 
            chkBoxSugarLevel.AutoSize = true;
            chkBoxSugarLevel.Location = new Point(18, 119);
            chkBoxSugarLevel.Name = "chkBoxSugarLevel";
            chkBoxSugarLevel.Size = new Size(86, 19);
            chkBoxSugarLevel.TabIndex = 1;
            chkBoxSugarLevel.Text = "Sugar Level";
            chkBoxSugarLevel.UseVisualStyleBackColor = true;
            // 
            // chkBoxBloodPressure
            // 
            chkBoxBloodPressure.AutoSize = true;
            chkBoxBloodPressure.Location = new Point(19, 87);
            chkBoxBloodPressure.Name = "chkBoxBloodPressure";
            chkBoxBloodPressure.Size = new Size(104, 19);
            chkBoxBloodPressure.TabIndex = 0;
            chkBoxBloodPressure.Text = "Blood Pressure";
            chkBoxBloodPressure.UseVisualStyleBackColor = true;
            // 
            // PatientAddHealthData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAddHealthData);
            Name = "PatientAddHealthData";
            Text = "AddHealthData";
            grpAddHealthData.ResumeLayout(false);
            grpAddHealthData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddHealthData;
        private TextBox txtBloodPressure;
        private CheckBox chkBoxOxygenLevel;
        private CheckBox chkBoxHeartRate;
        private CheckBox chkBoxSugarLevel;
        private CheckBox chkBoxBloodPressure;
        private TextBox txtOxygenLevel;
        private TextBox txtHeartRate;
        private TextBox txtSugarLevel;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Button btnCancel;
    }
}