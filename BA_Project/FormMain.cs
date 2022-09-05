using BA_Project.Business.Managers;
using BA_Project.DAL.Entities;

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
                dataGridView.Columns.Add("Password", "Password");
            }

            GenericFunctions.ClearControls(dataGridView);

            foreach (Record record in records)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView, record.RecordName, record.URL, record.EMail, record.Password);
                row.Tag = record;
                dataGridView.Rows.Add(row);
            }

            foreach (DataGridViewColumn column in dataGridRecords.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dataGridRecords.Rows.Count > 0)
                dataGridRecords.Sort(dataGridRecords.Columns["RecordName"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += $" | {GenericFunctions.CurrentUser.Username}";
            rm = new RecordManager();

            FillDataGridView(this.dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID));
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
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID));
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

        private void dataGridRecords_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                var dgv = (sender as DataGridView);

                if (e.KeyCode == Keys.Delete & dgv.SelectedCells.Count > 0)
                {
                    rm.Remove(dgv.Rows[dgv.SelectedCells[0].RowIndex].Tag as Record);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FillDataGridView(this.dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID));
            }
        }

        private void dataGridRecords_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (sender as DataGridView);

            try
            {
                rm.Update(dgv.Rows[dgv.CurrentCell.RowIndex].Tag as Record,
                    dgv.Rows[dgv.CurrentCell.RowIndex].Cells["RecordName"].Value.ToString(),
                    dgv.Rows[dgv.CurrentCell.RowIndex].Cells["URL"].Value.ToString(),
                    dgv.Rows[dgv.CurrentCell.RowIndex].Cells["EMail"].Value.ToString(),
                    dgv.Rows[dgv.CurrentCell.RowIndex].Cells["Password"].Value.ToString()
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == GenericFunctions.CurrentUser.ID));
            }
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccountSettings form = new FormAccountSettings();

            if (form.ShowDialog() == DialogResult.OK)
                this.Text = $"KeyVault | {GenericFunctions.CurrentUser.Username}";
        }
    }
}