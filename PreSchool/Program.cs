namespace PreSchool
{
    using PreSchool.Utils;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StartupTask.CreateGroups();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}