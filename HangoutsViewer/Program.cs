using System;
using System.Windows.Forms;
using HangoutsViewer.ViewModels.Classes;
using HangoutsViewer.Views;

namespace HangoutsViewer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HangoutsView(new HangoutsViewModel(null)));
        }
    }
}
