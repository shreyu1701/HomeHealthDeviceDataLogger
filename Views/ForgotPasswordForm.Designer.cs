namespace Home_Health_Device_Data_Logger.Views
{
    partial class ForgotPasswordForm
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
            txtEmail = new TextBox();
            btnRetrieve = new Button();
            lblHint = new Label();
            btnCancel = new Button();
            lblForgetPassword = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(10, 122);
            txtEmail.Margin = new Padding(1, 2, 1, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter  your  Email";
            txtEmail.Size = new Size(258, 23);
            txtEmail.TabIndex = 0;
            // 
            // btnRetrieve
            // 
            btnRetrieve.Location = new Point(10, 242);
            btnRetrieve.Margin = new Padding(1, 2, 1, 2);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(112, 50);
            btnRetrieve.TabIndex = 1;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = true;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(10, 182);
            lblHint.Margin = new Padding(1, 0, 1, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(86, 15);
            lblHint.TabIndex = 2;
            lblHint.Text = "Password Hint:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(153, 242);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 50);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblForgetPassword.Location = new Point(49, 27);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(171, 30);
            lblForgetPassword.TabIndex = 4;
            lblForgetPassword.Text = "Forget Password";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 338);
            Controls.Add(lblForgetPassword);
            Controls.Add(btnCancel);
            Controls.Add(lblHint);
            Controls.Add(btnRetrieve);
            Controls.Add(txtEmail);
            Margin = new Padding(1, 2, 1, 2);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnRetrieve;
        private Label lblHint;
        private Button btnCancel;
        private Label lblForgetPassword;
    }
}