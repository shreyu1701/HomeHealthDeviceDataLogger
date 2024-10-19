namespace Home_Health_Device_Data_Logger
{
    partial class Login
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
            lblLogin = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            linkForgetPassword = new LinkLabel();
            btnLogin = new Button();
            label4 = new Label();
            btnSignUp = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.DodgerBlue;
            lblLogin.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(356, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(91, 37);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(277, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E&mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(277, 205);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "&Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(277, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(241, 29);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(280, 236);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "*********";
            txtPassword.Size = new Size(238, 29);
            txtPassword.TabIndex = 4;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Location = new Point(419, 275);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(99, 15);
            linkForgetPassword.TabIndex = 5;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "For&get Password?";
            linkForgetPassword.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(357, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(85, 30);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += new EventHandler(btnLogin_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 409);
            label4.Name = "label4";
            label4.Size = new Size(378, 15);
            label4.TabIndex = 7;
            label4.Text = "@Copyright 2024 , Humber College, Toronto , ON . All Right Reversed  ";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.HotTrack;
            btnSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.ButtonFace;
            btnSignUp.Location = new Point(359, 372);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(79, 25);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign &Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += new EventHandler(btnSignup_Click);
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(275, 94);
            lblError.Name = "lblError";
            lblError.Size = new Size(36, 15);
            lblError.TabIndex = 9;
            lblError.Text = "Note:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnSignUp);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(linkForgetPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private LinkLabel linkForgetPassword;
        private Button btnLogin;
        private Label label4;
        private Button btnSignUp;
        private Label lblError;
    }
}