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
                    Password = MD5.Encrypt(txtPassword.Text)
                });

                MessageBox.Show("Successfully registered. Navigating to login.");

                FormManager<FormLogin>.CreateForm().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                GenericFunctions.ClearControls(this.Controls);

            }
        }

        private void btnNavigateToLogin_Click(object sender, EventArgs e)
        {
            FormManager<FormLogin>.CreateForm().Show();
            this.Close();
        }
    }
}