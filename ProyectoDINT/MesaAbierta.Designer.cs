namespace ProyectoDINT
{
    partial class MesaAbierta
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblnumMesaAbierta = new System.Windows.Forms.Label();
            this.lblNumComensales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Gentium Book Basic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(28, 20);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 17);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Nº Mesa:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(27, 52);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(108, 19);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Nº Comensales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importe:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Gentium Book Basic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(150, 97);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(25, 19);
            this.lblImporte.TabIndex = 3;
            this.lblImporte.Text = "0€";
            // 
            // lblnumMesaAbierta
            // 
            this.lblnumMesaAbierta.AutoSize = true;
            this.lblnumMesaAbierta.Location = new System.Drawing.Point(151, 22);
            this.lblnumMesaAbierta.Name = "lblnumMesaAbierta";
            this.lblnumMesaAbierta.Size = new System.Drawing.Size(0, 13);
            this.lblnumMesaAbierta.TabIndex = 4;
            // 
            // lblNumComensales
            // 
            this.lblNumComensales.AutoSize = true;
            this.lblNumComensales.Location = new System.Drawing.Point(154, 56);
            this.lblNumComensales.Name = "lblNumComensales";
            this.lblNumComensales.Size = new System.Drawing.Size(0, 13);
            this.lblNumComensales.TabIndex = 5;
            // 
            // MesaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumComensales);
            this.Controls.Add(this.lblnumMesaAbierta);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Name = "MesaAbierta";
            this.Size = new System.Drawing.Size(248, 152);
            this.Click += new System.EventHandler(this.MesaAbierta_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblnumMesaAbierta;
        public System.Windows.Forms.Label lblImporte;
        public System.Windows.Forms.Label lblNumComensales;
    }
}
