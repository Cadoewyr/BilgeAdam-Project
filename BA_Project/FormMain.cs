﻿using BA_Project.Business.Managers;
using BA_Project.DAL.Entities;
using BA_Project.Form_Manager;

namespace BA_Project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        RecordManager rm;

        void FillDataGridView(DataGridView dataGridView, List<Record> records)
        {
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("RecordName", "Record Name");
                dataGridView.Columns.Add("URL", "URL");
                dataGridView.Columns.Add("EMail", "E-Mail");
                dataGridView.Columns.Add("Username", "Username");
                dataGridView.Columns.Add("Password", "Password");
            }

            GenericFunctions.ClearControls(dataGridView);

            foreach (Record record in records)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView, record.RecordName, record.URL, record.EMail, record.Username, record.Password);
                row.Tag = record;
                dataGridView.Rows.Add(row);
            }

            foreach (DataGridViewColumn column in dataGridRecords.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridRecords.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            if (dataGridRecords.Rows.Count > 0)
                dataGridRecords.Sort(dataGridRecords.Columns["RecordName"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += $" | {GenericFunctions.CurrentUser.Username}";
            rm = new RecordManager();

            FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID & r.RecordName.ToLower().Contains(txtFilter.Text.ToLower())));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                rm.Add(new Record()
                {
                    RecordName = txtRecordName.Text,
                    URL = txtURL.Text,
                    EMail = txtEMail.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    User = new UserManager().Get(u => u.ID == GenericFunctions.CurrentUser.ID).First()
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID & r.RecordName.ToLower().Contains(txtFilter.Text.ToLower())));
                GenericFunctions.ClearControls(gbAdd.Controls);
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int c = 0;

            if (cbSymbols.Checked)
                c += (int)GenericFunctions.PasswordGeneratingOptions.CharactersAndSymbols;
            if (cbNumbers.Checked)
                c += (int)GenericFunctions.PasswordGeneratingOptions.CharactersAndNumbers;

            txtGeneratedPassword.Text = GenericFunctions.GeneratePassword((GenericFunctions.PasswordGeneratingOptions)c, Convert.ToInt32(nudPasswordLength.Value));
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGeneratedPassword.Text))
                Clipboard.SetText(txtGeneratedPassword.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID & r.RecordName.ToLower().Contains(txtFilter.Text.ToLower())));
        }

        private void dataGridRecords_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var currentRow = (sender as DataGridView).Rows[e.RowIndex];

                rm.Update(currentRow.Tag as Record,
                    currentRow.Cells["RecordName"].Value == null ? String.Empty : currentRow.Cells["RecordName"].Value.ToString(),
                    currentRow.Cells["EMail"].Value == null ? String.Empty : currentRow.Cells["EMail"].Value.ToString(),
                    currentRow.Cells["Username"].Value == null ? String.Empty : currentRow.Cells["Username"].Value.ToString(),
                    currentRow.Cells["URL"].Value == null ? String.Empty : currentRow.Cells["URL"].Value.ToString(),
                    currentRow.Cells["Password"].Value == null ? String.Empty : currentRow.Cells["Password"].Value.ToString()
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID & r.RecordName.ToLower().Contains(txtFilter.Text.ToLower())));
            }
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountSettings form = new FormAccountSettings();

            if (form.ShowDialog() == DialogResult.OK)
                this.Text = $"KeyVault | {GenericFunctions.CurrentUser.Username}";
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager<FormLogin>.CreateForm().Show();
            GenericFunctions.CurrentUser = null;
            this.Close();
        }

        private void backupDatabaseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GenericFunctions.BackupDatabaseFile(null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void restoreDatabaseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GenericFunctions.RestoreDatabaseFile();
                MessageBox.Show($"Old database backup file saved to {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)} directory. You need to login or register.");
                
                FormManager<FormLogin>.CreateForm().Show();
                GenericFunctions.CurrentUser = null;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridRecords_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                rm.Remove(r => r.ID == (e.Row.Tag as Record).ID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}