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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Formulario de productos, donde vemos los que tenemos con detalle, y nos da acceso a 
        /// introducir nuevos.
        /// </summary>
        /// <summary>
        /// Empezamos preparando la creando las variables locales donde almacenaremos los datos.
        /// </summary>

        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        DataSet ds;
        public String prod = "";
        public String prec = "";
        public String descr = "";
        public String cat = "";
        public String textid = "";
        public Image imagen;
        public String rutaimg;
        
        
            //RECARGAR ANTIGUO
        /// <summary>
        /// Evento del boton de cargar imagen, que mostrara la imagen del producto seleccionado.
        /// </summary>
       
        /*
        Conexion.Open();
        textid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
        MySqlCommand cmd = Conexion.CreateCommand();
        cmd.CommandText = "select img from productos where id=@id;";
        cmd.Parameters.Add("@id", MySqlDbType.Text).Value = textid;
        MySqlDataReader reader;
        reader = cmd.ExecuteReader();
        //byte[] imgpct = (byte[])cmd.ExecuteScalar();
        while (reader.Read())
        {
            byte[] imgpct = (byte[])reader[0];
            MemoryStream ms = new MemoryStream(imgpct);
            imagen = Image.FromStream(ms);
            pctboxProd.Image = imagen;

        }
        Conexion.Close();
        //recargar();    
    }*/
        /// <summary>
        /// Evento del botón añadir producto que abrirá un formulario de agregar producto,
        /// y si se finaliza adecuadamente, lo meterá en el control personalizado y en la BD. 
        /// </summary>

        private void btnAgreg_Prod_Click(object sender, EventArgs e)
        {
            Conexion.Close();
            AgregarProd agregarProd = new AgregarProd();
            if (DialogResult.OK == agregarProd.ShowDialog())
            {
                prod = agregarProd.nombProd;
                prec = agregarProd.precio;
                descr = agregarProd.descri;
                cat = agregarProd.cate;

                try
                {
                    MySqlCommand cmd = Conexion.CreateCommand();
                    Conexion.Open();
                    byte[] imagen = convertirAvatarAByte(agregarProd.ruta);
                    cmd.CommandText = "INSERT INTO Productos(Nombre, Precio, Descrip, categoria, img) values (@prod, @prec, @descr, @cat, @img); ";
                    cmd.Parameters.Add("@prod", MySqlDbType.Text).Value = prod;
                    cmd.Parameters.Add("@prec", MySqlDbType.Text).Value = prec;
                    cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = descr;
                    cmd.Parameters.Add("@cat", MySqlDbType.Text).Value = cat;
                    cmd.Parameters.Add("@img", MySqlDbType.MediumBlob, imagen.Length).Value = imagen;

                    cmd.ExecuteNonQuery();
                    rutaimg = agregarProd.ruta;
                    /*cmd.CommandText = "update productos set img=@img where id=@id;";
                    textid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    cmd.Parameters.Add("@id", MySqlDbType.Text).Value = textid;

                    cmd.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = agregarProd.imagen;
                    cmd.ExecuteNonQuery();*/
                    Conexion.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en la conexion" + ex.Message, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha habido un error" + ex.Message, "Error");
                }
                recargar();
            }
        }
        /// <summary>
        /// Método que convierte la imagen en bytes.
        /// </summary>
        /// <param name="filePath">Solicita la ruta de la imagén.</param>
        /// <returns>Devuelve la imagén convertida en bytes.</returns>
        public static byte[] convertirAvatarAByte(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] avatar = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return avatar;
        }
        /// <summary>
        /// Evento del botón modificar producto, que abre una pantalla de modificar producto, 
        /// a la cual, le pasa los datos del producto que esta seleccionado.
        /// </summary>
        
            //MODIFICAR ANTIGUO
        /*Conexion.Close();
        AgregarProd agregarProd = new AgregarProd();
        agregarProd.Modificar(dataGridView1);
        //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = id;
        if (DialogResult.OK == agregarProd.ShowDialog())
        {
            prod = agregarProd.nombProd;
            prec = agregarProd.precio;
            descr = agregarProd.descri;
            cat = agregarProd.cate;


            try
            {
                byte[] imagen = convertirAvatarAByte(agregarProd.ruta);
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
            recargar();
        }

    }*/

            //BORRAR ANTIGUO
        /// <summary>
        /// Evento del botón borrar, que elimina el producto seleccionado del DGV y de la BD.
        /// </summary>

        
            /*Conexion.Close();
            try
            {
                String textid = "";
                textid = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                MySqlCommand cmd = Conexion.CreateCommand();
                Conexion.Open();
                cmd.CommandText = "DELETE FROM Productos WHERE ID=@id;";
                cmd.Parameters.Add("@id", MySqlDbType.Text).Value = textid;
                cmd.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hay un error en la conexion", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado", "Error");
            }
            recargar();

        }
        */
        
        /// <summary>
        /// Metodo para leer la bbdd y mostrar todos los productos en su control personalizado
        /// </summary>
        public void recargar()
        {
            try
            {
                flowLyPanel.Controls.Clear();
                Conexion.Close();
                Conexion.Open();
                MySqlCommand cmd = Conexion.CreateCommand();
                //Conexion.Open();
                cmd.CommandText = "SELECT * FROM productos;";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaProducto listaProducto = new listaProducto();
                    listaProducto.eventoListProd += new EventHandler(producto_Click);
                    listaProducto.eventoListBorrar += new EventHandler(borrar_click);
                    flowLyPanel.Controls.Add(listaProducto);
                    String auxID = reader[0].ToString();
                    String auxNom = (String)reader[1];
                    float auxPrec = (float)reader[2];
                    String auxCateg = (String)reader[4];
                    listaProducto.txtboxNombProd.Text = auxNom;
                    listaProducto.txtboxPrecioProd.Text = auxPrec.ToString();
                    listaProducto.txtboxCateg.Text = auxCateg;
                    listaProducto.lblIdProd.Text = auxID;
                    byte[] imgpct = (byte[])reader[5];
                    MemoryStream ms = new MemoryStream(imgpct);
                    imagen = Image.FromStream(ms);
                    listaProducto.pctboxImagProduct.Image = imagen;
                }
                Conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }

        /// <summary>
        /// Evento del botón borrar, que elimina el producto de la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrar_click(object sender, EventArgs e)
        {
            try
            {
                listaProducto listaProducto = sender as listaProducto;
                MySqlCommand cmd = Conexion.CreateCommand();

                Conexion.Open();
                cmd.CommandText = "DELETE FROM Productos WHERE ID=@id;";
                cmd.Parameters.Add("@id", MySqlDbType.Text).Value = listaProducto.lblIdProd.Text;
                cmd.ExecuteNonQuery();
                flowLyPanel.Controls.Clear();
                Conexion.Close();
                recargar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }

        /*try
{
   Conexion.Open();
   MySqlCommand mostrar = new MySqlCommand("SELECT id,nombre,precio,descrip,categoria FROM Productos", Conexion);

   MySqlDataAdapter m_datos = new MySqlDataAdapter(mostrar);
   ds = new DataSet();
   m_datos.Fill(ds);
   dataGridView1.DataSource = ds.Tables[0];

   Conexion.Close();
}
catch (MySqlException ex)
{
   MessageBox.Show("Hay un error en la conexion" + ex.Message, "Error");
}
catch (Exception ex)
{
   MessageBox.Show("Ha ocurrido un fallo", "Error");
}*/

        /// <summary>
        /// Evento del botón modificar producto, que abre una pantalla de modificar producto, 
        /// a la cual, le pasa los datos del producto que esta seleccionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void producto_Click(object sender, EventArgs e)
        {
            listaProducto listaProducto = sender as listaProducto;
            AgregarProd agregarProd = new AgregarProd();
            agregarProd.txtboxNomb_Agreg.Text = listaProducto.txtboxNombProd.Text;
            agregarProd.txtboxPrecio_Agreg.Text = listaProducto.txtboxPrecioProd.Text;
            agregarProd.comboBox1.Text = listaProducto.txtboxCateg.Text;
            //agregarProd.Modificar(flowLyPanel);
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = id;
            if (DialogResult.OK == agregarProd.ShowDialog())
            {
                prod = agregarProd.nombProd;
                prec = agregarProd.precio;
                descr = agregarProd.descri;
                cat = agregarProd.cate;


                try
                {
                    byte[] imagen = convertirAvatarAByte(agregarProd.ruta);
                    MySqlCommand cmd = Conexion.CreateCommand();
                    Conexion.Open();
                    cmd.CommandText = "UPDATE Productos SET Nombre=@nomb,Precio=@prec, Descrip= @descr, categoria=@cat, img=@img WHERE ID=@id;";
                    cmd.Parameters.Add("@nomb", MySqlDbType.Text).Value = prod;
                    cmd.Parameters.Add("@prec", MySqlDbType.Text).Value = prec;
                    cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = descr;
                    cmd.Parameters.Add("@cat", MySqlDbType.Text).Value = cat;
                    cmd.Parameters.Add("@img", MySqlDbType.MediumBlob, imagen.Length).Value = imagen;
                    //cmd.Parameters.Add("@img", MySqlDbType.Binary).Value = agregarProd.imagen;
                    cmd.Parameters.Add("@id", MySqlDbType.Text).Value = listaProducto.lblIdProd.Text;
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
                recargar();
            }
        }

        /// <summary>
        /// Cuando carga el form llama a recargar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void productos_Load(object sender, EventArgs e)
        {
            Conexion.Close();
            recargar();
        }

        /// <summary>
        /// Boton de salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtras_prod_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
