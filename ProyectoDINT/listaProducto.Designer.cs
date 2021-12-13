namespace ProyectoDINT
{
    partial class listaProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctboxImagProduct = new System.Windows.Forms.PictureBox();
            this.txtboxNombProd = new System.Windows.Forms.TextBox();
            this.txtboxPrecioProd = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtboxCateg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIdProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxImagProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxImagProduct
            // 
            this.pctboxImagProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxImagProduct.Location = new System.Drawing.Point(91, 15);
            this.pctboxImagProduct.Name = "pctboxImagProduct";
            this.pctboxImagProduct.Size = new System.Drawing.Size(93, 72);
            this.pctboxImagProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxImagProduct.TabIndex = 0;
            this.pctboxImagProduct.TabStop = false;
            // 
            // txtboxNombProd
            // 
            this.txtboxNombProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxNombProd.Location = new System.Drawing.Point(216, 34);
            this.txtboxNombProd.Multiline = true;
            this.txtboxNombProd.Name = "txtboxNombProd";
            this.txtboxNombProd.ReadOnly = true;
            this.txtboxNombProd.Size = new System.Drawing.Size(295, 31);
            this.txtboxNombProd.TabIndex = 1;
            this.txtboxNombProd.Text = "Nombre Producto";
            // 
            // txtboxPrecioProd
            // 
            this.txtboxPrecioProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxPrecioProd.Location = new System.Drawing.Point(533, 35);
            this.txtboxPrecioProd.Multiline = true;
            this.txtboxPrecioProd.Name = "txtboxPrecioProd";
            this.txtboxPrecioProd.ReadOnly = true;
            this.txtboxPrecioProd.Size = new System.Drawing.Size(78, 30);
            this.txtboxPrecioProd.TabIndex = 2;
            this.txtboxPrecioProd.Text = "0,00";
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ProyectoDINT.Properties.Resources.icono_modificar_png_6;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(835, 36);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(38, 39);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.evListProd);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::ProyectoDINT.Properties.Resources.cerrar_borrar_boton_eliminar_318_9073;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(899, 36);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(43, 39);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtboxCateg
            // 
            this.txtboxCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxCateg.Location = new System.Drawing.Point(639, 36);
            this.txtboxCateg.Multiline = true;
            this.txtboxCateg.Name = "txtboxCateg";
            this.txtboxCateg.ReadOnly = true;
            this.txtboxCateg.Size = new System.Drawing.Size(159, 30);
            this.txtboxCateg.TabIndex = 6;
            this.txtboxCateg.Text = "Categoria...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 2);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(22, 42);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(13, 13);
            this.lblIdProd.TabIndex = 8;
            this.lblIdProd.Text = "0";
            // 
            // listaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxCateg);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtboxPrecioProd);
            this.Controls.Add(this.txtboxNombProd);
            this.Controls.Add(this.pctboxImagProduct);
            this.Name = "listaProducto";
            this.Size = new System.Drawing.Size(1009, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxImagProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        public System.Windows.Forms.PictureBox pctboxImagProduct;
        public System.Windows.Forms.TextBox txtboxNombProd;
        public System.Windows.Forms.TextBox txtboxPrecioProd;
        public System.Windows.Forms.TextBox txtboxCateg;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblIdProd;
    }
}
