using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoDINT
{
    public partial class Registro : Form
    {
        /// <summary>
        /// Se declaran las variables globales.
        /// </summary>
        String cargo = "";
        String usuario = "";
        String contraseña = "";
        String repContraseña = "";
        public Registro()
        {
            InitializeComponent();
        }

        private void lblRepContraseña_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Método del botón cancelar que vuelve al login.
        /// </summary>

        private void btnCancelarReg_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }


        /// <summary>
        /// Método del botón regstrarse, que comprueba que todo esta rellenado correctamente,
        /// y lo introduce en la base de datos de usuarios.
        /// </summary>

        private void btnRegRegistrar_Click(object sender, EventArgs e)
        {
            contraseña = txtBoxContraseña.Text;
            repContraseña = txtBoxRepContr.Text;
            cargo = cmbobox_Registro.Text;
            usuario = txtBoxUsuario.Text;
            
            if(cargo == "") {
                lblError.Text = "El campo del cargo esta vacio";
                lblError.Visible = true;
            }
            else if(usuario == "")
            {
                lblError.Text = "El campo del usuario esta vacio";
                lblError.Visible = true;
            }
            else if(contraseña.Length < 6)
            {
                lblError.Text = "La contraseña debe tener 6 o mas carácteres";
                lblError.Visible = true;
            }
            else if (contraseña == "")
            {
                lblError.Text = "El campo de la contraseña esta vacio";
                lblError.Visible = true;
            }
            else if (repContraseña == "")
            {
                lblError.Text = "El campo de repetir la contraseña esta vacio";
                lblError.Visible = true;
            }
            else if (contraseña != repContraseña)
            {
                lblError.Text = "Las contraseñas no coinciden";
                lblError.Visible = true;
            }
            else
            {
                try
                {
                    MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
                    Conexion.Open();
                    MySqlCommand cmd = Conexion.CreateCommand();
                    cmd.CommandText = "INSERT INTO usuarios(user, password, cargo) VALUES (@usu, @pass, @cargo); ";
                    cmd.Parameters.Add("@usu", MySqlDbType.Text).Value = usuario;
                    cmd.Parameters.Add("@pass", MySqlDbType.Text).Value = contraseña;
                    cmd.Parameters.Add("@cargo", MySqlDbType.Text).Value = cargo;
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    MessageBox.Show("Usuario registrado correctamente", "Info");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show( "Fallo en la conexion" + ex, "Error");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
                
                
                Close();
            }
                
        }
    }
}
