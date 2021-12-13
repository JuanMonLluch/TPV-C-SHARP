using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    public partial class Ajustes : Form
    {
        /// <summary>
        /// Form de ajustes para cambiar el numero de mesas y otras opciones
        /// </summary>
        public Ajustes()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        /// <summary>
        /// Al cargar el form ajustes, pone los botones en no visibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ajustes_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Properties.Settings.Default.numMesas;
            label1.Visible = false;
            numericUpDown1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btnDescargarCobros.Visible = false;
            btnDescargarProd.Visible = false;
        }

        /// <summary>
        /// Cuando le da al boton de ajustes de aplicación, pone los ajustes de informes en falso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMesas_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            numericUpDown1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            btnDescargarCobros.Visible = false;
            btnDescargarProd.Visible = false;
        }

        /// <summary>
        /// Pone los botones de ajustes de aplicación en no visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformes_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            numericUpDown1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            btnDescargarCobros.Visible = true;
            btnDescargarProd.Visible = true;
        }
        /// <summary>
        /// Onclick del boton de salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Onclick para guardar y salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.numMesas = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }
        /// <summary>
        /// Al darle al boton de descargar informes de productos, lo escribe en un fichero haciendo una consulta y lo guarda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescargarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT ID, Nombre, Precio, categoria FROM productos";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files | *.txt";
                sfd.FileName = "Productos: " + DateTime.Now.ToString();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter fichero;
                    File.WriteAllText(sfd.FileName, "PRODUCTOS\n", Encoding.UTF8);
                    int i=0;
                    while (reader.Read())
                    {
                        i++;
                        String aux = i + ".-" + " ID: " + reader[0].ToString() + " Nombre: " + reader[1].ToString() + " Precio: " + reader[2].ToString() + "€" + " Categoría: " + reader[3].ToString() + "\n";
                        File.AppendAllText(sfd.FileName, aux, Encoding.UTF8);
                    }
                    File.AppendAllText(sfd.FileName, "\n\nInforme solicitado por: " + Properties.Settings.Default.usuActivo + "el dia " + DateTime.Now, Encoding.UTF8);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }

        /// <summary>
        /// Descarga un txt y lo guarda con todos las ventas realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDescargarCobros_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT mesa, importe, camarero, fecha FROM cobros";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files | *.txt";
                sfd.FileName = "VENTAS: " + DateTime.Now.ToString();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter fichero;
                    File.WriteAllText(sfd.FileName, "VENTAS\n", Encoding.UTF8);
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                        String aux =i + ".-" + " Mesa: " + reader[0].ToString() + " Importe: " + reader[1].ToString() + "€" + " Camarero: " + reader[2].ToString() + " Fecha: " + reader[3].ToString() + "\n";
                        File.AppendAllText(sfd.FileName, aux, Encoding.UTF8);
                    }
                    File.AppendAllText(sfd.FileName, "\n\nInforme solicitado por: " + Properties.Settings.Default.usuActivo + " el día " + DateTime.Now, Encoding.UTF8);
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
