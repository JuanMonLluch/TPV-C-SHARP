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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        Color color;
        Menu menu = new Menu();

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Deseas guardar los cambios?", "Configuración", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.No)
            {
                menu.Show();
                this.Close();
            }
            else if(result == DialogResult.Yes)
            {
                if(chckbox_ModOsc_Conf.Checked == true)
                {
                    menu.Show();
                    this.Close();
                    //Properties.Settings.Default.Bckground = Color.LightSlateGray;
                    //Properties.Settings.Default.Save();
                    
                }
                else if(chckbox_ModOsc_Conf.Checked == false)
                {
                    //Properties.Settings.Default.Bckground = Color.White;
                    //Properties.Settings.Default.Save();
                }
            }
            else if(result == DialogResult.Cancel)
            {
                
            }
        }
    }
}
