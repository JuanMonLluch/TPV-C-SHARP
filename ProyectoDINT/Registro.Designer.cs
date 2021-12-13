namespace ProyectoDINT
{
    partial class Registro
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepContraseña = new System.Windows.Forms.Label();
            this.txtBoxRepContr = new System.Windows.Forms.TextBox();
            this.txtBoxContraseña = new System.Windows.Forms.TextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.btnRegRegistrar = new System.Windows.Forms.Button();
            this.btnCancelarReg = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbobox_Registro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCargo.Location = new System.Drawing.Point(321, 89);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(53, 18);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUsuario.Location = new System.Drawing.Point(321, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblContraseña.Location = new System.Drawing.Point(321, 164);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 18);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRepContraseña
            // 
            this.lblRepContraseña.AutoSize = true;
            this.lblRepContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblRepContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRepContraseña.Location = new System.Drawing.Point(321, 201);
            this.lblRepContraseña.Name = "lblRepContraseña";
            this.lblRepContraseña.Size = new System.Drawing.Size(140, 18);
            this.lblRepContraseña.TabIndex = 3;
            this.lblRepContraseña.Text = "Repetir Contraseña:";
            this.lblRepContraseña.Click += new System.EventHandler(this.lblRepContraseña_Click);
            // 
            // txtBoxRepContr
            // 
            this.txtBoxRepContr.Location = new System.Drawing.Point(478, 199);
            this.txtBoxRepContr.Name = "txtBoxRepContr";
            this.txtBoxRepContr.PasswordChar = '*';
            this.txtBoxRepContr.Size = new System.Drawing.Size(199, 20);
            this.txtBoxRepContr.TabIndex = 4;
            // 
            // txtBoxContraseña
            // 
            this.txtBoxContraseña.Location = new System.Drawing.Point(478, 162);
            this.txtBoxContraseña.Name = "txtBoxContraseña";
            this.txtBoxContraseña.PasswordChar = '*';
            this.txtBoxContraseña.Size = new System.Drawing.Size(199, 20);
            this.txtBoxContraseña.TabIndex = 3;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(478, 125);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtBoxUsuario.TabIndex = 2;
            // 
            // btnRegRegistrar
            // 
            this.btnRegRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRegRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRegRegistrar.Location = new System.Drawing.Point(605, 290);
            this.btnRegRegistrar.Name = "btnRegRegistrar";
            this.btnRegRegistrar.Size = new System.Drawing.Size(98, 38);
            this.btnRegRegistrar.TabIndex = 6;
            this.btnRegRegistrar.Text = "Registrar";
            this.btnRegRegistrar.UseVisualStyleBackColor = true;
            this.btnRegRegistrar.Click += new System.EventHandler(this.btnRegRegistrar_Click);
            // 
            // btnCancelarReg
            // 
            this.btnCancelarReg.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelarReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelarReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelarReg.Location = new System.Drawing.Point(465, 290);
            this.btnCancelarReg.Name = "btnCancelarReg";
            this.btnCancelarReg.Size = new System.Drawing.Size(98, 38);
            this.btnCancelarReg.TabIndex = 5;
            this.btnCancelarReg.Text = "Cancelar";
            this.btnCancelarReg.UseVisualStyleBackColor = true;
            this.btnCancelarReg.Click += new System.EventHandler(this.btnCancelarReg_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(462, 237);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(225, 17);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Las contraseñas no coinciden";
            this.lblError.Visible = false;
            // 
            // cmbobox_Registro
            // 
            this.cmbobox_Registro.FormattingEnabled = true;
            this.cmbobox_Registro.Items.AddRange(new object[] {
            "Camarero",
            "Encargado",
            "Admin"});
            this.cmbobox_Registro.Location = new System.Drawing.Point(478, 90);
            this.cmbobox_Registro.Name = "cmbobox_Registro";
            this.cmbobox_Registro.Size = new System.Drawing.Size(199, 21);
            this.cmbobox_Registro.TabIndex = 1;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoDINT.Properties.Resources.Captura_de_pantalla__206_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.cmbobox_Registro);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelarReg);
            this.Controls.Add(this.btnRegRegistrar);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.txtBoxContraseña);
            this.Controls.Add(this.txtBoxRepContr);
            this.Controls.Add(this.lblRepContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCargo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepContraseña;
        private System.Windows.Forms.TextBox txtBoxRepContr;
        private System.Windows.Forms.TextBox txtBoxContraseña;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Button btnRegRegistrar;
        private System.Windows.Forms.Button btnCancelarReg;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbobox_Registro;
    }
}

