using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    public partial class BotonMesas : UserControl
    {
        /// <summary>
        /// Boton personalizado para las mesas.
        /// </summary>
        public BotonMesas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Guardamos el numero de mesa como propiedad en el botón.        /// </summary>
        int mesa;
        public event EventHandler ev;
        public int mes
        {
            set { mesa = value; }
            get { return mesa; }
        }
        private void hola(object sender, EventArgs e)
        {
            if (ev != null)
                ev(this, e);
        }
        
    }
}
