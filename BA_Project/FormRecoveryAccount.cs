using BA_Project.Business.Managers;
using BA_Project.DAL.Entities;

namespace BA_Project
{
    public partial class FormAccountRecovery : Form
    {
        public FormAccountRecovery()
        {
            InitializeComponent();
        }

        User user;

        public void SetUser(User user)
        {
            this.user = user;
        }

        private void txtAccountRecoveryCode_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = (sender as TextBox).Text == user.Settings.AccountRecoveryCode;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = !string.IsNullOrEmpty((sender as TextBox).Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new UserManager().Update(user, null, txtNewPassword.Text, null);

                MessageBox.Show("Your password is updated. Navigating to login.");
                user.Settings.AccountRecoveryCode = GenericFunctions.GeneratePassword(GenericFunctions.PasswordGeneratingOptions.CharactersAndNumbers, 24);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAccountRecovery_Load(object sender, EventArgs e)
        {
            MessageBox.Show("A recovery code has been sent to your e-mail address. Use the recovery code and create a new password.");
        }
    }
}
