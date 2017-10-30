using System;
using System.Windows.Forms;

namespace BittrexScanner
{
    static class MoneyMaker
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BTRXscanner());
        }
    }
}
