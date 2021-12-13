namespace botonprod
{
    partial class UserControl1
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
            this.pctbxPers = new System.Windows.Forms.PictureBox();
            this.lblPers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPers)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbxPers
            // 
            this.pctbxPers.Location = new System.Drawing.Point(3, 3);
            this.pctbxPers.Name = "pctbxPers";
            this.pctbxPers.Size = new System.Drawing.Size(132, 135);
            this.pctbxPers.TabIndex = 0;
            this.pctbxPers.TabStop = false;
            // 
            // lblPers
            // 
            this.lblPers.AutoSize = true;
            this.lblPers.Location = new System.Drawing.Point(54, 141);
            this.lblPers.Name = "lblPers";
            this.lblPers.Size = new System.Drawing.Size(35, 13);
            this.lblPers.TabIndex = 1;
            this.lblPers.Text = "label1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPers);
            this.Controls.Add(this.pctbxPers);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(138, 157);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxPers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbxPers;
        private System.Windows.Forms.Label lblPers;
    }
}
