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
    public partial class Menu : Form
    {
        /// <summary>
        /// Formulario de menú para navegar entre diferentes pantallas.
        /// </summary>
        public Menu()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");

        String cat;
        public int auxMesasMenu;
        /// <summary>
        /// Botón salir, que te lleva al formulario de login.
        /// </summary>
        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            Close();
            
        }
        /// <summary>
        /// Botón de productos, que te lleva a la pantalla donde estan los productos, y que da acceso a modificar,
        /// a borra o a introducir nuevos. Solo te deja entrar si eres encargado o admin
        /// </summary>

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (cat != "Camarero")
            {
                productos productos = new productos();
                productos.Show();
                this.Close();
            }
            else
            {
                var result = MessageBox.Show("Acceso denegado, inicie sesion como administrador. Pulse en 'Aceptar' para cerrar sesion", "Permiso denegado", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if ( result == DialogResult.OK)
                {
                    login login = new login();
                    login.Show();
                    this.Close();
                }
                

            }
            
        }
        /// <summary>
        /// Método que redimensiona y coloca los botones correctamente.
        /// </summary>
        private void Menu_Resize(object sender, EventArgs e)
        {
            btnMesas_Menu.Left = this.Width - 800;
            btnMesas_Menu.Top = this.Height - 650;
            //btnCaja_Menu.Left = this.Width - 1100;
            //btnCaja_Menu.Top = this.Width - 1100;
            btnCofig.Left = this.Width - 1100;
            btnCofig.Top = this.Width - 1100;
            btnProduct.Left = this.Width - 500;
            btnProduct.Top = this.Width - 1100;
            btnImagUsuAct.Top = this.Width - 1350;
            btnImagUsuAct.Left = this.Width - 250;
            lblUsuActivo.Top = this.Width - 1340;
            lblUsuActivo.Left = this.Width - 205;
            btnAjustes.Left = this.Width - 800;
            btnAjustes.Top = this.Height - 350;
        }
        /// <summary>
        /// Botón que da acceso al formulario del tutorial.
        /// </summary>
        private void btnCofig_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }

        /// <summary>
        /// Al cargar el form, detecta que cargo tienes para permitirte o no el acceso a diferentes lugares.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuActivo.Text = Properties.Settings.Default.usuActivo;
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT cargo FROM usuarios WHERE user=@user";
                cmd.Parameters.Add("@user", MySqlDbType.Text).Value = lblUsuActivo.Text;
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cat = (String)reader[0];

                }
                Conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
            //login login = new login();
            
        }


        private void btnCaja_Menu_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Botón que da acceso al formulario de mesas para añadirles posteriormente pedidos al ticket.
        /// </summary>

        private void btnMesas_Menu_Click(object sender, EventArgs e)
        {
            Mesas mesas = new Mesas();
            mesas.Show();
            this.Close();
        }

        /// <summary>
        /// Carga el form de modificar y gestionar el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImagUsuAct_Click(object sender, EventArgs e)
        {
            InfoUsuario infoUsuario = new InfoUsuario();
            infoUsuario.usuario = Properties.Settings.Default.usuActivo;
            infoUsuario.Show();
        }

        /// <summary>
        /// Para ir a la pantalla de ajustes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
        }
    }
}
