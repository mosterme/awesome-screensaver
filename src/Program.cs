using System.Windows.Forms;
using System;
namespace awesomescr
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                if (args[0].ToLower().Trim().Substring(0, 2) == "/s") //show
                {
                    //show the screen saver
                    ShowScreenSaver();
                    Application.Run();
                }
                else if (args[0].ToLower().Trim().Substring(0, 2) == "/p") //preview
                {
                    //preview the screen saver
                    IntPtr previewWndHandle = new IntPtr(long.Parse(args[1]));
                    Application.Run(new Screensaver(previewWndHandle));
                }
                else if (args[0].ToLower().Trim().Substring(0, 2) == "/c") //configure
                {
                    //configure the screen saver
                    Settings settings = new Settings(true);
                    Application.Run(settings);
                }
            }
            else
            {
                //no arguments were passed (we should probably show the screen saver)
                ShowScreenSaver();
                Application.Run();
            }
        }
        static void ShowScreenSaver()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                Screensaver screensaver = new Screensaver(screen.Bounds);
                screensaver.Show();
            }
        }
    }
}
