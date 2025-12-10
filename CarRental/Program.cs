namespace CarRental
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // New .NET Core WinForms initialization
            ApplicationConfiguration.Initialize();

            // STARTUP FORM
            Application.Run(new Form2());
        }
    }
}
