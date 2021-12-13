namespace ProyectoDINT
{
    partial class cobrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtboxPago = new System.Windows.Forms.TextBox();
            this.btnCobrarFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(168, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotal.Location = new System.Drawing.Point(242, 66);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(167, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(153, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cambio:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCambio.Location = new System.Drawing.Point(242, 154);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(13, 17);
            this.lblCambio.TabIndex = 4;
            this.lblCambio.Text = "-";
            this.lblCambio.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtboxPago
            // 
            this.txtboxPago.Location = new System.Drawing.Point(245, 108);
            this.txtboxPago.Name = "txtboxPago";
            this.txtboxPago.Size = new System.Drawing.Size(76, 20);
            this.txtboxPago.TabIndex = 5;
            this.txtboxPago.TextChanged += new System.EventHandler(this.txtboxChange);
            // 
            // btnCobrarFinal
            // 
            this.btnCobrarFinal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCobrarFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarFinal.Location = new System.Drawing.Point(132, 209);
            this.btnCobrarFinal.Name = "btnCobrarFinal";
            this.btnCobrarFinal.Size = new System.Drawing.Size(135, 53);
            this.btnCobrarFinal.TabIndex = 6;
            this.btnCobrarFinal.Text = "Cobrar";
            this.btnCobrarFinal.UseVisualStyleBackColor = true;
            this.btnCobrarFinal.Click += new System.EventHandler(this.btnCobrarFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(138, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Camarero:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 290);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCobrarFinal);
            this.Controls.Add(this.txtboxPago);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cobrar";
            this.Text = "cobrar";
            this.Load += new System.EventHandler(this.cobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtboxPago;
        private System.Windows.Forms.Button btnCobrarFinal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}