namespace ProyectoDINT
{
    partial class BotonMesas
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
            this.btnMesaNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesaNum
            // 
            this.btnMesaNum.BackColor = System.Drawing.Color.Transparent;
            this.btnMesaNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesaNum.Location = new System.Drawing.Point(46, 41);
            this.btnMesaNum.Name = "btnMesaNum";
            this.btnMesaNum.Size = new System.Drawing.Size(178, 90);
            this.btnMesaNum.TabIndex = 0;
            this.btnMesaNum.Text = "button1";
            this.btnMesaNum.UseVisualStyleBackColor = false;
            this.btnMesaNum.Click += new System.EventHandler(this.hola);
            // 
            // BotonMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDINT.Properties.Resources.piso_madera_clara_53876_92977;
            this.Controls.Add(this.btnMesaNum);
            this.Name = "BotonMesas";
            this.Size = new System.Drawing.Size(267, 173);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnMesaNum;
    }
}
