using System;
using System.Windows.Forms;

using AnimeRandomizer.Frontends;

namespace AnimeRandomizer
{
    static class Program
    {
        [STAThread]
        static void Main(string[] p_args)
        {
            if (p_args.Length != 0 && p_args[0] == "-c")
            {
                ConsoleFrontend.Run();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AnimeRandomizerForm());
            }
        }
    }
}
