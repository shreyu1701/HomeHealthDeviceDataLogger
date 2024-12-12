namespace Home_Health_Device_Data_Logger
{
    partial class Technician
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRefresh = new Button();
            btnAddPatient = new Button();
            btnTechnicianAddHealthData = new Button();
            dataGridViewTechnicianDashboard = new DataGridView();
            tabPage2 = new TabPage();
            btnFilter = new Button();
            lblHistoryTo = new Label();
            lblHistoryFrom = new Label();
            dateTimePickerHistoryFrom = new DateTimePicker();
            txtID = new TextBox();
            dataGridViewTechnicianHistory = new DataGridView();
            dateTimePickerHistoryTo = new DateTimePicker();
            tabPage3 = new TabPage();
            btnSearchByName = new Button();
            label1 = new Label();
            cmbPatientNames = new ComboBox();
            lblChartsTo = new Label();
            lblChartsFrom = new Label();
            dateTimePickerChartsFrom = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitContainer3 = new SplitContainer();
            tabControl2 = new TabControl();
            tabPage5 = new TabPage();
            chtBloodPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage6 = new TabPage();
            chtSugarLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage7 = new TabPage();
            chtHeartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage8 = new TabPage();
            chtOxygenLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnDownload = new Button();
            grpDownload = new GroupBox();
            rdoPDF = new RadioButton();
            rdoExcel = new RadioButton();
            lblTechnicianGenerateTo = new Label();
            dateTimePickerTechnicianGenerateTo = new DateTimePicker();
            dateTimePickerTechnicianGenerateFrom = new DateTimePicker();
            lblTechnicianGenerateFrom = new Label();
            lblTechnicianGeneReport = new Label();
            dateTimePickerChartsTo = new DateTimePicker();
            tabPage4 = new TabPage();
            panel1 = new Panel();
            tabControlProfile = new TabControl();
            tabPage13 = new TabPage();
            btnPersonalSave = new Button();
            btnPersonalEdit = new Button();
            btnUploadImage = new Button();
            label23 = new Label();
            label22 = new Label();
            label50 = new Label();
            btnLogout = new Button();
            lblBlood = new Label();
            lblBloodGroup = new Label();
            lblGenderOption = new Label();
            lblGender = new Label();
            lblAgeNumber = new Label();
            lblAge = new Label();
            lblFullName = new Label();
            lblName = new Label();
            picProfilePic = new PictureBox();
            LFirstName = new Label();
            LLastname = new Label();
            LUserID = new Label();
            label4 = new Label();
            LPassword = new Label();
            LEmail = new Label();
            txtPasswordHint = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            cmbBloodGroup = new ComboBox();
            cmbGender = new ComboBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblUserID = new Label();
            LAge = new Label();
            LBloodGroup = new Label();
            LGender = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnicianDashboard).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnicianHistory).BeginInit();
            tabPage3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtBloodPressure).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtSugarLevel).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtHeartRate).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtOxygenLevel).BeginInit();
            grpDownload.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            tabControlProfile.SuspendLayout();
            tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfilePic).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(252, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(749, 553);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(btnAddPatient);
            tabPage1.Controls.Add(btnTechnicianAddHealthData);
            tabPage1.Controls.Add(dataGridViewTechnicianDashboard);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(741, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.HotTrack;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ButtonFace;
            btnRefresh.Location = new Point(418, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(148, 33);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = SystemColors.Highlight;
            btnAddPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPatient.ForeColor = SystemColors.Control;
            btnAddPatient.Location = new Point(6, 6);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(124, 33);
            btnAddPatient.TabIndex = 7;
            btnAddPatient.Text = "Add Patient";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnTechnicianAddHealthData
            // 
            btnTechnicianAddHealthData.BackColor = SystemColors.HotTrack;
            btnTechnicianAddHealthData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTechnicianAddHealthData.ForeColor = SystemColors.ButtonFace;
            btnTechnicianAddHealthData.Location = new Point(584, 4);
            btnTechnicianAddHealthData.Name = "btnTechnicianAddHealthData";
            btnTechnicianAddHealthData.Size = new Size(148, 33);
            btnTechnicianAddHealthData.TabIndex = 0;
            btnTechnicianAddHealthData.Text = "Add Health &Data";
            btnTechnicianAddHealthData.UseVisualStyleBackColor = false;
            btnTechnicianAddHealthData.Click += btnTechnicianAddHealthData_Click;
            // 
            // dataGridViewTechnicianDashboard
            // 
            dataGridViewTechnicianDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTechnicianDashboard.Location = new Point(3, 45);
            dataGridViewTechnicianDashboard.Name = "dataGridViewTechnicianDashboard";
            dataGridViewTechnicianDashboard.Size = new Size(732, 477);
            dataGridViewTechnicianDashboard.TabIndex = 6;
            dataGridViewTechnicianDashboard.CellContentClick += DataGridViewTechnicianDashboard_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnFilter);
            tabPage2.Controls.Add(lblHistoryTo);
            tabPage2.Controls.Add(lblHistoryFrom);
            tabPage2.Controls.Add(dateTimePickerHistoryFrom);
            tabPage2.Controls.Add(txtID);
            tabPage2.Controls.Add(dataGridViewTechnicianHistory);
            tabPage2.Controls.Add(dateTimePickerHistoryTo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(741, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "History";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = SystemColors.HotTrack;
            btnFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = SystemColors.Control;
            btnFilter.Location = new Point(657, 19);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 32);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblHistoryTo
            // 
            lblHistoryTo.AutoSize = true;
            lblHistoryTo.Location = new Point(446, 4);
            lblHistoryTo.Name = "lblHistoryTo";
            lblHistoryTo.Size = new Size(25, 15);
            lblHistoryTo.TabIndex = 18;
            lblHistoryTo.Text = "&To :";
            // 
            // lblHistoryFrom
            // 
            lblHistoryFrom.AutoSize = true;
            lblHistoryFrom.Location = new Point(235, 4);
            lblHistoryFrom.Name = "lblHistoryFrom";
            lblHistoryFrom.Size = new Size(41, 15);
            lblHistoryFrom.TabIndex = 17;
            lblHistoryFrom.Text = "&From :";
            // 
            // dateTimePickerHistoryFrom
            // 
            dateTimePickerHistoryFrom.Location = new Point(235, 23);
            dateTimePickerHistoryFrom.Name = "dateTimePickerHistoryFrom";
            dateTimePickerHistoryFrom.Size = new Size(191, 23);
            dateTimePickerHistoryFrom.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(9, 23);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Search #ID";
            txtID.Size = new Size(195, 23);
            txtID.TabIndex = 15;
            // 
            // dataGridViewTechnicianHistory
            // 
            dataGridViewTechnicianHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTechnicianHistory.Location = new Point(9, 71);
            dataGridViewTechnicianHistory.Name = "dataGridViewTechnicianHistory";
            dataGridViewTechnicianHistory.Size = new Size(726, 448);
            dataGridViewTechnicianHistory.TabIndex = 7;
            dataGridViewTechnicianHistory.CellContentClick += dataGridViewTechnicianHistory_CellContentClick;
            // 
            // dateTimePickerHistoryTo
            // 
            dateTimePickerHistoryTo.Location = new Point(446, 22);
            dateTimePickerHistoryTo.Name = "dateTimePickerHistoryTo";
            dateTimePickerHistoryTo.Size = new Size(198, 23);
            dateTimePickerHistoryTo.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSearchByName);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(cmbPatientNames);
            tabPage3.Controls.Add(lblChartsTo);
            tabPage3.Controls.Add(lblChartsFrom);
            tabPage3.Controls.Add(dateTimePickerChartsFrom);
            tabPage3.Controls.Add(flowLayoutPanel1);
            tabPage3.Controls.Add(dateTimePickerChartsTo);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(741, 525);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Charts & Reports";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchByName
            // 
            btnSearchByName.BackColor = SystemColors.HotTrack;
            btnSearchByName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchByName.ForeColor = SystemColors.Control;
            btnSearchByName.Location = new Point(613, 21);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(109, 38);
            btnSearchByName.TabIndex = 23;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = false;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 22;
            label1.Text = "Patient Name:";
            // 
            // cmbPatientNames
            // 
            cmbPatientNames.FormattingEnabled = true;
            cmbPatientNames.Location = new Point(6, 29);
            cmbPatientNames.Name = "cmbPatientNames";
            cmbPatientNames.Size = new Size(145, 23);
            cmbPatientNames.TabIndex = 21;
            // 
            // lblChartsTo
            // 
            lblChartsTo.AutoSize = true;
            lblChartsTo.Location = new Point(380, 11);
            lblChartsTo.Name = "lblChartsTo";
            lblChartsTo.Size = new Size(25, 15);
            lblChartsTo.TabIndex = 20;
            lblChartsTo.Text = "&To :";
            // 
            // lblChartsFrom
            // 
            lblChartsFrom.AutoSize = true;
            lblChartsFrom.Location = new Point(160, 11);
            lblChartsFrom.Name = "lblChartsFrom";
            lblChartsFrom.Size = new Size(41, 15);
            lblChartsFrom.TabIndex = 19;
            lblChartsFrom.Text = "&From :";
            // 
            // dateTimePickerChartsFrom
            // 
            dateTimePickerChartsFrom.Location = new Point(160, 29);
            dateTimePickerChartsFrom.Name = "dateTimePickerChartsFrom";
            dateTimePickerChartsFrom.Size = new Size(208, 23);
            dateTimePickerChartsFrom.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(splitContainer3);
            flowLayoutPanel1.Location = new Point(3, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(735, 452);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tabControl2);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnDownload);
            splitContainer3.Panel2.Controls.Add(grpDownload);
            splitContainer3.Panel2.Controls.Add(lblTechnicianGenerateTo);
            splitContainer3.Panel2.Controls.Add(dateTimePickerTechnicianGenerateTo);
            splitContainer3.Panel2.Controls.Add(dateTimePickerTechnicianGenerateFrom);
            splitContainer3.Panel2.Controls.Add(lblTechnicianGenerateFrom);
            splitContainer3.Panel2.Controls.Add(lblTechnicianGeneReport);
            splitContainer3.Size = new Size(732, 449);
            splitContainer3.SplitterDistance = 507;
            splitContainer3.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(501, 443);
            tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(chtBloodPressure);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(493, 415);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Blood Pressure";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // chtBloodPressure
            // 
            chtBloodPressure.Location = new Point(19, 18);
            chtBloodPressure.Name = "chtBloodPressure";
            chtBloodPressure.Size = new Size(449, 369);
            chtBloodPressure.TabIndex = 0;
            chtBloodPressure.Text = "Blood Pressure";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(chtSugarLevel);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(493, 415);
            tabPage6.TabIndex = 1;
            tabPage6.Text = "Sugar Level";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // chtSugarLevel
            // 
            chtSugarLevel.Location = new Point(22, 25);
            chtSugarLevel.Name = "chtSugarLevel";
            chtSugarLevel.Size = new Size(453, 376);
            chtSugarLevel.TabIndex = 1;
            chtSugarLevel.Text = "Sugar Level";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(chtHeartRate);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(493, 415);
            tabPage7.TabIndex = 2;
            tabPage7.Text = "Heart Rate";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // chtHeartRate
            // 
            chtHeartRate.Location = new Point(3, 15);
            chtHeartRate.Name = "chtHeartRate";
            chtHeartRate.Size = new Size(487, 386);
            chtHeartRate.TabIndex = 1;
            chtHeartRate.Text = "Heart Rate";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(chtOxygenLevel);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(493, 415);
            tabPage8.TabIndex = 3;
            tabPage8.Text = "Oxygen Level";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // chtOxygenLevel
            // 
            chtOxygenLevel.Location = new Point(21, 25);
            chtOxygenLevel.Name = "chtOxygenLevel";
            chtOxygenLevel.Size = new Size(447, 376);
            chtOxygenLevel.TabIndex = 1;
            chtOxygenLevel.Text = "Oxygen Level";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = SystemColors.HotTrack;
            btnDownload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = SystemColors.ButtonFace;
            btnDownload.Location = new Point(55, 337);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(111, 42);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // grpDownload
            // 
            grpDownload.Controls.Add(rdoPDF);
            grpDownload.Controls.Add(rdoExcel);
            grpDownload.Location = new Point(5, 182);
            grpDownload.Name = "grpDownload";
            grpDownload.Size = new Size(200, 83);
            grpDownload.TabIndex = 5;
            grpDownload.TabStop = false;
            grpDownload.Text = "Download As :";
            // 
            // rdoPDF
            // 
            rdoPDF.AutoSize = true;
            rdoPDF.Location = new Point(22, 58);
            rdoPDF.Name = "rdoPDF";
            rdoPDF.Size = new Size(46, 19);
            rdoPDF.TabIndex = 1;
            rdoPDF.Text = "PDF";
            rdoPDF.UseVisualStyleBackColor = true;
            // 
            // rdoExcel
            // 
            rdoExcel.AutoSize = true;
            rdoExcel.Checked = true;
            rdoExcel.Location = new Point(21, 29);
            rdoExcel.Name = "rdoExcel";
            rdoExcel.Size = new Size(52, 19);
            rdoExcel.TabIndex = 0;
            rdoExcel.TabStop = true;
            rdoExcel.Text = "Excel";
            rdoExcel.UseVisualStyleBackColor = true;
            // 
            // lblTechnicianGenerateTo
            // 
            lblTechnicianGenerateTo.AutoSize = true;
            lblTechnicianGenerateTo.Location = new Point(5, 109);
            lblTechnicianGenerateTo.Name = "lblTechnicianGenerateTo";
            lblTechnicianGenerateTo.Size = new Size(19, 15);
            lblTechnicianGenerateTo.TabIndex = 4;
            lblTechnicianGenerateTo.Text = "To";
            // 
            // dateTimePickerTechnicianGenerateTo
            // 
            dateTimePickerTechnicianGenerateTo.Location = new Point(5, 125);
            dateTimePickerTechnicianGenerateTo.Name = "dateTimePickerTechnicianGenerateTo";
            dateTimePickerTechnicianGenerateTo.Size = new Size(200, 23);
            dateTimePickerTechnicianGenerateTo.TabIndex = 3;
            // 
            // dateTimePickerTechnicianGenerateFrom
            // 
            dateTimePickerTechnicianGenerateFrom.Location = new Point(5, 68);
            dateTimePickerTechnicianGenerateFrom.Name = "dateTimePickerTechnicianGenerateFrom";
            dateTimePickerTechnicianGenerateFrom.Size = new Size(200, 23);
            dateTimePickerTechnicianGenerateFrom.TabIndex = 2;
            // 
            // lblTechnicianGenerateFrom
            // 
            lblTechnicianGenerateFrom.AutoSize = true;
            lblTechnicianGenerateFrom.Location = new Point(5, 50);
            lblTechnicianGenerateFrom.Name = "lblTechnicianGenerateFrom";
            lblTechnicianGenerateFrom.Size = new Size(35, 15);
            lblTechnicianGenerateFrom.TabIndex = 1;
            lblTechnicianGenerateFrom.Text = "From";
            // 
            // lblTechnicianGeneReport
            // 
            lblTechnicianGeneReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTechnicianGeneReport.Location = new Point(37, 7);
            lblTechnicianGeneReport.Name = "lblTechnicianGeneReport";
            lblTechnicianGeneReport.Size = new Size(151, 23);
            lblTechnicianGeneReport.TabIndex = 0;
            lblTechnicianGeneReport.Text = "Generate Reports";
            // 
            // dateTimePickerChartsTo
            // 
            dateTimePickerChartsTo.Location = new Point(380, 29);
            dateTimePickerChartsTo.Name = "dateTimePickerChartsTo";
            dateTimePickerChartsTo.Size = new Size(210, 23);
            dateTimePickerChartsTo.TabIndex = 14;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(741, 525);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Profile";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlProfile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 525);
            panel1.TabIndex = 0;
            // 
            // tabControlProfile
            // 
            tabControlProfile.Controls.Add(tabPage13);
            tabControlProfile.Location = new Point(3, 3);
            tabControlProfile.Name = "tabControlProfile";
            tabControlProfile.SelectedIndex = 0;
            tabControlProfile.Size = new Size(735, 519);
            tabControlProfile.TabIndex = 0;
            // 
            // tabPage13
            // 
            tabPage13.Controls.Add(LFirstName);
            tabPage13.Controls.Add(LLastname);
            tabPage13.Controls.Add(LUserID);
            tabPage13.Controls.Add(label4);
            tabPage13.Controls.Add(LPassword);
            tabPage13.Controls.Add(LEmail);
            tabPage13.Controls.Add(txtPasswordHint);
            tabPage13.Controls.Add(txtPassword);
            tabPage13.Controls.Add(txtEmail);
            tabPage13.Controls.Add(cmbBloodGroup);
            tabPage13.Controls.Add(cmbGender);
            tabPage13.Controls.Add(txtAge);
            tabPage13.Controls.Add(txtLastName);
            tabPage13.Controls.Add(txtFirstName);
            tabPage13.Controls.Add(lblUserID);
            tabPage13.Controls.Add(LAge);
            tabPage13.Controls.Add(LBloodGroup);
            tabPage13.Controls.Add(LGender);
            tabPage13.Controls.Add(btnPersonalSave);
            tabPage13.Controls.Add(btnPersonalEdit);
            tabPage13.Controls.Add(btnUploadImage);
            tabPage13.Controls.Add(label23);
            tabPage13.Controls.Add(label22);
            tabPage13.Font = new Font("Segoe UI", 11.25F);
            tabPage13.Location = new Point(4, 24);
            tabPage13.Name = "tabPage13";
            tabPage13.Padding = new Padding(3);
            tabPage13.Size = new Size(727, 491);
            tabPage13.TabIndex = 0;
            tabPage13.Text = "Personal Information";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // btnPersonalSave
            // 
            btnPersonalSave.BackColor = SystemColors.HotTrack;
            btnPersonalSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersonalSave.ForeColor = SystemColors.ButtonFace;
            btnPersonalSave.Location = new Point(579, 421);
            btnPersonalSave.Name = "btnPersonalSave";
            btnPersonalSave.Size = new Size(78, 29);
            btnPersonalSave.TabIndex = 17;
            btnPersonalSave.Text = "Save";
            btnPersonalSave.UseVisualStyleBackColor = false;
            // 
            // btnPersonalEdit
            // 
            btnPersonalEdit.BackColor = SystemColors.HotTrack;
            btnPersonalEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPersonalEdit.ForeColor = SystemColors.ButtonFace;
            btnPersonalEdit.Location = new Point(408, 421);
            btnPersonalEdit.Name = "btnPersonalEdit";
            btnPersonalEdit.Size = new Size(76, 29);
            btnPersonalEdit.TabIndex = 16;
            btnPersonalEdit.Text = "Edit";
            btnPersonalEdit.UseVisualStyleBackColor = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = SystemColors.HotTrack;
            btnUploadImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadImage.ForeColor = SystemColors.ButtonFace;
            btnUploadImage.Location = new Point(579, 23);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(115, 35);
            btnUploadImage.TabIndex = 8;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label23
            // 
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(100, 23);
            label23.TabIndex = 12;
            // 
            // label22
            // 
            label22.Location = new Point(0, 0);
            label22.Name = "label22";
            label22.Size = new Size(100, 23);
            label22.TabIndex = 13;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label50.Location = new Point(78, 10);
            label50.Name = "label50";
            label50.Size = new Size(116, 30);
            label50.TabIndex = 21;
            label50.Text = "Technician";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.HotTrack;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(67, 484);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 43);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Lo&gout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button1_Click;
            // 
            // lblBlood
            // 
            lblBlood.AutoSize = true;
            lblBlood.Location = new Point(95, 399);
            lblBlood.Name = "lblBlood";
            lblBlood.Size = new Size(30, 15);
            lblBlood.TabIndex = 19;
            lblBlood.Text = "AB+";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(9, 399);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(80, 15);
            lblBloodGroup.TabIndex = 18;
            lblBloodGroup.Text = "&Blood Group :";
            // 
            // lblGenderOption
            // 
            lblGenderOption.AutoSize = true;
            lblGenderOption.Location = new Point(95, 355);
            lblGenderOption.Name = "lblGenderOption";
            lblGenderOption.Size = new Size(33, 15);
            lblGenderOption.TabIndex = 17;
            lblGenderOption.Text = "Male";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(9, 355);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 16;
            lblGender.Text = "&Gender :";
            // 
            // lblAgeNumber
            // 
            lblAgeNumber.AutoSize = true;
            lblAgeNumber.Location = new Point(95, 318);
            lblAgeNumber.Name = "lblAgeNumber";
            lblAgeNumber.Size = new Size(19, 15);
            lblAgeNumber.TabIndex = 15;
            lblAgeNumber.Text = "22";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(9, 318);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 15);
            lblAge.TabIndex = 14;
            lblAge.Text = "&Age :";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(95, 281);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(109, 15);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "Shreyansh Koladiya";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 278);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 12;
            lblName.Text = "&Name :";
            // 
            // picProfilePic
            // 
            picProfilePic.Image = Properties.Resources.images;
            picProfilePic.Location = new Point(15, 52);
            picProfilePic.Name = "picProfilePic";
            picProfilePic.Size = new Size(221, 209);
            picProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfilePic.TabIndex = 22;
            picProfilePic.TabStop = false;
            // 
            // LFirstName
            // 
            LFirstName.AutoSize = true;
            LFirstName.Location = new Point(109, 106);
            LFirstName.Name = "LFirstName";
            LFirstName.Size = new Size(83, 20);
            LFirstName.TabIndex = 53;
            LFirstName.Text = "FirstName :";
            // 
            // LLastname
            // 
            LLastname.AutoSize = true;
            LLastname.Location = new Point(106, 141);
            LLastname.Name = "LLastname";
            LLastname.Size = new Size(86, 20);
            LLastname.TabIndex = 52;
            LLastname.Text = "&Last Name :";
            // 
            // LUserID
            // 
            LUserID.AutoSize = true;
            LUserID.Location = new Point(124, 65);
            LUserID.Name = "LUserID";
            LUserID.Size = new Size(68, 20);
            LUserID.TabIndex = 51;
            LUserID.Text = "User &ID : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(84, 367);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 50;
            label4.Text = "Password &Hint :";
            // 
            // LPassword
            // 
            LPassword.AutoSize = true;
            LPassword.Font = new Font("Segoe UI", 11.25F);
            LPassword.Location = new Point(119, 318);
            LPassword.Margin = new Padding(4, 0, 4, 0);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(73, 20);
            LPassword.TabIndex = 49;
            LPassword.Text = "&Password:";
            // 
            // LEmail
            // 
            LEmail.AutoSize = true;
            LEmail.Font = new Font("Segoe UI", 11.25F);
            LEmail.Location = new Point(133, 282);
            LEmail.Margin = new Padding(4, 0, 4, 0);
            LEmail.Name = "LEmail";
            LEmail.Size = new Size(59, 20);
            LEmail.TabIndex = 48;
            LEmail.Text = "&E-mail :";
            // 
            // txtPasswordHint
            // 
            txtPasswordHint.Location = new Point(250, 364);
            txtPasswordHint.Name = "txtPasswordHint";
            txtPasswordHint.Size = new Size(121, 27);
            txtPasswordHint.TabIndex = 47;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(250, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(121, 27);
            txtPassword.TabIndex = 46;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(250, 279);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 27);
            txtEmail.TabIndex = 45;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            cmbBloodGroup.Location = new Point(250, 243);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(121, 28);
            cmbBloodGroup.TabIndex = 44;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(250, 209);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 28);
            cmbGender.TabIndex = 43;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(250, 174);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(121, 27);
            txtAge.TabIndex = 42;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(250, 138);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 27);
            txtLastName.TabIndex = 41;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(250, 99);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 27);
            txtFirstName.TabIndex = 40;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Location = new Point(250, 65);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(53, 20);
            lblUserID.TabIndex = 39;
            lblUserID.Text = "UserID";
            // 
            // LAge
            // 
            LAge.AutoSize = true;
            LAge.Location = new Point(145, 177);
            LAge.Margin = new Padding(4, 0, 4, 0);
            LAge.Name = "LAge";
            LAge.Size = new Size(47, 20);
            LAge.TabIndex = 38;
            LAge.Text = "&Age : ";
            // 
            // LBloodGroup
            // 
            LBloodGroup.AutoSize = true;
            LBloodGroup.Font = new Font("Segoe UI", 11.25F);
            LBloodGroup.Location = new Point(91, 246);
            LBloodGroup.Margin = new Padding(4, 0, 4, 0);
            LBloodGroup.Name = "LBloodGroup";
            LBloodGroup.Size = new Size(101, 20);
            LBloodGroup.TabIndex = 37;
            LBloodGroup.Text = "&Blood Group :";
            // 
            // LGender
            // 
            LGender.Font = new Font("Segoe UI", 11.25F);
            LGender.Location = new Point(124, 212);
            LGender.Margin = new Padding(4, 0, 4, 0);
            LGender.Name = "LGender";
            LGender.Size = new Size(84, 19);
            LGender.TabIndex = 36;
            LGender.Text = "&Gender :";
            // 
            // Technician
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 550);
            Controls.Add(label50);
            Controls.Add(btnLogout);
            Controls.Add(lblBlood);
            Controls.Add(lblBloodGroup);
            Controls.Add(lblGenderOption);
            Controls.Add(lblGender);
            Controls.Add(lblAgeNumber);
            Controls.Add(lblAge);
            Controls.Add(lblFullName);
            Controls.Add(lblName);
            Controls.Add(picProfilePic);
            Controls.Add(tabControl1);
            Name = "Technician";
            Text = "Technician";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnicianDashboard).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTechnicianHistory).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtBloodPressure).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtSugarLevel).EndInit();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtHeartRate).EndInit();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtOxygenLevel).EndInit();
            grpDownload.ResumeLayout(false);
            grpDownload.PerformLayout();
            tabPage4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabControlProfile.ResumeLayout(false);
            tabPage13.ResumeLayout(false);
            tabPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfilePic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnTechnicianAddHealthData;
        private DataGridView dataGridViewTechnicianDashboard;
        private TabPage tabPage2;
        private DataGridView dataGridViewTechnicianHistory;
        private DateTimePicker dateTimePickerHistoryTo;
        private TabPage tabPage3;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer3;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBloodPressure;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button btnDownload;
        private GroupBox grpDownload;
        private RadioButton rdoPDF;
        private RadioButton rdoExcel;
        private Label lblTechnicianGenerateTo;
        private DateTimePicker dateTimePickerTechnicianGenerateTo;
        private DateTimePicker dateTimePickerTechnicianGenerateFrom;
        private Label lblTechnicianGenerateFrom;
        private Label lblTechnicianGeneReport;
        private DateTimePicker dateTimePickerChartsTo;
        private TabPage tabPage4;
        private Panel panel1;
        private Label label50;
        private Button btnLogout;
        private Label lblBlood;
        private Label lblBloodGroup;
        private Label lblGenderOption;
        private Label lblGender;
        private Label lblAgeNumber;
        private Label lblAge;
        private Label lblFullName;
        private Label lblName;
        private PictureBox picProfilePic;
        private TextBox txtID;
        private TextBox txtName;
        private TabControl tabControlProfile;
        private TabPage tabPage13;
        private Button btnPersonalSave;
        private Button btnPersonalEdit;
        private Button btnUploadImage;
        private Label lblPersonalEmail;
        private Label label23;
        private Label label22;
        private Button button14;
        private TextBox textBox1;
        private Label label48;
        private Label lblHistoryTo;
        private Label lblHistoryFrom;
        private DateTimePicker dateTimePickerHistoryFrom;
        private DateTimePicker dateTimePickerChartsFrom;
        private Label lblChartsTo;
        private Label lblChartsFrom;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSugarLevel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtHeartRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtOxygenLevel;
        private Button btnAddPatient;
        private Button btnRefresh;
        private Button btnFilter;
        private Label label1;
        private ComboBox cmbPatientNames;
        private Button btnSearchByName;
        private Label LFirstName;
        private Label LLastname;
        private Label LUserID;
        private Label label4;
        private Label LPassword;
        private Label LEmail;
        private TextBox txtPasswordHint;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private ComboBox cmbBloodGroup;
        private ComboBox cmbGender;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblUserID;
        private Label LAge;
        private Label LBloodGroup;
        private Label LGender;
    }
}