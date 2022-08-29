using BA_Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_Project
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        User CurrentUser;

        public void SetCurrentUser(User currentUser)
        {
            this.CurrentUser = currentUser;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += $" | {CurrentUser.Username}";
        }
    }
}
