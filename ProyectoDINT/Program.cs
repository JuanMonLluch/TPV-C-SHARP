using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Registro registro = new Registro();
            //registro.FormClosed += Forms_cerrados;
            //registro.Show();
            login login = new login();
            login.FormClosed += Forms_cerrados;
            login.Show();
            Application.Run();
        }

        private static void Forms_cerrados(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Forms_cerrados;
            if (Application.OpenForms.Count == 0)
            {
                Properties.Settings.Default.Estado_login = false;
                Properties.Settings.Default.Save();
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Forms_cerrados;
            }
        }
    }
}
