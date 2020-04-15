using System;
using System.IO;
using System.Windows.Forms;

namespace VKFlaster
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists("Newtonsoft.Json.dll"))
            {
                MessageBox.Show("Ошибка: файл \"Newtonsoft.Json.dll\" не был найден.", "VKFlaster Bot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Auth());
            }
        }
    }
}
