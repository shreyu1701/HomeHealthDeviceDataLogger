namespace Home_Health_Device_Data_Logger
{
    partial class signup
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
            lblConfirmEmail = new Label();
            lblPassword = new Label();
            grpGender = new GroupBox();
            rdoOthers = new RadioButton();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtBloodGroup = new TextBox();
            txtEmail = new TextBox();
            txtConfirmEmail = new TextBox();
            txtPassword = new TextBox();
            grpRole = new GroupBox();
            rdoTechnician = new RadioButton();
            rdoPatient = new RadioButton();
            btnSubmit = new Button();
            lblPasswordHint = new Label();
            txtPasswordHint = new TextBox();
            picUploadImage = new PictureBox();
            btnUploadImage = new Button();
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
            lblFirstName.Location = new Point(48, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "&First Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(52, 120);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "&Age";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(38, 266);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(74, 15);
            lblBloodGroup.TabIndex = 4;
            lblBloodGroup.Text = "&Blood Group";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(527, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "&E-mail";
            // 
            // lblConfirmEmail
            // 
            lblConfirmEmail.AutoSize = true;
            lblConfirmEmail.Location = new Point(527, 89);
            lblConfirmEmail.Name = "lblConfirmEmail";
            lblConfirmEmail.Size = new Size(88, 15);
            lblConfirmEmail.TabIndex = 6;
            lblConfirmEmail.Text = "&Confirm E-mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(527, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Pass&word";
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoOthers);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(49, 149);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(106, 100);
            grpGender.TabIndex = 8;
            grpGender.TabStop = false;
            grpGender.Text = "&Gender";
            // 
            // rdoOthers
            // 
            rdoOthers.Location = new Point(15, 70);
            rdoOthers.Name = "rdoOthers";
            rdoOthers.Size = new Size(85, 24);
            rdoOthers.TabIndex = 0;
            rdoOthers.Text = "&Others";
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
            lblLastName.Location = new Point(49, 89);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "&Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(160, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "John";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(161, 92);
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
            // txtBloodGroup
            // 
            txtBloodGroup.Location = new Point(158, 264);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.PlaceholderText = "O +ve";
            txtBloodGroup.Size = new Size(100, 23);
            txtBloodGroup.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(620, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(157, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtConfirmEmail
            // 
            txtConfirmEmail.Location = new Point(621, 86);
            txtConfirmEmail.Name = "txtConfirmEmail";
            txtConfirmEmail.PlaceholderText = "example@gmail.com";
            txtConfirmEmail.Size = new Size(156, 23);
            txtConfirmEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(623, 117);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(154, 23);
            txtPassword.TabIndex = 15;
            // 
            // grpRole
            // 
            grpRole.Controls.Add(rdoTechnician);
            grpRole.Controls.Add(rdoPatient);
            grpRole.Location = new Point(527, 187);
            grpRole.Name = "grpRole";
            grpRole.Size = new Size(200, 100);
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
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.HotTrack;
            btnSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonFace;
            btnSubmit.Location = new Point(346, 379);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(119, 33);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // lblPasswordHint
            // 
            lblPasswordHint.AutoSize = true;
            lblPasswordHint.Location = new Point(527, 153);
            lblPasswordHint.Name = "lblPasswordHint";
            lblPasswordHint.Size = new Size(83, 15);
            lblPasswordHint.TabIndex = 18;
            lblPasswordHint.Text = "Password &Hint";
            // 
            // txtPasswordHint
            // 
            txtPasswordHint.Location = new Point(624, 150);
            txtPasswordHint.Name = "txtPasswordHint";
            txtPasswordHint.PlaceholderText = "Birth Date, Car Number, etc";
            txtPasswordHint.Size = new Size(153, 23);
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
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUploadImage);
            Controls.Add(picUploadImage);
            Controls.Add(txtPasswordHint);
            Controls.Add(lblPasswordHint);
            Controls.Add(btnSubmit);
            Controls.Add(grpRole);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(grpGender);
            Controls.Add(lblPassword);
            Controls.Add(lblConfirmEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblBloodGroup);
            Controls.Add(lblAge);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblSignUp);
            Name = "signup";
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
        private Label lblConfirmEmail;
        private Label lblPassword;
        private GroupBox grpGender;
        private RadioButton rdoOthers;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtBloodGroup;
        private TextBox txtEmail;
        private TextBox txtConfirmEmail;
        private TextBox txtPassword;
        private GroupBox grpRole;
        private RadioButton rdoPatient;
        private RadioButton rdoTechnician;
        private Button btnSubmit;
        private Label lblPasswordHint;
        private TextBox txtPasswordHint;
        private PictureBox picUploadImage;
        private Button btnUploadImage;
    }
}