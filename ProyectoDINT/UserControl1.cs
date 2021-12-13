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
    public partial class controlCat : UserControl
    {
        /// <summary>
        /// Boton personalizados de categorias.
        /// </summary>
        public controlCat() {
            InitializeComponent();
        }
        /// <summary>
        /// Declaración del evento publico, y de un string para guardar la categoria, con su setter y su setter.
        /// </summary>
        public event EventHandler evento;
        string categ;
        public String cat
        {
            set { categ = value; }
            get { return categ; }
        }
        private void hola(object sender, EventArgs e) {
            if (evento != null)
                evento(this, e);
        }
    }
}
