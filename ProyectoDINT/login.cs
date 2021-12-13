using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputKey;
namespace ProyectoDINT
{
    public partial class login : Form
    {
        /// <summary>
        /// Formulario de login.
        /// </summary>
        public login()
        {
            InitializeComponent();
        }

        public string UsuActivo;
        string clvProp;
        //bool cont;
        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");

        /// <summary>
        /// Método que al cargar el formulario de login muestra el cuadro de ayuda si es la primera vez que entras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Estado_login = true;
            //Properties.Settings.Default.Save();

            if (/*cont == false &&*/ Properties.Settings.Default.Estado_login == true )
            {
                //clvProp = InputDialog.mostrar("Introduce una clave de seguridad o clave propietario, sera solicitada a la hora de crear usuarios, recuperar contraseñas u otras acciones.");
                //cont = true;
                //Properties.Settings.Default.Estado_login = false;
                //Properties.Settings.Default.Save();
                var result = MessageBox.Show("Es tu primera vez, ¿Deseas ver el video de ayuda para aprender el manejo del programa? Posteriormente podras acceder a él desde la sección de ayuda", "Ayuda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Tutorial tutorial = new Tutorial();
                    tutorial.ShowDialog();
                }



            }
            
            label4.Visible = false;
        }
        /// <summary>
        /// Evento de botón olvide conrtraseña, que lleva a un nuevo formulario donde recuperarla.
        /// </summary>
        private void lnkContOlvid_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecCont recCont = new RecCont();
            recCont.Show();
            /*String clvSeg = InputDialog.mostrar("Introduce la clave propietario", "Autentificación");
            if (clvSeg == clvProp)
            {
                RecCont recCont = new RecCont();
                recCont.Show();
            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

        }
        /// <summary>
        /// Botón para logearte que comprueba tus datos en la BD.
        /// </summary>
        private void btnLogin_login_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT user, password FROM usuarios;";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String nomb = (String)reader[0];
                    String pass = Convert.ToString(reader[1]);
                    
                    if (txtboxUsuario_login.Text == nomb && txtboxPass_login.Text == pass)
                    {
                        Menu menu = new Menu();
                        Properties.Settings.Default.usuActivo = txtboxUsuario_login.Text;
                        Properties.Settings.Default.Save();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        label4.Visible = true;
                    }
                }
                Conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "info");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error", "Error");
            }
        }
        /// <summary>
        /// Evento del botón de registro, que lleva a un form donde nos podemos registrar.
        /// </summary>
        private void lnkRegistrar_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            /*String clvSeg = InputDialog.mostrar("Introduce la clave propietario", "Autentificación");
            if (clvSeg == clvProp)
            {
                Registro registro = new Registro();
                registro.Show();
            }
            else
            {
                MessageBox.Show("Clave incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            
        }
        /// <summary>
        /// Metodo para hacer lo mismo que el login_onclick pero al pulsar INTRO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtboxPass_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    Conexion.Open();
                    MySqlCommand cmd = Conexion.CreateCommand();
                    cmd.CommandText = "SELECT user, password FROM usuarios;";
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        String nomb = (String)reader[0];
                        String pass = Convert.ToString(reader[1]);
                        if (txtboxUsuario_login.Text == nomb && txtboxPass_login.Text == pass)
                        {
                            Menu menu = new Menu();
                            Properties.Settings.Default.usuActivo = txtboxUsuario_login.Text;
                            Properties.Settings.Default.Save();
                            menu.Show();
                            this.Close();
                        }
                        else
                        {
                            label4.Visible = true;
                        }
                    }
                    Conexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "info");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }
    }
}
