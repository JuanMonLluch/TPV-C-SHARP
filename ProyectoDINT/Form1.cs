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
    
    public partial class Form1 : Form
    {

        /// <summary>
        /// Formulario de productos en el que se hace el ticket.
        /// </summary>
        /// <param name="cat">Recoge el parametro categoria para filtrar los productos a mostrar.</param>
        public Form1() 
            {

            InitializeComponent();
            
            cargaProds();
            CargarCat();
        }
        /// <summary>
        /// Declaración de variables globales y conectando con BBDD.
        /// </summary>
        MySqlConnection Conexion = new MySqlConnection("server=localhost; database=tpvs; Uid=root; pwd=");
        String cate;
        public String prod = "";
        public int prec;
        public String textid = "";
        bool auxProd;
        public double total;
        double noIva;
        double iva;
        double auxprecio;
        int aux;
        public string mesa="";
        bool auxEstado=true;
        public String auxNumMesa;
        public String camarero;
        /// <summary>
        /// Metodo que carga los productos dinamicamente de la categoria que el formulario a recogido,
        /// creando un evento de cada uno de ellos.
        /// </summary>
        private void cargaProds() 
            {
            try 
                {
                flowLayoutPanel1.Controls.Clear();
                Conexion.Open();

                MySqlDataReader reader;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT id, nombre, img, precio FROM Productos WHERE categoria = @cat;";
                cmd.Parameters.Add("@cat", MySqlDbType.Text).Value = cate;
                reader = cmd.ExecuteReader();
                BotonProd boton = null;
                while (reader.Read()) {
                    boton = new BotonProd();
                    boton.evento += new EventHandler(BotonProd_OnClick);
                    flowLayoutPanel1.Controls.Add(boton);
                    byte[] imgpct = (byte[])reader[2];
                    MemoryStream ms = new MemoryStream(imgpct);
                    Image imagen = Image.FromStream(ms);
                    boton.pctboxProd.Image = imagen;
                    boton.lblProd.Text = (string)reader[1];
                    boton.produ = (string)reader[1];
                    boton.prec = reader[3].ToString();
                }
                Conexion.Close();
            } catch (MySqlException ex) {
                MessageBox.Show("Hay un error en la conexion" + ex.Message, "Error");
            } catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un fallo" + ex.Message, "Error");
            }
        }

        /// <summary>
        /// Carga las categorias
        /// </summary>
        private void CargarCat()
        {
            try
            {
                Conexion.Open();
                MySqlDataReader reader;
                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT categoria FROM productos;";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    controlCat boton = new controlCat();
                    boton.evento += new EventHandler(controlCat_OnClick);
                    flowLayoutPanel2.Controls.Add(boton);
                    string categor = reader[0].ToString();
                    boton.btnCategoria.Text = categor;
                    boton.cat = categor;
                    //boton.Width = 220;
                    //boton.Height = 170;
                }
                Conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hay un error en la conexion" + ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un fallo" + ex.Message, "Error");
            }
        }

        private void controlCat_OnClick(object sender, EventArgs e)
        {

            controlCat categoria = sender as controlCat;
            cate = categoria.cat.ToString();
            cargaProds();
            
        }

        /// <summary>
        /// Evento en cada boton de producto, que añade fila de producto en el ticket si no existe,
        /// y aumenta el campo cantidad si existe.
        /// </summary>

        private void BotonProd_OnClick(object sender, EventArgs e) {

            BotonProd prod = sender as BotonProd;

            bool auxProd = false;

            for (int i = 0; i < dataGridView1.RowCount; i++) {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == prod.produ) {
                    //MessageBox.Show("err" + dataGridView1.Rows[i].Cells[4].Value);
                    aux = (int)dataGridView1.Rows[i].Cells[3].Value;
                    aux++;
                    dataGridView1.Rows[i].Cells[3].Value = aux;
                    auxprecio = aux * Convert.ToInt32(prod.prec);
                    dataGridView1.Rows[i].Cells[5].Value = auxprecio;
                    auxProd = true;
                    //total = auxprecio + total;
                }
            }

            if (auxProd == false) {
                int fila = dataGridView1.Rows.Add();
                dataGridView1.Rows[fila].Cells[3].Value = 1;
                dataGridView1.Rows[fila].Cells[4].Value = prod.produ;
                dataGridView1.Rows[fila].Cells[5].Value = prod.prec;
                dataGridView1.Rows[fila].Cells[6].Value = prod.prec;

                aux = 1;
            }
            sacarTotal();
        }
        /// <summary>
        /// Metodo que calcula el precio sin IVA, el IVA y el total.
        /// </summary>
        private void sacarTotal() {
            total = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++) {

                Double cantidad = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                total = total + cantidad;
            }
            label5.Text = total.ToString() + " €";
            noIva = (total / 1.21);
            iva = total - noIva;
            noIva = Math.Round(noIva, 2);
            iva = Math.Round(iva, 2);
            label6.Text = iva.ToString() + " €";
            label2.Text = noIva.ToString() + " €";


        }


        private void label1_Click(object sender, EventArgs e) {

        }
        /// <summary>
        /// Al cargar el form carga un label con el numero de mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            Mesas mesas = new Mesas();
            //lblNumMesa.Text = mesas.numMesa;
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
        /// <summary>
        /// Botón para ir al menu principal. En caso de no haber cobrado el ticket lo guarda en la bbdd para abrirlo mas tarde.
        /// </summary>        
        private void button1_Click(object sender, EventArgs e) {

            BotonMesas botonMesas = sender as BotonMesas;
            try
            {
                Conexion.Open();

                MySqlCommand cmd = Conexion.CreateCommand();
                cmd.CommandText = "SELECT count(*) from comandas where mesa=@numMesa;";
                cmd.Parameters.Add("@numMesa", MySqlDbType.String).Value = auxNumMesa;

                //MessageBox.Show(auxNumMesa, auxNumMesa, MessageBoxButtons.OK);
                String auxNumReg = Convert.ToString(cmd.ExecuteScalar());
                Conexion.Close();

                //MessageBox.Show(auxNumReg, auxNumReg, MessageBoxButtons.OK);

                if (auxEstado == true && (label5.Text == "0 €") == false && (label5.Text == "-") == false && (auxNumReg == "0 €") == false)
                {
                    //MessageBox.Show("yupiiii", "iiiiijaaaaaaa", MessageBoxButtons.OK);
                    Conexion.Open();
                    cmd = Conexion.CreateCommand();
                    cmd.CommandText = "delete from comandas where mesa = @numMesa;";
                    cmd.Parameters.Add("@numMesa", MySqlDbType.String).Value = auxNumMesa;
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                    int auxFilasDTG = dataGridView1.Rows.Count;
                    //MessageBox.Show(auxFilasDTG.ToString(), auxFilasDTG.ToString(), MessageBoxButtons.OK);
                    int i = 0;
                    Conexion.Open();
                    while (i < auxFilasDTG)
                    {

                        //MessageBox.Show(Convert.ToString(i), "hii", MessageBoxButtons.OK);

                        cmd = Conexion.CreateCommand();
                        cmd.CommandText = "INSERT INTO comandas(productos, cantidad, precio, precioud, mesa, estado) VALUES (@productos, @cantidad, @precio, @precioud, @mesa, @estado); ";
                        cmd.Parameters.Add("@productos", MySqlDbType.Text).Value = dataGridView1.Rows[i].Cells[4].Value;
                        cmd.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[3].Value;
                        cmd.Parameters.Add("@precio", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[5].Value;
                        cmd.Parameters.Add("@precioud", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[6].Value;
                        cmd.Parameters.Add("@mesa", MySqlDbType.Int32).Value = auxNumMesa;
                        cmd.Parameters.Add("@estado", MySqlDbType.Text).Value = "True";
                        cmd.ExecuteNonQuery();
                        i++;
                    }
                    Conexion.Close();
                    Conexion.Open();
                    cmd = Conexion.CreateCommand();
                    cmd.CommandText = "INSERT INTO comandas(mesa, total, iva, noIva) Values(@mesa, @total, @iva, @noIva);";
                    cmd.Parameters.Add("@mesa", MySqlDbType.Int32).Value = auxNumMesa;
                    cmd.Parameters.Add("@total", MySqlDbType.Float).Value = total;
                    cmd.Parameters.Add("@iva", MySqlDbType.Float).Value = iva;
                    cmd.Parameters.Add("@noIva", MySqlDbType.Float).Value = noIva;
                    cmd.ExecuteNonQuery();
                    Conexion.Close();
                }
                /*Mesas mesas = new Mesas();
                MesaAbierta mesaAbierta = new MesaAbierta();
                mesas.flowLayoutPanel2.Controls.Clear();
                mesaAbierta.eventoMesaAbierta += new EventHandler(mesabierta_onClick);
                mesaAbierta.lblnumMesaAbierta.Text = auxNumMesa;
                mesaAbierta.lblImporte.Text = label5.Text;
                mesaAbierta.lblNumComensales.Text = "0";
                mesas.flowLayoutPanel2.Controls.Add(mesaAbierta);
                */
                Mesas mesas = new Mesas();
                mesas.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
        }

        /*private void mesabierta_onClick(object sender, EventArgs e)
        {
            MessageBox.Show("hiii", "hii", MessageBoxButtons.OK);
        }*/

        /// <summary>
        /// Botón que lleva a la pantalla de cobro, y carga en la base de datos el importe.
        /// </summary>
        private void btnCobrar_Click(object sender, EventArgs e) {
            try
            {
                if (label5.Text == "0 €" || label5.Text == "-")
                {
                    MessageBox.Show("La cuenta esta vacia", "Error");
                }
                else
                {
                    Mesas mesas = new Mesas();
                    cobrar cobrar = new cobrar();
                    cobrar.aux4 = Convert.ToInt32(label5.Text.TrimEnd('€'));
                    //cobrar.ShowDialog();
                    if (DialogResult.OK == cobrar.ShowDialog())
                    {
                        camarero = cobrar.comboBox1.Text;
                        Conexion.Open();
                        MySqlCommand cmd = Conexion.CreateCommand();
                        cmd.CommandText = "INSERT into cobros (mesa, importe, fecha, camarero) values (@mesa, @importe, @fecha, @camarero);";
                        cmd.Parameters.Add("@mesa", MySqlDbType.Int32).Value = auxNumMesa;
                        cmd.Parameters.Add("@importe", MySqlDbType.Float).Value = label5.Text.TrimEnd('€');
                        cmd.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@camarero", MySqlDbType.Text).Value = camarero;
                        cmd.ExecuteNonQuery();
                        auxEstado = false;
                        Conexion.Close();
                        Conexion.Open();
                        cmd.CommandText = "DELETE FROM comandas where mesa=@mesaa";
                        cmd.Parameters.Add("@mesaa", MySqlDbType.Int32).Value = auxNumMesa;
                        cmd.ExecuteNonQuery();
                        Conexion.Close();
                        mesas.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK);
            }
            
            
        }
        /// <summary>
        /// Método que maneja los botones del data grid view, añadiento productos, restando y eliminando
        /// lineas completas.
        /// </summary>

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            double aux2;
            if (e.ColumnIndex == 0) {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                sacarTotal();

            } else if (e.ColumnIndex == 1) {
                aux = (int)dataGridView1.CurrentRow.Cells[3].Value;
                aux++;
                dataGridView1.CurrentRow.Cells[3].Value = aux;
                aux2 = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);
                auxprecio = aux * aux2;
                dataGridView1.CurrentRow.Cells[5].Value = auxprecio;
                sacarTotal();
            } else if (e.ColumnIndex == 2) {
                if ((int)dataGridView1.CurrentRow.Cells[3].Value > 1) {
                    aux = (int)dataGridView1.CurrentRow.Cells[3].Value;
                    aux--;
                    dataGridView1.CurrentRow.Cells[3].Value = aux;
                    aux2 = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);
                    auxprecio = aux * aux2;
                    dataGridView1.CurrentRow.Cells[5].Value = auxprecio;
                    sacarTotal();
                } else {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    sacarTotal();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket impreso", "Ticket", MessageBoxButtons.OK);
        }
    }
}









































