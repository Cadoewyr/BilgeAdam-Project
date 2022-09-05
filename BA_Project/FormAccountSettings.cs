using BA_Project.Business.Managers;
using BA_Project.Form_Manager;
using BA_Project.Validation;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using User = BA_Project.DAL.Entities.User;

namespace BA_Project
{
    public partial class FormAccountSettings : Form
    {
        public FormAccountSettings()
        {
            InitializeComponent();
        }

        UserManager um;

        private void FormAccountSettings_Load(object sender, EventArgs e)
        {
            um = new UserManager();

            this.Text += $" | {GenericFunctions.CurrentUser.Username}";

            txtCurrentEMail.Text = GenericFunctions.CurrentUser.EMail;
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword1.Enabled = !string.IsNullOrEmpty((sender as TextBox).Text);
            txtNewPassword2.Enabled = !string.IsNullOrEmpty((sender as TextBox).Text);

            if (string.IsNullOrEmpty((sender as TextBox).Text))
                GenericFunctions.ClearControls(txtNewPassword1, txtNewPassword2);
        }

        public void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            btnSavePassword.Enabled = (txtNewPassword1.Text == txtNewPassword2.Text) & (!string.IsNullOrEmpty(txtNewPassword1.Text) & !string.IsNullOrEmpty(txtNewPassword2.Text));
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new UserValidator().Validate(new User()
                {
                    Username = GenericFunctions.CurrentUser.Username,
                    Password = txtNewPassword1.Text,
                    EMail = GenericFunctions.CurrentUser.EMail
                });

                if (result.IsValid & GenericFunctions.CurrentUser.Password == Cryptography.MD5.Encrypt(txtCurrentPassword.Text))
                {
                    um.Update(GenericFunctions.CurrentUser, null, txtNewPassword1.Text, null);

                    MessageBox.Show("Password changed.");
                }
                else
                {
                    if (!result.IsValid)
                    {
                        StringBuilder SB = new StringBuilder();

                        foreach (var error in result.Errors)
                        {
                            SB.Append(error.ErrorMessage).AppendLine();
                        }

                        throw new Exception(SB.ToString());
                    }
                    else
                        MessageBox.Show("Current password is wrong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GenericFunctions.ClearControls(gbChangePassword.Controls);
            }
        }

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {
            try
            {
                um.Update(GenericFunctions.CurrentUser, txtNewUsername.Text, null, null);

                this.Text = $"Account Settings | {GenericFunctions.CurrentUser.Username}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GenericFunctions.ClearControls(gbChangeUsername.Controls);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All your records will be deleted. Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    um.Remove(GenericFunctions.CurrentUser);
                    GenericFunctions.CurrentUser = null;

                    var form = FormManager<FormLogin>.CreateForm();
                    form.Show();

                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i] != form)
                            Application.OpenForms[i].Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNewUsername_TextChanged(object sender, EventArgs e)
        {
            btnSaveUsername.Enabled = !string.IsNullOrEmpty((sender as TextBox).Text);
        }

        private void btnSaveMail_Click(object sender, EventArgs e)
        {
            try
            {
                um.Update(GenericFunctions.CurrentUser, null, null, txtNewEMail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GenericFunctions.ClearControls(gbChangeMail.Controls);
                txtCurrentEMail.Text = GenericFunctions.CurrentUser.EMail;
            }
        }

        private void txtNewEmail_TextChanged(object sender, EventArgs e)
        {
            btnSaveEMail.Enabled = !string.IsNullOrEmpty((sender as TextBox).Text);
        }

        private void FormAccountSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
