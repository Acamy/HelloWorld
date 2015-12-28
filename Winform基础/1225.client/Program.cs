using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _1225.client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            f1.Show();
            
            Application.Run(f1);
            //HideOnStartupApplicationContext context = new HideOnStartupApplicationContext();
            //Application.Run();
            //f1.WindowState = FormWindowState.Minimized;
            
            //f1.Hide();
            
        }
    }
}
