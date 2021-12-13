using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoDINT
{
    public partial class listaProducto : UserControl
    {
        /// <summary>
        /// Control personalizado de los productos
        /// </summary>
        public listaProducto()
        {
            InitializeComponent();
        }

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");

        public event EventHandler eventoListProd;
        public event EventHandler eventoListBorrar;

        public String nombProd;
        public String precioProd;
        public String catProd;
        public String idProd;

        //public String cantProd;

        public String prodListProd
        {
            set { nombProd = value; }
            get { return nombProd; }
        }

        public String precListProd
        {
            set {precioProd = value; }
            get { return precioProd; }
        }

        public String catListProd
        {
            set { catProd = value; }
            get { return catProd; }
        }

        public String idListProd
        {
            set { idListProd = value; }
            get { return idListProd; }
        }

        

        private void evListProd(object sender, EventArgs e)
        {
            if (eventoListProd != null)
                eventoListProd(this, e);
            /*AgregarProd agregarProd = new AgregarProd();
            if (DialogResult.OK == agregarProd.ShowDialog())
            {
                txtboxNombProd.Text = agregarProd.nombProd;
                txtboxPrecioProd.Text = agregarProd.precio;
                txtboxCateg.Text = agregarProd.cate;

                try
                {
                    //byte[] imagen = convertirAvatarAByte(agregarProd.ruta);
                    MySqlCommand cmd = Conexion.CreateCommand();
                    Conexion.Open();
                    cmd.CommandText = "UPDATE Productos SET Nombre=@nomb,Precio=@prec, Descrip= @descr, categoria=@cat, img=@img WHERE ID=@id;";
                    cmd.Parameters.Add("@nomb", MySqlDbType.Text).Value = prod;
                    cmd.Parameters.Add("@prec", MySqlDbType.Text).Value = prec;
                    cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = descr;
                    cmd.Parameters.Add("@cat", MySqlDbType.Text).Value = cat;
                    cmd.Parameters.Add("@img", MySqlDbType.MediumBlob, imagen.Length).Value = imagen;
                    //cmd.Parameters.Add("@img", MySqlDbType.Binary).Value = agregarProd.imagen;
                    cmd.Parameters.Add("@id", MySqlDbType.Text).Value = agregarProd.txtid;
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la conexion", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha habido un error", "Error");
                }
            }*/
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (eventoListBorrar != null)
                eventoListBorrar(this, e);
            /*try
            {
                
                MySqlCommand cmd = Conexion.CreateCommand();

                Conexion.Open();
                cmd.CommandText = "DELETE FROM Productos WHERE ID=@id;";
                cmd.Parameters.Add("@id", MySqlDbType.Text).Value = lblIdProd.Text;
                cmd.ExecuteNonQuery();
                productos productos = new productos();
                productos.flowLyPanel.Controls.Clear();
                
                MessageBox.Show("Argggg");
                Conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hay un error en la conexion", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado" + ex, "Error");
            }*/

        }
    }
}
