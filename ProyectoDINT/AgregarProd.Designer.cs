namespace ProyectoDINT
{
    partial class AgregarProd
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
            this.lblNomb_Agreg = new System.Windows.Forms.Label();
            this.lblPrecio_Agreg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNomb_Agreg = new System.Windows.Forms.TextBox();
            this.txtboxPrecio_Agreg = new System.Windows.Forms.TextBox();
            this.txtboxDesc_Agreg = new System.Windows.Forms.TextBox();
            this.btnAgreg_Agreg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxrutaimagen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomb_Agreg
            // 
            this.lblNomb_Agreg.AutoSize = true;
            this.lblNomb_Agreg.Location = new System.Drawing.Point(70, 83);
            this.lblNomb_Agreg.Name = "lblNomb_Agreg";
            this.lblNomb_Agreg.Size = new System.Drawing.Size(93, 13);
            this.lblNomb_Agreg.TabIndex = 0;
            this.lblNomb_Agreg.Text = "Nombre Producto:";
            // 
            // lblPrecio_Agreg
            // 
            this.lblPrecio_Agreg.AutoSize = true;
            this.lblPrecio_Agreg.Location = new System.Drawing.Point(123, 116);
            this.lblPrecio_Agreg.Name = "lblPrecio_Agreg";
            this.lblPrecio_Agreg.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio_Agreg.TabIndex = 1;
            this.lblPrecio_Agreg.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripción:";
            this.label1.Visible = false;
            // 
            // txtboxNomb_Agreg
            // 
            this.txtboxNomb_Agreg.Location = new System.Drawing.Point(201, 80);
            this.txtboxNomb_Agreg.Name = "txtboxNomb_Agreg";
            this.txtboxNomb_Agreg.Size = new System.Drawing.Size(247, 20);
            this.txtboxNomb_Agreg.TabIndex = 1;
            this.txtboxNomb_Agreg.Tag = "";
            // 
            // txtboxPrecio_Agreg
            // 
            this.txtboxPrecio_Agreg.Location = new System.Drawing.Point(201, 116);
            this.txtboxPrecio_Agreg.Name = "txtboxPrecio_Agreg";
            this.txtboxPrecio_Agreg.Size = new System.Drawing.Size(247, 20);
            this.txtboxPrecio_Agreg.TabIndex = 2;
            // 
            // txtboxDesc_Agreg
            // 
            this.txtboxDesc_Agreg.Location = new System.Drawing.Point(201, 154);
            this.txtboxDesc_Agreg.Name = "txtboxDesc_Agreg";
            this.txtboxDesc_Agreg.Size = new System.Drawing.Size(247, 20);
            this.txtboxDesc_Agreg.TabIndex = 3;
            this.txtboxDesc_Agreg.Visible = false;
            // 
            // btnAgreg_Agreg
            // 
            this.btnAgreg_Agreg.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgreg_Agreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgreg_Agreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgreg_Agreg.Location = new System.Drawing.Point(339, 311);
            this.btnAgreg_Agreg.Name = "btnAgreg_Agreg";
            this.btnAgreg_Agreg.Size = new System.Drawing.Size(109, 47);
            this.btnAgreg_Agreg.TabIndex = 6;
            this.btnAgreg_Agreg.Text = "Agregar";
            this.btnAgreg_Agreg.UseVisualStyleBackColor = true;
            this.btnAgreg_Agreg.Click += new System.EventHandler(this.btnAgreg_Agreg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bebidas",
            "Entrantes",
            "Primeros",
            "Segundos",
            "Bocatas",
            "Postres",
            "Cafes"});
            this.comboBox1.Location = new System.Drawing.Point(201, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Escoge categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imagen:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Examinar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxrutaimagen
            // 
            this.txtboxrutaimagen.Location = new System.Drawing.Point(201, 229);
            this.txtboxrutaimagen.Name = "txtboxrutaimagen";
            this.txtboxrutaimagen.ReadOnly = true;
            this.txtboxrutaimagen.Size = new System.Drawing.Size(175, 20);
            this.txtboxrutaimagen.TabIndex = 11;
            // 
            // AgregarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 414);
            this.Controls.Add(this.txtboxrutaimagen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgreg_Agreg);
            this.Controls.Add(this.txtboxDesc_Agreg);
            this.Controls.Add(this.txtboxPrecio_Agreg);
            this.Controls.Add(this.txtboxNomb_Agreg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecio_Agreg);
            this.Controls.Add(this.lblNomb_Agreg);
            this.Name = "AgregarProd";
            this.Text = "AgregarProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomb_Agreg;
        private System.Windows.Forms.Label lblPrecio_Agreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgreg_Agreg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtboxNomb_Agreg;
        public System.Windows.Forms.TextBox txtboxPrecio_Agreg;
        public System.Windows.Forms.TextBox txtboxDesc_Agreg;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtboxrutaimagen;
    }
}