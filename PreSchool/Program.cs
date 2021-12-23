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
            //Sorry for all the messy code and duplicates in this project, Windows forms worked much more different than I thought 
            //and that created a bunch of dumb problems that I didn't find solutions for.
            //This helped me alot tho and was a really good guide https://www.youtube.com/watch?v=dQw4w9WgXcQ

            #region Startup Tasks 
            StartupTask.CreateGroups();
            StartupTask.CreateChildren();
            StartupTask.CreateGuardians();
            StartupTask.CreateEmployees();
            #endregion
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}