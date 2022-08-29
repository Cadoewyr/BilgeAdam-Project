using BA_Project.DAL.Context;
using BA_Project.Form_Manager;

namespace BA_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormManager<FormLogin>.CreateForm().Show();
            Application.Run();
        }
    }
}