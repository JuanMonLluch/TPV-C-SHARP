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
    public partial class MesaAbierta : UserControl
    {
        public MesaAbierta()
        {
            InitializeComponent();
        }

        
        public event EventHandler eventoMesaAbierta;
        String numMesaAbierta;
        String numComensales;
        String importe;

        public String numMesaAbiertadu
        {
            set { numMesaAbierta = value; }
            get { return numMesaAbierta; }
        }

        public String numComensalesodu
        {
            set { numComensales = value; }
            get { return numComensales; }
        }

        public String importedu
        {
            set { importe = value; }
            get { return importe; }
        }

        private void MesaAbierta_Click(object sender, EventArgs e)
        {
            if (eventoMesaAbierta != null)
                eventoMesaAbierta(this, e);
        }

        
    }
}
