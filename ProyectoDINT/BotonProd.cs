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
    public partial class BotonProd : UserControl
    {
        /// <summary>
        /// Control presonalizado de productos.
        /// </summary>
        public BotonProd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Declaramos el evento del botón de manera publica, y los datos que se recogeran,
        /// nombre de producto y precio del mismo.
        /// </summary>
        public event EventHandler evento;
        string prod;
        string preci;
        /// <summary>
        /// Getters y Setters para nombre de producto y precio.
        /// </summary>
        public String produ
        {
            set { prod = value; }
            get { return prod; }

        }
        public string prec
        {
            set { preci = value; }
            get { return preci; }
        }
        
        private void hola(object sender, EventArgs e)
        {
            if (evento != null)
                evento(this, e);
        }
    }
}
