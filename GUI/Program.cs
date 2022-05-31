using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        public static FormLogin FormLogin { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin = new FormLogin();
            Application.Run(FormLogin);
        }
    }
}