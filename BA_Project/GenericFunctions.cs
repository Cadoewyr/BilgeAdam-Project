using BA_Project.Business.Managers;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using Microsoft.Data.Sqlite;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.Control;

namespace BA_Project
{
    public static class GenericFunctions
    {
        public enum PasswordGeneratingOptions
        {
            Characters = 0,
            CharactersAndNumbers = 1,
            CharactersAndSymbols = 2,
            CharactersAndSymbolsAndNumbers = 3
        }

        static User _currentUser;

        public static User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static void ExitIfAnyFormNotExist()
        {
            if (Application.OpenForms.Count == 0)
            {
                DB.Instance.CloseConnection();
                SqliteConnection.ClearAllPools();
                Application.Exit();
            }
        }
        public static void ClearControls(List<Control> controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();

                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Clear();

                else if (control is RichTextBox)
                    (control as RichTextBox).Clear();

                else if (control is ListBox)
                    (control as ListBox).Items.Clear();

                else if (control is ComboBox)
                    (control as ComboBox).Items.Clear();

                else if (control is CheckedListBox)
                    (control as CheckedListBox).Items.Clear();

                else if (control is ListView)
                    (control as ListView).Items.Clear();

                else if (control is DataGridView)
                    (control as DataGridView).Rows.Clear();
            }
        }
        public static void ClearControls(ControlCollection controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();

                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Clear();

                else if (control is RichTextBox)
                    (control as RichTextBox).Clear();

                else if (control is ListBox)
                    (control as ListBox).Items.Clear();

                else if (control is ComboBox)
                    (control as ComboBox).Items.Clear();

                else if (control is CheckedListBox)
                    (control as CheckedListBox).Items.Clear();

                else if (control is ListView)
                    (control as ListView).Items.Clear();

                else if (control is DataGridView)
                    (control as DataGridView).Rows.Clear();
            }
        }
        public static void ClearControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox)
                    (control as TextBox).Clear();

                else if (control is MaskedTextBox)
                    (control as MaskedTextBox).Clear();

                else if (control is RichTextBox)
                    (control as RichTextBox).Clear();

                else if (control is ListBox)
                    (control as ListBox).Items.Clear();

                else if (control is ComboBox)
                    (control as ComboBox).Items.Clear();

                else if (control is CheckedListBox)
                    (control as CheckedListBox).Items.Clear();

                else if (control is ListView)
                    (control as ListView).Items.Clear();

                else if (control is DataGridView)
                    (control as DataGridView).Rows.Clear();
            }
        }
        public static string GeneratePassword(PasswordGeneratingOptions passwordGeneratingOptions, int? length)
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z', 'x', 'w', 'q' };
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] symbols = { '!', '$', '-', '_', '&', '.', ',', ';', ':', '*', '?', '/', '=', '%', '+', '<', '>' };

            int l = 0;
            string password = string.Empty;

            if (length == null)
            {
                Random rnd = new Random();
                l = rnd.Next(8, 101);
            }
            else
                l = length.Value;

            switch (passwordGeneratingOptions)
            {
                case PasswordGeneratingOptions.Characters:
                    password = ChooseRandomChars(ShuffleCharArray(chars), l);
                    break;
                case PasswordGeneratingOptions.CharactersAndNumbers:
                    password = ChooseRandomChars(ShuffleCharArray(chars, numbers), l);
                    break;
                case PasswordGeneratingOptions.CharactersAndSymbols:
                    password = ChooseRandomChars(ShuffleCharArray(chars, symbols), l);
                    break;
                case PasswordGeneratingOptions.CharactersAndSymbolsAndNumbers:
                    password = ChooseRandomChars(ShuffleCharArray(chars, numbers, symbols), l);
                    break;
            }

            return password;
        }
        public static void SendRecoveryMail(string mail, string recoveryCode)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp-mail.outlook.com", 587)
                {
                    Credentials = new NetworkCredential("keyvaulthelp@outlook.com", "V9PQcKKwla"),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = true
                };

                smtpClient.Send("keyvaulthelp@outlook.com", mail, "KeyVault Account Recovery", $"Your account recovery code: {recoveryCode}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RememberMe(bool c, string password)
        {
            AppSettingManager asm = new AppSettingManager();

            try
            {
                if (!asm.Exists(x => x.Key == "RememberMeUsername"))
                {
                    asm.Add(new AppSetting()
                    {
                        Key = "RememberMeUsername",
                        Value = c ? GenericFunctions.CurrentUser.Username : null
                    });
                }
                else
                {
                    asm.Update(asm.Get(x => x.Key == "RememberMeUsername").First(), c ? GenericFunctions.CurrentUser.Username : null);
                }

                if (!asm.Exists(x => x.Key == "RememberMeUserPassword"))
                {
                    asm.Add(new AppSetting()
                    {
                        Key = "RememberMeUserPassword",
                        Value = c ? password : null
                    });
                }
                else
                {
                    asm.Update(asm.Get(x => x.Key == "RememberMeUserPassword").First(), c ? password : null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void BackupDatabaseFile(string? targetPath)
        {
            if (File.Exists(Application.StartupPath + @"\keyvault.db"))
            {
                try
                {
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        fbd.Description = "Choose a directory to create the database backup file.";
                        fbd.RootFolder = Environment.SpecialFolder.Desktop;
                        fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        fbd.ShowNewFolderButton = true;
                        fbd.UseDescriptionForTitle = true;

                        if ((Directory.Exists(targetPath) & targetPath != null) || fbd.ShowDialog() == DialogResult.OK)
                        {
                            DB.Instance.SaveChanges();
                            DB.Instance.CloseConnection();

                            SqliteConnection.ClearAllPools();

                            string date = DateTime.Now.ToShortDateString().Replace(".", "-");
                            string time = $"{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";

                            string directory = Directory.Exists(targetPath) & targetPath != null ? targetPath : fbd.SelectedPath;
                            string filename = $"\\keyvault_{date}_{time}.db";
                            File.Copy(Application.StartupPath + @"\keyvault.db", $"{directory}{filename}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
                throw new FileNotFoundException("Database file not found.");
        }
        public static void RestoreDatabaseFile()
        {
            try
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    fd.RestoreDirectory = true;
                    fd.Multiselect = false;
                    fd.Filter = "Database files (*.db)|*.db";

                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        BackupDatabaseFile($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\KeyVault\Backups");
                        Directory.CreateDirectory($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\KeyVault\Backups");

                        DB.Instance.Database.EnsureDeleted();
                        DB.Instance.CloseConnection();

                        SqliteConnection.ClearAllPools();

                        File.Delete($@"{Application.StartupPath}\keyvault.db");
                        File.Copy(fd.FileName, $@"{Application.StartupPath}\keyvault.db");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static char[] ShuffleCharArray(params Array[] arrays)
        {
            List<char> chars = new List<char>();

            foreach (Array array in arrays)
            {
                foreach (var ch in array)
                {
                    chars.Add(Convert.ToChar(ch));
                }
            }

            List<char> shuffledCharArray = new List<char>();

            Random rnd = new Random();

            while (chars.Count > 0)
            {
                int index = rnd.Next(0, chars.Count);
                shuffledCharArray.Add(chars[index]);
                chars.RemoveAt(index);
            }

            return shuffledCharArray.ToArray();
        }
        static string ChooseRandomChars(char[] array, int length)
        {
            string choosenChars = string.Empty;

            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                choosenChars += rnd.Next(0, 2) == 0 ? array[rnd.Next(0, array.Length)].ToString().ToUpper() : array[rnd.Next(0, array.Length)].ToString().ToLower();
            }

            return choosenChars;
        }
    }
}