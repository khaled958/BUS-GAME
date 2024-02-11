using DemoStart.Classes;

namespace DemoStart
{
    internal static class Program
    {
        public static List<MovementRecord> movementRecord = new List<MovementRecord>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.            

            ApplicationConfiguration.Initialize();
            Application.Run(new StartPage());
        }
    }
}