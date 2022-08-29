using BA_Project.DAL.Context;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace BA_Project
{
    public static class GenericFunctions
    {
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
            foreach(var control in controls)
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
            }
        }
    }
}