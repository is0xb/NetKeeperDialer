using System;
using System.Windows.Forms;

namespace iWay.NetKeeperDialer
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window(args.Length == 1 && args[0] == "-s"));
        }
    }
}
