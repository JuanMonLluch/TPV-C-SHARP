namespace ProyectoDINT
{
    partial class InfoUsuario
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
            this.txtboxNombUsu_infoUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxPass_infoUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxRepPass_infoUsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxCargo_infoUsu = new System.Windows.Forms.ComboBox();
            this.btnAceptar_infoUsu = new System.Windows.Forms.Button();
            this.btnCancelar_infoUsu = new System.Windows.Forms.Button();
            this.chckboxEdicion_infoUsu = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContrIncorrecta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txtboxNombUsu_infoUsu
            // 
            this.txtboxNombUsu_infoUsu.Location = new System.Drawing.Point(165, 165);
            this.txtboxNombUsu_infoUsu.Name = "txtboxNombUsu_infoUsu";
            this.txtboxNombUsu_infoUsu.Size = new System.Drawing.Size(186, 20);
            this.txtboxNombUsu_infoUsu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(60, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // txtboxPass_infoUsu
            // 
            this.txtboxPass_infoUsu.Location = new System.Drawing.Point(165, 203);
            this.txtboxPass_infoUsu.Name = "txtboxPass_infoUsu";
            this.txtboxPass_infoUsu.Size = new System.Drawing.Size(186, 20);
            this.txtboxPass_infoUsu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repetir contraseña:";
            // 
            // txtboxRepPass_infoUsu
            // 
            this.txtboxRepPass_infoUsu.Location = new System.Drawing.Point(165, 238);
            this.txtboxRepPass_infoUsu.Name = "txtboxRepPass_infoUsu";
            this.txtboxRepPass_infoUsu.Size = new System.Drawing.Size(186, 20);
            this.txtboxRepPass_infoUsu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(95, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cargo:";
            // 
            // cmboxCargo_infoUsu
            // 
            this.cmboxCargo_infoUsu.FormattingEnabled = true;
            this.cmboxCargo_infoUsu.Items.AddRange(new object[] {
            "Empleado",
            "Encargado",
            "Admin"});
            this.cmboxCargo_infoUsu.Location = new System.Drawing.Point(165, 276);
            this.cmboxCargo_infoUsu.Name = "cmboxCargo_infoUsu";
            this.cmboxCargo_infoUsu.Size = new System.Drawing.Size(186, 21);
            this.cmboxCargo_infoUsu.TabIndex = 8;
            // 
            // btnAceptar_infoUsu
            // 
            this.btnAceptar_infoUsu.Location = new System.Drawing.Point(323, 384);
            this.btnAceptar_infoUsu.Name = "btnAceptar_infoUsu";
            this.btnAceptar_infoUsu.Size = new System.Drawing.Size(84, 32);
            this.btnAceptar_infoUsu.TabIndex = 9;
            this.btnAceptar_infoUsu.Text = "Aceptar";
            this.btnAceptar_infoUsu.UseVisualStyleBackColor = true;
            this.btnAceptar_infoUsu.Click += new System.EventHandler(this.btnAceptar_infoUsu_Click);
            // 
            // btnCancelar_infoUsu
            // 
            this.btnCancelar_infoUsu.Location = new System.Drawing.Point(223, 384);
            this.btnCancelar_infoUsu.Name = "btnCancelar_infoUsu";
            this.btnCancelar_infoUsu.Size = new System.Drawing.Size(83, 32);
            this.btnCancelar_infoUsu.TabIndex = 10;
            this.btnCancelar_infoUsu.Text = "Cancelar";
            this.btnCancelar_infoUsu.UseVisualStyleBackColor = true;
            this.btnCancelar_infoUsu.Click += new System.EventHandler(this.btnCancelar_infoUsu_Click);
            // 
            // chckboxEdicion_infoUsu
            // 
            this.chckboxEdicion_infoUsu.AutoSize = true;
            this.chckboxEdicion_infoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.chckboxEdicion_infoUsu.Location = new System.Drawing.Point(82, 123);
            this.chckboxEdicion_infoUsu.Name = "chckboxEdicion_infoUsu";
            this.chckboxEdicion_infoUsu.Size = new System.Drawing.Size(265, 20);
            this.chckboxEdicion_infoUsu.TabIndex = 11;
            this.chckboxEdicion_infoUsu.Text = "Permitir edicion de los datos del usuario";
            this.chckboxEdicion_infoUsu.UseVisualStyleBackColor = true;
            this.chckboxEdicion_infoUsu.CheckedChanged += new System.EventHandler(this.chckboxEdicion_infoUsu_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoDINT.Properties.Resources._2d4e09879b6f017f74ffaee0b0011c0a_icono_de_ojo_by_vexels;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(366, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 25);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoDINT.Properties.Resources._585e4beacb11b227491c3399;
            this.pictureBox1.Location = new System.Drawing.Point(165, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblContrIncorrecta
            // 
            this.lblContrIncorrecta.AutoSize = true;
            this.lblContrIncorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblContrIncorrecta.ForeColor = System.Drawing.Color.Red;
            this.lblContrIncorrecta.Location = new System.Drawing.Point(111, 316);
            this.lblContrIncorrecta.Name = "lblContrIncorrecta";
            this.lblContrIncorrecta.Size = new System.Drawing.Size(214, 16);
            this.lblContrIncorrecta.TabIndex = 13;
            this.lblContrIncorrecta.Text = "Las contraseñas no coinciden";
            // 
            // InfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 444);
            this.Controls.Add(this.lblContrIncorrecta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chckboxEdicion_infoUsu);
            this.Controls.Add(this.btnCancelar_infoUsu);
            this.Controls.Add(this.btnAceptar_infoUsu);
            this.Controls.Add(this.cmboxCargo_infoUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxRepPass_infoUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxPass_infoUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxNombUsu_infoUsu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InfoUsuario";
            this.Text = "InfoUsuario";
            this.Load += new System.EventHandler(this.InfoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNombUsu_infoUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxPass_infoUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxRepPass_infoUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxCargo_infoUsu;
        private System.Windows.Forms.Button btnAceptar_infoUsu;
        private System.Windows.Forms.Button btnCancelar_infoUsu;
        private System.Windows.Forms.CheckBox chckboxEdicion_infoUsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContrIncorrecta;
    }
}