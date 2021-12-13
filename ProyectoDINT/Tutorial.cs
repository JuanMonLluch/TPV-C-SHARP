using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace ProyectoDINT
{
    public partial class Tutorial : Form
    {   
        /// <summary>
        /// Formulario del tutorial.
        /// </summary>
        public Tutorial()
        {
            InitializeComponent();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
        }

        private void btnTuto_volver_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://google.es");
            this.Close();
        }
    }
}
