using BA_Project.Business.Managers;
using BA_Project.Cryptography;
using BA_Project.DAL.Entities;
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
                GenericFunctions.CurrentUser = userManager.Get(u => u.Username == txtUsername.Text & u.Password == MD5.Encrypt(txtPassword.Text)).FirstOrDefault();
                form.Show();

                GenericFunctions.RememberMe(cbRememberMe.Checked, txtPassword.Text);

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

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (new UserManager().Exists(u => u.Username == txtUsername.Text))
            {
                User temp = new UserManager().Get(u => u.Username == txtUsername.Text).First();
                try
                {
                    GenericFunctions.SendRecoveryMail(temp.EMail, temp.Settings.AccountRecoveryCode);
                    FormAccountRecovery form = new FormAccountRecovery();
                    form.SetUser(temp);
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Username is wrong.");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            AppSettingManager asm = new AppSettingManager();

            if(asm.Exists(x => x.Key == "RememberMeUsername" & x.Value != null) & asm.Exists(x => x.Key == "RememberMeUserPassword" & x.Value != null))
            {
                cbRememberMe.Checked = true;

                txtUsername.Text = asm.Get(x => x.Key == "RememberMeUsername" & x.Value != null).First().Value;
                txtPassword.Text = asm.Get(x => x.Key == "RememberMeUserPassword" & x.Value != null).First().Value;
            }
        }
    }
}
