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

        User CurrentUser;
        RecordManager rm;

        public void SetCurrentUser(User currentUser)
        {
            this.CurrentUser = currentUser;
        }
        void FillDataGridView(DataGridView dataGridView, List<Record> records)
        {
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("RecordName", "Record Name");
                dataGridView.Columns.Add("URL", "URL");
                dataGridView.Columns.Add("Mail", "Mail");
                dataGridView.Columns.Add("Password", "Password");
            }

            GenericFunctions.ClearControls(dataGridView);

            foreach (Record record in records)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView, record.RecordName, record.URL, record.Mail, record.Password);
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
            this.Text += $" | {CurrentUser.Username}";
            rm = new RecordManager();

            dataGridRecords.CellValueChanged += (object? sender, DataGridViewCellEventArgs e) =>
            {
                var dgv = sender as DataGridView;
                Record oldRec = dgv.Rows[dgv.CurrentCell.RowIndex].Tag as Record;

                try
                {

                    Record rec = new Record()
                    {
                        RecordName = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["RecordName"].Value.ToString(),
                        URL = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["URL"].Value.ToString(),
                        Mail = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["Mail"].Value.ToString(),
                        Password = dgv.Rows[dgv.CurrentCell.RowIndex].Cells["Password"].Value.ToString()
                    };

                    rm.Update(oldRec, rec);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == CurrentUser.ID));
                }
            };
            dataGridRecords.KeyDown += (object? sender, KeyEventArgs e) =>
            {
                try
                {
                    if (e.KeyCode == Keys.Delete & (sender as DataGridView).SelectedCells.Count > 0)
                    {
                        var dgv = (sender as DataGridView);

                        Record temp = dgv.Rows[dgv.SelectedCells[0].RowIndex].Tag as Record;
                        rm.Remove(temp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    FillDataGridView(this.dataGridRecords, rm.Get(r => r.User.ID == CurrentUser.ID));
                }
            };

            FillDataGridView(this.dataGridRecords, rm.Get(r => r.User.ID == CurrentUser.ID));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Record rec = new Record()
                {
                    RecordName = txtRecordName.Text,
                    URL = txtURL.Text,
                    Mail = txtMail.Text,
                    Password = txtPassword.Text,
                    User = new UserManager().Get(u => u.ID == CurrentUser.ID).First()
                };

                rm.Add(rec);
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == CurrentUser.ID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FillDataGridView(dataGridRecords, rm.Get(r => r.User.ID == CurrentUser.ID));
                GenericFunctions.ClearControls(gpAdd.Controls);
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int c = 0;

            if (cbSymbols.Checked)
                c += (int)GenericFunctions.PasswordGeneratingOptions.CharactersAndSymbols;
            if (cbNumbers.Checked)
                c += (int)GenericFunctions.PasswordGeneratingOptions.CharactersAndNumbers;

            GenericFunctions.PasswordGeneratingOptions option = (GenericFunctions.PasswordGeneratingOptions)c;

            txtGeneratedPassword.Text = GenericFunctions.GeneratePassword(option, Convert.ToInt32(nudPasswordLength.Value));
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGeneratedPassword.Text))
                Clipboard.SetText(txtGeneratedPassword.Text);
        }
    }
}