using System.Windows;

namespace SaveFileAs
{
    public partial class App : Application
    {
        /*
         * Args[0] -> path of source file
         * Args[1] -> file name
         * Args[2] -> path of initial directory
         */

        private void StartApplication(object sender, StartupEventArgs e)
        {
            ArgumentManager.Args = e.Args;
            ArgumentManager.Print();

            if (ArgumentManager.Validate()) FileManager.SaveFileAs(e.Args[0], e.Args[1], e.Args[2]);

            Shutdown();
        }
    }
}