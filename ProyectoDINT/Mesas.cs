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
    public partial class Mesas : Form
    {
        /// <summary>
        /// Formulario de mesas que crea 9 botones mesa desde los que se accede a la pantalla de
        /// categorias.
        /// </summary>
        public Mesas()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        //MySqlConnection Conexion2 = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        //MySqlConnection Conexion3 = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        /// <summary>
        /// Cargamos las mesas como botones con sus metodos, preguntando antes si es la primera vez cuantas mesas va a tener.
        /// </summary>
        public int numeroMesa;
        public String numMesa;
        private void Mesas_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Estado_login == true)
            {
                PregMesaCaja pregMesaCaja = new PregMesaCaja();
                if (DialogResult.OK == pregMesaCaja.ShowDialog())
                {
                    Properties.Settings.Default.numMesas = pregMesaCaja.numMesas;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Estado_login = false;
                    Properties.Settings.Default.Save();
                }
            }

            numeroMesa = Properties.Settings.Default.numMesas;
            for(int i=1; i <= numeroMesa; i++)
            {
                BotonMesas botonMesas = new BotonMesas();
                botonMesas.ev += new EventHandler(botonMesas_click);
                flowLayoutPanel1.Controls.Add(botonMesas);
                botonMesas.btnMesaNum.Text = Convert.ToString(i);
                
            }
            try
            {
                Conexion.Close();
                //Conexion2.Close();
                //Conexion3.Close();
                Conexion.Open();
                //Conexion2.Open();
                //Conexion3.Open();
                MySqlDataReader reader;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT SUM(precio), mesa from comandas GROUP BY mesa";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    /*MySqlDataReader reader2;
                    MySqlCommand cmd2 = Conexion2.CreateCommand();
                    cmd2.CommandText = "SELECT productos, cantidad, precio, precioud FROM comandas WHERE mesa= @mesa;";
                    cmd2.Parameters.Add("@mesa", MySqlDbType.Text).Value = reader[0];
                    reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                    //Conexion3.Open();

                    MySqlCommand cmd3 = Conexion3.CreateCommand();
                    cmd3.CommandText = "SELECT SUM(precio) from comandas where mesa=@mesa2;";
                    cmd3.Parameters.Add("@mesa2", MySqlDbType.Text).Value = reader[0];
                    MySqlDataReader reader3;
                    reader3 = cmd3.ExecuteReader();
                    reader3.Read();*/
                    MesaAbierta mesaAbierta = new MesaAbierta();

                    mesaAbierta.eventoMesaAbierta += new EventHandler(mesabierta_onClick);
                    mesaAbierta.lblnumMesaAbierta.Text = reader[1].ToString();
                    mesaAbierta.lblImporte.Text = reader[0].ToString();
                    mesaAbierta.lblNumComensales.Text = "0";
                    flowLayoutPanel2.Controls.Add(mesaAbierta);
                    //}
                }
                Conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
            
        }

        /// <summary>
        /// Onclick del ticket abierto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mesabierta_onClick(object sender, EventArgs e)
        {
            MesaAbierta mesaAbierta = sender as MesaAbierta;
            Form1 form1 = new Form1();
            
            try
            {
                form1.lblNumMesa.Text = "Mesa: " + mesaAbierta.lblnumMesaAbierta.Text;
                form1.auxNumMesa = mesaAbierta.lblnumMesaAbierta.Text;
                Conexion.Open();
                MySqlDataReader reader;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT cantidad, productos, precio, precioud, total, iva, noIva FROM comandas WHERE mesa= @mesa;";
                cmd.Parameters.Add("@mesa", MySqlDbType.Text).Value = mesaAbierta.lblnumMesaAbierta.Text;
                reader = cmd.ExecuteReader();
                int aux = 0;
                float auxTotal = 0;
                float auxIva = 0;
                float auxNoIva = 0;

                while (reader.Read())
                {

                    auxTotal = auxTotal + (float)reader[4];
                    auxIva = auxIva + (float)reader[5];
                    auxNoIva = auxNoIva + (float)reader[6];
                    //MessageBox.Show(aux.ToString(), aux.ToString(), MessageBoxButtons.OK);
                    form1.label5.Text = auxTotal.ToString() + " €";
                    form1.label6.Text = auxIva.ToString() + " €";
                    form1.label2.Text = auxNoIva.ToString() + " €";
                    if (Convert.ToInt32(reader[0]) != 0)
                    {
                        form1.dataGridView1.Rows.Add();
                        form1.dataGridView1.Rows[aux].Cells[3].Value = Convert.ToInt32(reader[0]);
                        form1.dataGridView1.Rows[aux].Cells[4].Value = reader[1].ToString();
                        form1.dataGridView1.Rows[aux].Cells[5].Value = reader[2];
                        form1.dataGridView1.Rows[aux].Cells[6].Value = reader[3];
                    }

                    aux++;
                }
                Conexion.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
            form1.Show();
            this.Close();
        }

        /// <summary>
        /// Método de los botones mesa que llevan a la pantalla de categoria, guardando en nuMesa el 
        /// número de mesa que corresponde.
        /// </summary>
        private void botonMesas_click(object sender, EventArgs e)
        {
            try
            {
                BotonMesas botonMesas = sender as BotonMesas;
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT COUNT(mesa) FROM comandas WHERE mesa=@mesa";
                cmd.Parameters.Add("@mesa", MySqlDbType.Int32).Value = botonMesas.btnMesaNum.Text;
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();

                    categorias categorias = new categorias();
                    form1.lblNumMesa.Text = "Mesa: " + botonMesas.btnMesaNum.Text;
                    form1.auxNumMesa = botonMesas.btnMesaNum.Text;
                    this.Close();
                    Conexion.Close();
                }
                else
                {
                    Conexion.Close();
                    MessageBox.Show("Ya hay un ticket abierto en esa mesa. \nPor favor cierrelo antes de abrir otro.", "Atención", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }

        /// <summary>
        /// Boton de salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Conexion.Close();
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
