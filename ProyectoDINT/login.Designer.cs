namespace ProyectoDINT
{
    partial class login
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
            this.lblUsuario_login = new System.Windows.Forms.Label();
            this.lblContras_login = new System.Windows.Forms.Label();
            this.txtboxUsuario_login = new System.Windows.Forms.TextBox();
            this.txtboxPass_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkContOlvid_login = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkRegistrar_login = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario_login
            // 
            this.lblUsuario_login.AutoSize = true;
            this.lblUsuario_login.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_login.Location = new System.Drawing.Point(73, 96);
            this.lblUsuario_login.Name = "lblUsuario_login";
            this.lblUsuario_login.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario_login.TabIndex = 0;
            this.lblUsuario_login.Text = "Usuario:";
            // 
            // lblContras_login
            // 
            this.lblContras_login.AutoSize = true;
            this.lblContras_login.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContras_login.Location = new System.Drawing.Point(73, 139);
            this.lblContras_login.Name = "lblContras_login";
            this.lblContras_login.Size = new System.Drawing.Size(77, 17);
            this.lblContras_login.TabIndex = 1;
            this.lblContras_login.Text = "Contraseña:";
            // 
            // txtboxUsuario_login
            // 
            this.txtboxUsuario_login.Location = new System.Drawing.Point(169, 93);
            this.txtboxUsuario_login.Name = "txtboxUsuario_login";
            this.txtboxUsuario_login.Size = new System.Drawing.Size(173, 20);
            this.txtboxUsuario_login.TabIndex = 2;
            // 
            // txtboxPass_login
            // 
            this.txtboxPass_login.Location = new System.Drawing.Point(169, 136);
            this.txtboxPass_login.Name = "txtboxPass_login";
            this.txtboxPass_login.PasswordChar = '*';
            this.txtboxPass_login.Size = new System.Drawing.Size(173, 20);
            this.txtboxPass_login.TabIndex = 3;
            this.txtboxPass_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPass_login_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO SESIÓN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoDINT.Properties.Resources._585e4beacb11b227491c3399;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(321, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin_login
            // 
            this.btnLogin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_login.Location = new System.Drawing.Point(169, 205);
            this.btnLogin_login.Name = "btnLogin_login";
            this.btnLogin_login.Size = new System.Drawing.Size(119, 50);
            this.btnLogin_login.TabIndex = 6;
            this.btnLogin_login.Text = "Login";
            this.btnLogin_login.UseVisualStyleBackColor = true;
            this.btnLogin_login.Click += new System.EventHandler(this.btnLogin_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Has olvidado tu contraseña? ";
            // 
            // lnkContOlvid_login
            // 
            this.lnkContOlvid_login.AutoSize = true;
            this.lnkContOlvid_login.Location = new System.Drawing.Point(260, 280);
            this.lnkContOlvid_login.Name = "lnkContOlvid_login";
            this.lnkContOlvid_login.Size = new System.Drawing.Size(63, 13);
            this.lnkContOlvid_login.TabIndex = 8;
            this.lnkContOlvid_login.TabStop = true;
            this.lnkContOlvid_login.Text = "Pincha aqui";
            this.lnkContOlvid_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkContOlvid_login_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "¿No tienes cuenta?";
            // 
            // lnkRegistrar_login
            // 
            this.lnkRegistrar_login.AutoSize = true;
            this.lnkRegistrar_login.Location = new System.Drawing.Point(199, 313);
            this.lnkRegistrar_login.Name = "lnkRegistrar_login";
            this.lnkRegistrar_login.Size = new System.Drawing.Size(63, 13);
            this.lnkRegistrar_login.TabIndex = 10;
            this.lnkRegistrar_login.TabStop = true;
            this.lnkRegistrar_login.Text = "Pincha aqui";
            this.lnkRegistrar_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistrar_login_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(133, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario o Contraseña incorrectos";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(475, 431);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnkRegistrar_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkContOlvid_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPass_login);
            this.Controls.Add(this.txtboxUsuario_login);
            this.Controls.Add(this.lblContras_login);
            this.Controls.Add(this.lblUsuario_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario_login;
        private System.Windows.Forms.Label lblContras_login;
        private System.Windows.Forms.TextBox txtboxUsuario_login;
        private System.Windows.Forms.TextBox txtboxPass_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkContOlvid_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkRegistrar_login;
        private System.Windows.Forms.Label label4;
    }
}