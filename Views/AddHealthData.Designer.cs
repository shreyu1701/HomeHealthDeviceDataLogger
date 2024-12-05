namespace Home_Health_Device_Data_Logger
{
    partial class AddHealthData
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
            lblComments = new Label();
            richTxtComments = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            lblLowPressure = new Label();
            lblHighPressure = new Label();
            txtOxygenLevel = new TextBox();
            txtHeartRate = new TextBox();
            txtSugarLevel = new TextBox();
            txtDiastolic = new TextBox();
            txtSystolic = new TextBox();
            chkBoxOxygenLevel = new CheckBox();
            chkBoxHeartRate = new CheckBox();
            chkBoxSugarLevel = new CheckBox();
            chkBoxBloodPressure = new CheckBox();
            grpAddHealthData.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddHealthData
            // 
            grpAddHealthData.Controls.Add(lblComments);
            grpAddHealthData.Controls.Add(richTxtComments);
            grpAddHealthData.Controls.Add(dateTimePicker1);
            grpAddHealthData.Controls.Add(btnSave);
            grpAddHealthData.Controls.Add(lblLowPressure);
            grpAddHealthData.Controls.Add(lblHighPressure);
            grpAddHealthData.Controls.Add(txtOxygenLevel);
            grpAddHealthData.Controls.Add(txtHeartRate);
            grpAddHealthData.Controls.Add(txtSugarLevel);
            grpAddHealthData.Controls.Add(txtDiastolic);
            grpAddHealthData.Controls.Add(txtSystolic);
            grpAddHealthData.Controls.Add(chkBoxOxygenLevel);
            grpAddHealthData.Controls.Add(chkBoxHeartRate);
            grpAddHealthData.Controls.Add(chkBoxSugarLevel);
            grpAddHealthData.Controls.Add(chkBoxBloodPressure);
            grpAddHealthData.Location = new Point(162, 77);
            grpAddHealthData.Name = "grpAddHealthData";
            grpAddHealthData.Size = new Size(467, 344);
            grpAddHealthData.TabIndex = 0;
            grpAddHealthData.TabStop = false;
            grpAddHealthData.Text = "Add Health Data";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Location = new Point(19, 237);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(72, 15);
            lblComments.TabIndex = 14;
            lblComments.Text = "Comments :";
            // 
            // richTxtComments
            // 
            richTxtComments.Location = new Point(113, 237);
            richTxtComments.Name = "richTxtComments";
            richTxtComments.Size = new Size(333, 64);
            richTxtComments.TabIndex = 13;
            richTxtComments.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(194, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblLowPressure
            // 
            lblLowPressure.AutoSize = true;
            lblLowPressure.Location = new Point(402, 56);
            lblLowPressure.Name = "lblLowPressure";
            lblLowPressure.Size = new Size(52, 15);
            lblLowPressure.TabIndex = 10;
            lblLowPressure.Text = "Diastolic";
            // 
            // lblHighPressure
            // 
            lblHighPressure.AutoSize = true;
            lblHighPressure.Location = new Point(316, 56);
            lblHighPressure.Name = "lblHighPressure";
            lblHighPressure.Size = new Size(47, 15);
            lblHighPressure.TabIndex = 9;
            lblHighPressure.Text = "Systolic";
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
            // txtDiastolic
            // 
            txtDiastolic.Location = new Point(392, 86);
            txtDiastolic.Name = "txtDiastolic";
            txtDiastolic.Size = new Size(52, 23);
            txtDiastolic.TabIndex = 5;
            // 
            // txtSystolic
            // 
            txtSystolic.Location = new Point(306, 86);
            txtSystolic.Name = "txtSystolic";
            txtSystolic.Size = new Size(52, 23);
            txtSystolic.TabIndex = 4;
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
            chkBoxOxygenLevel.CheckedChanged += chkBoxOxygenLevel_CheckedChanged;
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
            chkBoxHeartRate.CheckedChanged += chkBoxHeartRate_CheckedChanged;
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
            chkBoxSugarLevel.CheckedChanged += chkBoxSugarLevel_CheckedChanged;
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
            chkBoxBloodPressure.CheckedChanged += chkBoxBloodPressure_CheckedChanged;
            // 
            // AddHealthData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAddHealthData);
            Name = "AddHealthData";
            Text = "AddHealthData";
            grpAddHealthData.ResumeLayout(false);
            grpAddHealthData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddHealthData;
        private TextBox txtSystolic;
        private CheckBox chkBoxOxygenLevel;
        private CheckBox chkBoxHeartRate;
        private CheckBox chkBoxSugarLevel;
        private CheckBox chkBoxBloodPressure;
        private Label lblLowPressure;
        private Label lblHighPressure;
        private TextBox txtOxygenLevel;
        private TextBox txtHeartRate;
        private TextBox txtSugarLevel;
        private TextBox txtDiastolic;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private Label lblComments;
        private RichTextBox richTxtComments;
    }
}