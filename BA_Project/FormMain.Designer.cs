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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtRecordName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridRecords = new System.Windows.Forms.DataGridView();
            this.gpPasswordGenerator = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.gpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).BeginInit();
            this.gpPasswordGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordGeneratorToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // passwordGeneratorToolStripMenuItem
            // 
            this.passwordGeneratorToolStripMenuItem.Name = "passwordGeneratorToolStripMenuItem";
            this.passwordGeneratorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.passwordGeneratorToolStripMenuItem.Text = "Password Generator";
            // 
            // gpAdd
            // 
            this.gpAdd.Controls.Add(this.btnAdd);
            this.gpAdd.Controls.Add(this.txtPassword);
            this.gpAdd.Controls.Add(this.txtMail);
            this.gpAdd.Controls.Add(this.txtURL);
            this.gpAdd.Controls.Add(this.txtRecordName);
            this.gpAdd.Controls.Add(this.label4);
            this.gpAdd.Controls.Add(this.label3);
            this.gpAdd.Controls.Add(this.label2);
            this.gpAdd.Controls.Add(this.label1);
            this.gpAdd.Location = new System.Drawing.Point(718, 27);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(250, 191);
            this.gpAdd.TabIndex = 2;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Add Record";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(92, 94);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 23);
            this.txtMail.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(92, 65);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(152, 23);
            this.txtURL.TabIndex = 1;
            // 
            // txtRecordName
            // 
            this.txtRecordName.Location = new System.Drawing.Point(92, 36);
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.Size = new System.Drawing.Size(152, 23);
            this.txtRecordName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
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
            this.dataGridRecords.Size = new System.Drawing.Size(700, 410);
            this.dataGridRecords.TabIndex = 4;
            // 
            // gpPasswordGenerator
            // 
            this.gpPasswordGenerator.Controls.Add(this.label6);
            this.gpPasswordGenerator.Controls.Add(this.cbNumbers);
            this.gpPasswordGenerator.Controls.Add(this.cbSymbols);
            this.gpPasswordGenerator.Controls.Add(this.label5);
            this.gpPasswordGenerator.Controls.Add(this.nudPasswordLength);
            this.gpPasswordGenerator.Controls.Add(this.btnCopyToClipboard);
            this.gpPasswordGenerator.Controls.Add(this.btnGeneratePassword);
            this.gpPasswordGenerator.Controls.Add(this.txtGeneratedPassword);
            this.gpPasswordGenerator.Location = new System.Drawing.Point(718, 224);
            this.gpPasswordGenerator.Name = "gpPasswordGenerator";
            this.gpPasswordGenerator.Size = new System.Drawing.Size(250, 213);
            this.gpPasswordGenerator.TabIndex = 5;
            this.gpPasswordGenerator.TabStop = false;
            this.gpPasswordGenerator.Text = "Password Generator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Include";
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Location = new System.Drawing.Point(70, 33);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(75, 19);
            this.cbNumbers.TabIndex = 6;
            this.cbNumbers.Text = "Numbers";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(151, 33);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(71, 19);
            this.cbSymbols.TabIndex = 6;
            this.cbSymbols.Text = "Symbols";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password Length";
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Location = new System.Drawing.Point(121, 71);
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(110, 23);
            this.nudPasswordLength.TabIndex = 2;
            this.nudPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(18, 143);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(213, 23);
            this.btnGeneratePassword.TabIndex = 1;
            this.btnGeneratePassword.Text = "Generate";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Location = new System.Drawing.Point(18, 114);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.ReadOnly = true;
            this.txtGeneratedPassword.Size = new System.Drawing.Size(213, 23);
            this.txtGeneratedPassword.TabIndex = 0;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(18, 172);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(213, 23);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 444);
            this.Controls.Add(this.gpPasswordGenerator);
            this.Controls.Add(this.dataGridRecords);
            this.Controls.Add(this.gpAdd);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyVault";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRecords)).EndInit();
            this.gpPasswordGenerator.ResumeLayout(false);
            this.gpPasswordGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem toolToolStripMenuItem;
        private ToolStripMenuItem passwordGeneratorToolStripMenuItem;
        private GroupBox gpAdd;
        private TextBox txtPassword;
        private TextBox txtMail;
        private TextBox txtURL;
        private TextBox txtRecordName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private DataGridView dataGridRecords;
        private GroupBox gpPasswordGenerator;
        private TextBox txtGeneratedPassword;
        private Button btnGeneratePassword;
        private Label label5;
        private NumericUpDown nudPasswordLength;
        private Label label6;
        private CheckBox cbNumbers;
        private CheckBox cbSymbols;
        private Button btnCopyToClipboard;
    }
}