namespace Home_Health_Device_Data_Logger
{
    partial class Signup
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
            lblSignUp = new Label();
            lblFirstName = new Label();
            lblAge = new Label();
            lblBloodGroup = new Label();
            lblEmail = new Label();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            grpGender = new GroupBox();
            rdoOther = new RadioButton();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtEmail = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            grpRole = new GroupBox();
            rdoTechnician = new RadioButton();
            rdoPatient = new RadioButton();
            btnSignup = new Button();
            lblPasswordHint = new Label();
            txtPasswordHint = new TextBox();
            picUploadImage = new PictureBox();
            btnUploadImage = new Button();
            cmbBloodGroup = new ComboBox();
            grpGender.SuspendLayout();
            grpRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUploadImage).BeginInit();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.DodgerBlue;
            lblSignUp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = Color.White;
            lblSignUp.Location = new Point(350, 9);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(117, 37);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "Sign Up";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(49, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "&First Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(49, 127);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "&Age";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(49, 156);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(74, 15);
            lblBloodGroup.TabIndex = 4;
            lblBloodGroup.Text = "&Blood Group";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(527, 62);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "&E-mail";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(527, 130);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "&Confirm Password";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(528, 97);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Pass&word";
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoOther);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(49, 187);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(106, 100);
            grpGender.TabIndex = 8;
            grpGender.TabStop = false;
            grpGender.Text = "&Gender";
            // 
            // rdoOther
            // 
            rdoOther.Location = new Point(15, 70);
            rdoOther.Name = "rdoOther";
            rdoOther.Size = new Size(85, 24);
            rdoOther.TabIndex = 0;
            rdoOther.Text = "&Others";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(15, 48);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "&Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(16, 23);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "&Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(49, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "&Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(162, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "John";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(162, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Doe";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(162, 124);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "25";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(632, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(156, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(632, 127);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "********";
            txtConfirmPassword.Size = new Size(156, 23);
            txtConfirmPassword.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(632, 94);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(156, 23);
            txtPassword.TabIndex = 15;
            // 
            // grpRole
            // 
            grpRole.Controls.Add(rdoTechnician);
            grpRole.Controls.Add(rdoPatient);
            grpRole.Location = new Point(527, 187);
            grpRole.Name = "grpRole";
            grpRole.Size = new Size(261, 100);
            grpRole.TabIndex = 16;
            grpRole.TabStop = false;
            grpRole.Text = "Role";
            // 
            // rdoTechnician
            // 
            rdoTechnician.AutoSize = true;
            rdoTechnician.Location = new Point(20, 59);
            rdoTechnician.Name = "rdoTechnician";
            rdoTechnician.Size = new Size(81, 19);
            rdoTechnician.TabIndex = 1;
            rdoTechnician.Text = "&Technician";
            rdoTechnician.UseVisualStyleBackColor = true;
            // 
            // rdoPatient
            // 
            rdoPatient.AutoSize = true;
            rdoPatient.Checked = true;
            rdoPatient.Location = new Point(18, 23);
            rdoPatient.Name = "rdoPatient";
            rdoPatient.Size = new Size(62, 19);
            rdoPatient.TabIndex = 0;
            rdoPatient.TabStop = true;
            rdoPatient.Text = "&Patient";
            rdoPatient.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.HotTrack;
            btnSignup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ButtonFace;
            btnSignup.Location = new Point(346, 379);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(119, 33);
            btnSignup.TabIndex = 17;
            btnSignup.Text = "Submit";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.AutoSize = true;
            lblPasswordHint.Location = new Point(528, 159);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new Size(83, 15);
            lblPasswordHint.TabIndex = 18;
            lblPasswordHint.Text = "Password &Hint";
            // 
            // txtPasswordHint
            // 
            txtPasswordHint.Location = new Point(632, 156);
            txtPasswordHint.Name = "txtPasswordHint";
            txtPasswordHint.PlaceholderText = "Birth Date, Car Number, etc";
            txtPasswordHint.Size = new Size(156, 23);
            txtPasswordHint.TabIndex = 19;
            // 
            // picUploadImage
            // 
            picUploadImage.Image = Properties.Resources.images;
            picUploadImage.Location = new Point(294, 56);
            picUploadImage.Name = "picUploadImage";
            picUploadImage.Size = new Size(225, 225);
            picUploadImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picUploadImage.TabIndex = 20;
            picUploadImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = SystemColors.HotTrack;
            btnUploadImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadImage.ForeColor = SystemColors.ButtonFace;
            btnUploadImage.Location = new Point(346, 290);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(119, 35);
            btnUploadImage.TabIndex = 21;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.Location = new Point(162, 159);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(100, 23);
            cmbBloodGroup.TabIndex = 22;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBloodGroup);
            Controls.Add(btnUploadImage);
            Controls.Add(picUploadImage);
            Controls.Add(txtPasswordHint);
            Controls.Add(lblPasswordHint);
            Controls.Add(btnSignup);
            Controls.Add(grpRole);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(grpGender);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblBloodGroup);
            Controls.Add(lblAge);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblSignUp);
            MinimizeBox = false;
            Name = "Signup";
            Text = "signup";
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            grpRole.ResumeLayout(false);
            grpRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUploadImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUp;
        private Label lblFirstName;
        private Label lblAge;
        private Label lblBloodGroup;
        private Label lblEmail;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private GroupBox grpGender;
        private RadioButton rdoOther;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtEmail;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private GroupBox grpRole;
        private RadioButton rdoPatient;
        private RadioButton rdoTechnician;
        private Button btnSignup;
        private Label lblPasswordHint;
        private TextBox txtPasswordHint;
        private PictureBox picUploadImage;
        private Button btnUploadImage;
        private ComboBox cmbBloodGroup;
    }
}