using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            FormLogin formLogin = new FormLogin();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
