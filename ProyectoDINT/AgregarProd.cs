using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDINT
{
    public partial class AgregarProd : Form
    {
        /// <summary>
        /// Incicialización de las variables a meter en el producto.
        /// </summary>
        public String nombProd = "";
        public String precio = "";
        public String descri = "";
        public String txtid = "";
        public String cate = "";
        public byte[] imagen;
        public Image imageIn;
        public String ruta;
        public AgregarProd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton de Agregar, guarda en variables los datos
        /// </summary>
        private void btnAgreg_Agreg_Click(object sender, EventArgs e)
        {
            nombProd = txtboxNomb_Agreg.Text;
            precio = txtboxPrecio_Agreg.Text;
            descri = txtboxDesc_Agreg.Text;
            cate = comboBox1.Text;
            Close();
        }
        /// <summary>
        /// Datos que rellenan el formulario con el producto a modificar.
        /// </summary>
        /// <param name="dataGridView1">El datagridview de donde se han sacado los valores si se va a
        /// modificar.</param>
        public void Modificar()
        {

        }
        /// <summary>
        /// Metodo que abre un dialogo para subir una imagen, filtrando los archivos que muestra.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "*.bmp;*.jpg;*.png|*.bmp;*.jpg;*.png";
            Abrir.InitialDirectory = "C:\\";
            Abrir.Title = "Selecciona imagen del producto";
            Abrir.RestoreDirectory = true;
            ruta = Abrir.FileName;
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                ruta = Abrir.FileName;
                txtboxrutaimagen.Text = ruta;
            }
        }



    }
}
