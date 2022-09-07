using BA_Project.Business.Managers;
using BA_Project.Cryptography;
using BA_Project.DAL.Entities;
using BA_Project.Form_Manager;

namespace BA_Project
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                new UserManager().Add(new User()
                {
                    Username = txtUsername.Text.Trim(),
                    EMail = txtEMail.Text,
                    Password = Cryptography.MD5.Encrypt(txtPassword1.Text)
                });

                MessageBox.Show("Successfully registered. Navigating to login.");

                FormManager<FormLogin>.CreateForm().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                GenericFunctions.ClearControls(this.Controls);
                txtUsername.Focus();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNavigateToLogin_Click(object sender, EventArgs e)
        {
            FormManager<FormLogin>.CreateForm().Show();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnRegister.Enabled = (txtPassword1.Text == txtPassword2.Text) & (!string.IsNullOrEmpty(txtPassword1.Text) & !string.IsNullOrEmpty(txtPassword2.Text));
        }
    }
}