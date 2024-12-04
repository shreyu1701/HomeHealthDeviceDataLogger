namespace Home_Health_Device_Data_Logger
{
    partial class TechnicianAddHealthData
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
            cmbPatientName = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            lblLowPressure = new Label();
            lblHighPressure = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            grpAddHealthData.Controls.Add(cmbPatientName);
            grpAddHealthData.Controls.Add(label1);
            grpAddHealthData.Controls.Add(dateTimePicker1);
            grpAddHealthData.Controls.Add(btnSave);
            grpAddHealthData.Controls.Add(lblLowPressure);
            grpAddHealthData.Controls.Add(lblHighPressure);
            grpAddHealthData.Controls.Add(textBox5);
            grpAddHealthData.Controls.Add(textBox4);
            grpAddHealthData.Controls.Add(textBox3);
            grpAddHealthData.Controls.Add(textBox2);
            grpAddHealthData.Controls.Add(textBox1);
            grpAddHealthData.Controls.Add(chkBoxOxygenLevel);
            grpAddHealthData.Controls.Add(chkBoxHeartRate);
            grpAddHealthData.Controls.Add(chkBoxSugarLevel);
            grpAddHealthData.Controls.Add(chkBoxBloodPressure);
            grpAddHealthData.Location = new Point(167, 83);
            grpAddHealthData.Name = "grpAddHealthData";
            grpAddHealthData.Size = new Size(467, 342);
            grpAddHealthData.TabIndex = 1;
            grpAddHealthData.TabStop = false;
            grpAddHealthData.Text = "Add Health Data";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Location = new Point(18, 224);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(72, 15);
            lblComments.TabIndex = 16;
            lblComments.Text = "Comments :";
            // 
            // richTxtComments
            // 
            richTxtComments.Location = new Point(102, 221);
            richTxtComments.Name = "richTxtComments";
            richTxtComments.Size = new Size(344, 70);
            richTxtComments.TabIndex = 15;
            richTxtComments.Text = "";
            // 
            // cmbPatientName
            // 
            cmbPatientName.FormattingEnabled = true;
            cmbPatientName.Location = new Point(108, 26);
            cmbPatientName.Name = "cmbPatientName";
            cmbPatientName.Size = new Size(121, 23);
            cmbPatientName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 13;
            label1.Text = "Patient Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(246, 25);
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
            btnSave.Location = new Point(192, 297);
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
            lblLowPressure.Size = new Size(29, 15);
            lblLowPressure.TabIndex = 10;
            lblLowPressure.Text = "Low";
            // 
            // lblHighPressure
            // 
            lblHighPressure.AutoSize = true;
            lblHighPressure.Location = new Point(316, 56);
            lblHighPressure.Name = "lblHighPressure";
            lblHighPressure.Size = new Size(33, 15);
            lblHighPressure.TabIndex = 9;
            lblHighPressure.Text = "High";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(307, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(307, 152);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(307, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 23);
            textBox1.TabIndex = 4;
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
            // TechnicianAddHealthData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpAddHealthData);
            Name = "TechnicianAddHealthData";
            Text = "TechnicianAddHealthData";
            grpAddHealthData.ResumeLayout(false);
            grpAddHealthData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAddHealthData;
        private TextBox txtPatientName;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Label lblLowPressure;
        private Label lblHighPressure;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox chkBoxOxygenLevel;
        private CheckBox chkBoxHeartRate;
        private CheckBox chkBoxSugarLevel;
        private CheckBox chkBoxBloodPressure;
        private ComboBox cmbPatientName;
        private Label lblComments;
        private RichTextBox richTxtComments;
    }
}