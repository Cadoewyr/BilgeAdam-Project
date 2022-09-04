using BA_Project.DAL.Context;
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
            CharactersAndSymbolsAndNumbers= 3
        }

        public static void ExitIfAnyFormNotExist()
        {
            if (Application.OpenForms.Count == 0)
            {
                DB.Instance.CloseConnection();
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
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z', 'x', 'w', 'q' };
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

            for(int i = 0; i < length; i++)
            {
                choosenChars += rnd.Next(0,2) == 0 ? array[rnd.Next(0, array.Length)].ToString().ToUpper() : array[rnd.Next(0, array.Length)].ToString().ToLower();
            }

            return choosenChars;
        }
    }
}