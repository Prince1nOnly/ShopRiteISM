using System;
using System.Windows.Forms;

namespace Shoprite_IMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MySQLFunctions sqlFunc = new MySQLFunctions();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow appWindow = new MainWindow();
            Application.Run(appWindow);
        }
    }
}
