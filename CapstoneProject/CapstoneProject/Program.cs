using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneProject
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            DatabaseConnectionFactory conn = new DatabaseConnectionFactory();
            ApplicationConfiguration.Initialize();
            Application.Run(new TaskTrackerForm(conn));
        }
    }
}