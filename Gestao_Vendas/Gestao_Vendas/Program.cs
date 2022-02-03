using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_Vendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void decNumero(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
    }
}
