namespace PreSchool
{
    using PreSchool.Models;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Group.CreateGroups();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}