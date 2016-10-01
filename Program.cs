using System;
using System.Windows.Forms;

namespace HammingCode
{
    static class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
