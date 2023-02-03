using AISShopComputerParts.Logic;
using System;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var SQLExecuter = new MySqlExecutor("host='localhost';database='carwah_shema';uid='root';pwd='';charset=utf8;");
            MySqlExecutor.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutorizationForm());
        }
    }
}
