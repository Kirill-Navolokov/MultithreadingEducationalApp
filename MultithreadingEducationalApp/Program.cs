using System;
using System.Windows.Forms;
using MultithreadingEducationalApp.IoC;

namespace MultithreadingEducationalApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IoCInitializer.Initizlize(new ApplicationModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(IoCInitializer.Resolve<MainWindow>());
        }
    }
}