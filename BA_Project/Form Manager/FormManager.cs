namespace BA_Project.Form_Manager
{
    public static class FormManager<T> where T : Form
    {
        public static Form CreateForm()
        {
            T form = (T)Activator.CreateInstance(typeof(T));
            form.FormClosed += (object? sender, FormClosedEventArgs args) => GenericFunctions.ExitIfAnyFormNotExist();
            return form;
        }
    }
}
