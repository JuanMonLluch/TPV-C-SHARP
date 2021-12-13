using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    public partial class PregMesaCaja : Form
    {
        public int numMesas;
        public double dineroCaja;
        public PregMesaCaja()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            numMesas = Convert.ToInt32(numUpdownMesas.Value);
            /*Menu menu = new Menu();
            menu.ShowDialog();
            numMesas = (int)numUpdownMesas.Value;
            dineroCaja = (int)numUpDownDinero.Value;*/
            this.Close();
        }
    }
}