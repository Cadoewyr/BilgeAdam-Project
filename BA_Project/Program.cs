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
            using(var mutex = new Mutex(false, "KeyVault"))
            {
                bool isAnotherInstanceOpened = !mutex.WaitOne(TimeSpan.Zero);

                if (isAnotherInstanceOpened)
                    return;
                else
                {
                    ApplicationConfiguration.Initialize();
                    var db = DB.Instance; // for initiate database
                    FormManager<FormLogin>.CreateForm().Show();
                    Application.Run();
                }

                mutex.ReleaseMutex();
            }
        }
    }
}