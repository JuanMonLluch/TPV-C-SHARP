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
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prgressbar_Carga.Increment(1);
            label1.Text = prgressbar_Carga.Value.ToString() + "%";
            if (label1.Text == "100%")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void carga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
