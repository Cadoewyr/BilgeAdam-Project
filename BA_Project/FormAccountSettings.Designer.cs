namespace BA_Project
{
    partial class FormAccountSettings
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
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.txtNewPassword1 = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.gbChangeUsername = new System.Windows.Forms.GroupBox();
            this.btnSaveUsername = new System.Windows.Forms.Button();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.gbChangeMail = new System.Windows.Forms.GroupBox();
            this.btnSaveEMail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewEMail = new System.Windows.Forms.TextBox();
            this.txtCurrentEMail = new System.Windows.Forms.TextBox();
            this.gbChangePassword.SuspendLayout();
            this.gbChangeUsername.SuspendLayout();
            this.gbChangeMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.btnSavePassword);
            this.gbChangePassword.Controls.Add(this.label3);
            this.gbChangePassword.Controls.Add(this.label2);
            this.gbChangePassword.Controls.Add(this.label1);
            this.gbChangePassword.Controls.Add(this.txtNewPassword2);
            this.gbChangePassword.Controls.Add(this.txtNewPassword1);
            this.gbChangePassword.Controls.Add(this.txtCurrentPassword);
            this.gbChangePassword.Location = new System.Drawing.Point(12, 255);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(275, 153);
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.TabStop = false;
            this.gbChangePassword.Text = "Change Password";
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.Enabled = false;
            this.btnSavePassword.Location = new System.Drawing.Point(126, 119);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(128, 23);
            this.btnSavePassword.TabIndex = 8;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = true;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password";
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Enabled = false;
            this.txtNewPassword2.Location = new System.Drawing.Point(126, 90);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(128, 23);
            this.txtNewPassword2.TabIndex = 7;
            this.txtNewPassword2.UseSystemPasswordChar = true;
            this.txtNewPassword2.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtNewPassword1
            // 
            this.txtNewPassword1.Enabled = false;
            this.txtNewPassword1.Location = new System.Drawing.Point(126, 61);
            this.txtNewPassword1.Name = "txtNewPassword1";
            this.txtNewPassword1.Size = new System.Drawing.Size(128, 23);
            this.txtNewPassword1.TabIndex = 6;
            this.txtNewPassword1.UseSystemPasswordChar = true;
            this.txtNewPassword1.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(126, 32);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(128, 23);
            this.txtCurrentPassword.TabIndex = 5;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // gbChangeUsername
            // 
            this.gbChangeUsername.Controls.Add(this.btnSaveUsername);
            this.gbChangeUsername.Controls.Add(this.txtNewUsername);
            this.gbChangeUsername.Location = new System.Drawing.Point(12, 12);
            this.gbChangeUsername.Name = "gbChangeUsername";
            this.gbChangeUsername.Size = new System.Drawing.Size(275, 98);
            this.gbChangeUsername.TabIndex = 1;
            this.gbChangeUsername.TabStop = false;
            this.gbChangeUsername.Text = "Change Username";
            // 
            // btnSaveUsername
            // 
            this.btnSaveUsername.Enabled = false;
            this.btnSaveUsername.Location = new System.Drawing.Point(126, 63);
            this.btnSaveUsername.Name = "btnSaveUsername";
            this.btnSaveUsername.Size = new System.Drawing.Size(128, 23);
            this.btnSaveUsername.TabIndex = 1;
            this.btnSaveUsername.Text = "Save";
            this.btnSaveUsername.UseVisualStyleBackColor = true;
            this.btnSaveUsername.Click += new System.EventHandler(this.btnSaveUsername_Click);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(126, 34);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(128, 23);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Current E-Mail";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(12, 414);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(275, 23);
            this.btnDeleteAccount.TabIndex = 9;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // gbChangeMail
            // 
            this.gbChangeMail.Controls.Add(this.btnSaveEMail);
            this.gbChangeMail.Controls.Add(this.label5);
            this.gbChangeMail.Controls.Add(this.txtNewEMail);
            this.gbChangeMail.Controls.Add(this.label4);
            this.gbChangeMail.Controls.Add(this.txtCurrentEMail);
            this.gbChangeMail.Location = new System.Drawing.Point(12, 116);
            this.gbChangeMail.Name = "gbChangeMail";
            this.gbChangeMail.Size = new System.Drawing.Size(275, 133);
            this.gbChangeMail.TabIndex = 3;
            this.gbChangeMail.TabStop = false;
            this.gbChangeMail.Text = "Change Mail";
            // 
            // btnSaveEMail
            // 
            this.btnSaveEMail.Enabled = false;
            this.btnSaveEMail.Location = new System.Drawing.Point(126, 97);
            this.btnSaveEMail.Name = "btnSaveEMail";
            this.btnSaveEMail.Size = new System.Drawing.Size(128, 23);
            this.btnSaveEMail.TabIndex = 4;
            this.btnSaveEMail.Text = "Save";
            this.btnSaveEMail.UseVisualStyleBackColor = true;
            this.btnSaveEMail.Click += new System.EventHandler(this.btnSaveMail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "New E-Mail";
            // 
            // txtNewEMail
            // 
            this.txtNewEMail.Location = new System.Drawing.Point(126, 67);
            this.txtNewEMail.Name = "txtNewEMail";
            this.txtNewEMail.Size = new System.Drawing.Size(128, 23);
            this.txtNewEMail.TabIndex = 3;
            this.txtNewEMail.TextChanged += new System.EventHandler(this.txtNewEmail_TextChanged);
            // 
            // txtCurrentEMail
            // 
            this.txtCurrentEMail.Location = new System.Drawing.Point(126, 38);
            this.txtCurrentEMail.Name = "txtCurrentEMail";
            this.txtCurrentEMail.ReadOnly = true;
            this.txtCurrentEMail.Size = new System.Drawing.Size(128, 23);
            this.txtCurrentEMail.TabIndex = 2;
            this.txtCurrentEMail.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // FormAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 445);
            this.Controls.Add(this.gbChangeMail);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.gbChangeUsername);
            this.Controls.Add(this.gbChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccountSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormAccountSettings_Load);
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            this.gbChangeUsername.ResumeLayout(false);
            this.gbChangeUsername.PerformLayout();
            this.gbChangeMail.ResumeLayout(false);
            this.gbChangeMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbChangePassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNewPassword2;
        private TextBox txtNewPassword1;
        private TextBox txtCurrentPassword;
        private Button btnSavePassword;
        private GroupBox gbChangeUsername;
        private Button btnSaveUsername;
        private TextBox txtNewUsername;
        private Label label4;
        private Button btnDeleteAccount;
        private GroupBox gbChangeMail;
        private Button btnSaveEMail;
        private Label label5;
        private TextBox txtNewEMail;
        private TextBox txtCurrentEMail;
    }
}