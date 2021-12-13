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

    public partial class categorias : Form
    {
        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        /// <summary>
        /// Pantalla que carga de la BBDD las categorias que dispongan de productos en la BD.
        /// </summary>
        public categorias() {
            InitializeComponent();
            CargarCat();
        }
        /// <summary>
        /// Metodo que carga dinamicamente botones del tipo especial para categorias,
        /// y que les pone el nombre de la categoria a cada uno de ellos, creandoles su evento.
        /// </summary>
        private void CargarCat() {
            try {
                Conexion.Open();
                MySqlDataReader reader;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT categoria FROM productos;";
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    controlCat boton= new controlCat();
                    boton.evento += new EventHandler(controlCat_OnClick);
                    flowLayoutPanel1.Controls.Add(boton);
                    string categor = reader[0].ToString();
                    boton.btnCategoria.Text = categor;
                    boton.cat = categor;
                }
                Conexion.Close();
            } catch (MySqlException ex) {
                MessageBox.Show("Hay un error en la conexion" + ex.Message, "Error");
            } catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un fallo" + ex.Message, "Error");
            }
        }
        /// <summary>
        /// Método del boton de categoria en el cual se llama al formulario de productos, al que se
        /// le pasa la correspondiente categoria.
        /// </summary>
        private void controlCat_OnClick(object sender, EventArgs e) {

            controlCat categoria = sender as controlCat;
            string cate = categoria.cat.ToString();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
