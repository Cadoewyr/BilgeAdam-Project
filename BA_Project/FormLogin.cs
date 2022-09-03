using BA_Project.Business.Managers;
using BA_Project.Cryptography;
using BA_Project.Form_Manager;

namespace BA_Project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userManager = new UserManager();

            if (userManager.Exists(u => u.Username == txtUsername.Text & u.Password == MD5.Encrypt(txtPassword.Text)))
            {
                var form = (FormMain)FormManager<FormMain>.CreateForm();
                form.SetCurrentUser(userManager.Get(u => u.Username == txtUsername.Text & u.Password == MD5.Encrypt(txtPassword.Text)).FirstOrDefault());
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GenericFunctions.ClearControls(this.Controls);
                txtUsername.Focus();
            }
        }

        private void btnNavigateToRegister_Click(object sender, EventArgs e)
        {
            FormManager<FormRegister>.CreateForm().Show();
            this.Close();
        }
    }
}
