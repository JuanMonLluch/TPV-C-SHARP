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
    public partial class InfoUsuario : Form
    {
        public InfoUsuario()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");

        public String usuario;

        private void InfoUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                lblContrIncorrecta.Visible = false;
                txtboxNombUsu_infoUsu.Enabled = false;
                txtboxPass_infoUsu.Enabled = false;
                txtboxRepPass_infoUsu.Enabled = false;
                cmboxCargo_infoUsu.Enabled = false;
                button1.Enabled = false;
                txtboxPass_infoUsu.UseSystemPasswordChar = true;
                //txtboxPass_infoUsu.PasswordChar = '*';

                Conexion.Close();
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuarios where user=@user";
                cmd.Parameters.Add("@user", MySqlDbType.Text).Value = usuario;
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtboxNombUsu_infoUsu.Text = (string)reader[0];
                    txtboxPass_infoUsu.Text = (string)reader[1];
                    cmboxCargo_infoUsu.Text = (string)reader[2];
                }
                Conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
            
            
        }

        private void chckboxEdicion_infoUsu_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxEdicion_infoUsu.CheckState == CheckState.Checked)
            {
                txtboxNombUsu_infoUsu.Enabled = true;
                txtboxPass_infoUsu.Enabled = true;
                txtboxRepPass_infoUsu.Enabled = true;
                cmboxCargo_infoUsu.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                txtboxNombUsu_infoUsu.Enabled = false;
                txtboxPass_infoUsu.Enabled = false;
                txtboxRepPass_infoUsu.Enabled = false;
                cmboxCargo_infoUsu.Enabled = false;
                button1.Enabled = false;
            }
            
        }

        private void btnCancelar_infoUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtboxPass_infoUsu.UseSystemPasswordChar == true)
            {
                txtboxPass_infoUsu.UseSystemPasswordChar = false;
                txtboxRepPass_infoUsu.UseSystemPasswordChar = false;
            }
            else if(txtboxPass_infoUsu.UseSystemPasswordChar == false)
            {
                txtboxPass_infoUsu.UseSystemPasswordChar = true;
                txtboxRepPass_infoUsu.UseSystemPasswordChar = true;
            }
            
        }

        private void btnAceptar_infoUsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (chckboxEdicion_infoUsu.CheckState == CheckState.Checked)
                {
                    if (txtboxPass_infoUsu.Text == txtboxRepPass_infoUsu.Text)
                    {
                        lblContrIncorrecta.Visible = false;
                        Conexion.Close();
                        Conexion.Open();
                        MySqlCommand cmd = Conexion.CreateCommand();
                        cmd.CommandText = "UPDATE usuarios SET user=@user, password=@psw, cargo=@cargo where user=@usu";
                        cmd.Parameters.Add("@user", MySqlDbType.Text).Value = txtboxNombUsu_infoUsu.Text;
                        cmd.Parameters.Add("@psw", MySqlDbType.Text).Value = txtboxPass_infoUsu.Text;
                        cmd.Parameters.Add("@cargo", MySqlDbType.Text).Value = cmboxCargo_infoUsu.SelectedItem;
                        cmd.Parameters.Add("@usu", MySqlDbType.Text).Value = usuario;
                        cmd.ExecuteNonQuery();
                        Conexion.Close();
                        this.Close();
                    }
                    else
                    {
                        lblContrIncorrecta.Visible = true;
                    }

                }
                else if (chckboxEdicion_infoUsu.CheckState == CheckState.Unchecked)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}
