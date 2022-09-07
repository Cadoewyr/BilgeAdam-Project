namespace BA_Project
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtRecordName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.gbPasswordGenerator = new System.Windows.Forms.GroupBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.gbPasswordGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.txtUsername);
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txtPassword);
            this.gbAdd.Controls.Add(this.txtEMail);
            this.gbAdd.Controls.Add(this.txtURL);
            this.gbAdd.Controls.Add(this.txtRecordName);
            this.gbAdd.Controls.Add(this.label4);
            this.gbAdd.Controls.Add(this.label8);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Location = new System.Drawing.Point(718, 27);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(250, 220);
            this.gbAdd.TabIndex = 2;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Record";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(103, 123);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(128, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(103, 94);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(128, 23);
            this.txtEMail.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(103, 65);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(128, 23);
            this.txtURL.TabIndex = 1;
            // 
            // txtRecordName
            // 
            this.txtRecordName.Location = new System.Drawing.Point(103, 36);
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.Size = new System.Drawing.Size(128, 23);
            this.txtRecordName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record Name";
            // 
            // dataGridRecords
            // 
            this.dataGridRecords.AllowUserToAddRows = false;
            this.dataGridRecords.AllowUserToDeleteRows = false;
            this.dataGridRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRecords.Location = new System.Drawing.Point(12, 27);
            this.dataGridRecords.MultiSelect = false;
            this.dataGridRecords.Name = "dataGridRecords";
            this.dataGridRecords.RowTemplate.Height = 25;
            this.dataGridRecords.Size = new System.Drawing.Size(700, 512);
            this.dataGridRecords.TabIndex = 12;
            this.dataGridRecords.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRecords_CellValueChanged);
            this.dataGridRecords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridRecords_KeyDown);
            // 
            // gbPasswordGenerator
            // 
            this.gbPasswordGenerator.Controls.Add(this.cbNumbers);
            this.gbPasswordGenerator.Controls.Add(this.cbSymbols);
            this.gbPasswordGenerator.Controls.Add(this.label6);
            this.gbPasswordGenerator.Controls.Add(this.label5);
            this.gbPasswordGenerator.Controls.Add(this.nudPasswordLength);
            this.gbPasswordGenerator.Controls.Add(this.btnCopyToClipboard);
            this.gbPasswordGenerator.Controls.Add(this.btnGeneratePassword);
            this.gbPasswordGenerator.Controls.Add(this.txtGeneratedPassword);
            this.gbPasswordGenerator.Location = new System.Drawing.Point(718, 253);
            this.gbPasswordGenerator.Name = "gbPasswordGenerator";
            this.gbPasswordGenerator.Size = new System.Drawing.Size(250, 213);
            this.gbPasswordGenerator.TabIndex = 5;
            this.gbPasswordGenerator.TabStop = false;
            this.gbPasswordGenerator.Text = "Password Generator";
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(121, 61);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(75, 19);
            this.cbNumbers.TabIndex = 7;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(121, 86);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(71, 19);
            this.cbSymbols.TabIndex = 8;
            this.cbSymbols.Text = "Symbols";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Including";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password Length";
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Location = new System.Drawing.Point(121, 32);
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(110, 23);
            this.nudPasswordLength.TabIndex = 6;
            this.nudPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(18, 174);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(213, 23);
            this.btnCopyToClipboard.TabIndex = 11;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(18, 145);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(213, 23);
            this.btnGeneratePassword.TabIndex = 10;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(18, 116);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.ReadOnly = true;
            this.txtGeneratedPassword.Size = new System.Drawing.Size(213, 23);
            this.txtGeneratedPassword.TabIndex = 9;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.label7);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Location = new System.Drawing.Point(718, 472);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(250, 67);
            this.gbFilter.TabIndex = 6;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Record Name";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(103, 28);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(128, 23);
            this.txtFilter.TabIndex = 12;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 546);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbPasswordGenerator);
            this.Controls.Add(this.dataGridRecords);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyVault";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.gbPasswordGenerator.ResumeLayout(false);
            this.gbPasswordGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private GroupBox gbAdd;
        private TextBox txtPassword;
        private TextBox txtEMail;
        private TextBox txtURL;
        private TextBox txtRecordName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private DataGridView dataGridRecords;
        private GroupBox gbPasswordGenerator;
        private TextBox txtGeneratedPassword;
        private Button btnGeneratePassword;
        private Label label5;
        private NumericUpDown nudPasswordLength;
        private CheckBox cbNumbers;
        private CheckBox cbSymbols;
        private Button btnCopyToClipboard;
        private Label label6;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private GroupBox gbFilter;
        private Label label7;
        private TextBox txtFilter;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private TextBox txtUsername;
        private Label label8;
    }
}