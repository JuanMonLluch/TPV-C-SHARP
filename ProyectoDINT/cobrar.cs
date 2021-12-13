using MySql.Data.MySqlClient;
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
    public partial class cobrar : Form
    {
        /// <summary>
        /// Formulario de cobro.
        /// </summary>
        public int aux4;

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");

        public cobrar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que calcula el cambio.
        /// </summary>
        private void txtboxChange(object sender, EventArgs e)
        {
            try
            {
                int aux = Convert.ToInt32(lblTotal.Text);

                int aux2 = Convert.ToInt32(txtboxPago.Text);
                int aux3 = aux2 - aux;
                lblCambio.Text = aux3.ToString() + " €";
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error");
            }
        }
        /// <summary>
        /// Botón de cobro, sale de la pantalla de cobro.
        /// </summary>
        private void btnCobrarFinal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo que recoge el total del ticket para mostrarlo en este formulario.
        /// </summary>
        private void cobrar_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                lblTotal.Text = aux4.ToString();
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT user FROM usuarios";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                    comboBox1.SelectedItem = reader[0].ToString();
                }
                Conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
