using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    public partial class RecCont : Form
    {
        public RecCont()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        String psw;
        bool aux=true;

        /// <summary>
        /// Metodo Onclick para enviar un correo de recuperar contraseña a traves de smtp send Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            try
            {
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT user, password FROM usuarios WHERE user=@user;";   
                cmd.Parameters.Add("@user", MySqlDbType.Text).Value = txtboxUsuCorr_RecCont.Text;
                reader = cmd.ExecuteReader();
                
                if (reader.Read() )
                {
                   // if (txtboxUsuCorr_RecCont.Text == Convert.ToString(reader[0]))
                    //{
                        aux = false;
                        psw = Convert.ToString(reader[1]);
                    //}
                }
                else
                {
                    aux = true;
                }
                if (aux == true)
                {
                    MessageBox.Show("El usuario no corresponde con ninguno existente", "Info");
                }
                Conexion.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "info");
            }
            catch(Exception er)
            {
                MessageBox.Show("Ha habido un error", "info");
            }
            if (aux == false)
            {

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(txtboxEmail_RecCont.Text));
                email.From = new MailAddress("tpvdint@gmail.com");
                email.Subject = " TPV (" + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + ")";
                email.Body = "La contraseña para el usuario " + txtboxUsuCorr_RecCont.Text + " es: " + psw + "\nsi usted no ha solicitado la recuperación de la contraseña, por favor notifiquenoslo y borre el correo de inmediato. Muchas gracias" ;
                email.IsBodyHtml = false;
                email.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("tpvdint@gmail.com", "rootroot");

                try
                {
                    smtp.Send(email);
                    email.Dispose();
                    MessageBox.Show("Correo enviado correctamente", "info");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha habido algun fallo" + ex.Message, "info");
                }
            }
        }
    }
}
