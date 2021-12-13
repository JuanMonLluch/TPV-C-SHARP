namespace ProyectoDINT
{
    partial class BotonProd
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
            this.pctboxProd = new System.Windows.Forms.PictureBox();
            this.lblProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pctboxProd
            // 
            this.pctboxProd.BackColor = System.Drawing.SystemColors.Control;
            this.pctboxProd.Location = new System.Drawing.Point(3, 3);
            this.pctboxProd.Name = "pctboxProd";
            this.pctboxProd.Size = new System.Drawing.Size(139, 120);
            this.pctboxProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxProd.TabIndex = 0;
            this.pctboxProd.TabStop = false;
            this.pctboxProd.Click += new System.EventHandler(this.hola);
            // 
            // lblProd
            // 
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(0, 107);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(145, 16);
            this.lblProd.TabIndex = 1;
            this.lblProd.Text = "label1";
            this.lblProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.pctboxProd);
            this.Name = "BotonProd";
            this.Size = new System.Drawing.Size(145, 147);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblProd;
        public System.Windows.Forms.PictureBox pctboxProd;
    }
}
