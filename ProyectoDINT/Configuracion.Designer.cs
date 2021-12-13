namespace ProyectoDINT
{
    partial class Configuracion
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
            this.lblPantalla_Config = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chckbox_ModOsc_Conf = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPantalla_Config
            // 
            this.lblPantalla_Config.AutoSize = true;
            this.lblPantalla_Config.Font = new System.Drawing.Font("Caladea", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantalla_Config.Location = new System.Drawing.Point(139, 32);
            this.lblPantalla_Config.Name = "lblPantalla_Config";
            this.lblPantalla_Config.Size = new System.Drawing.Size(86, 22);
            this.lblPantalla_Config.TabIndex = 0;
            this.lblPantalla_Config.Text = "Pantalla";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoDINT.Properties.Resources._3643764_back_backward_left_reply_turn_113415;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 53);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProyectoDINT.Properties.Resources.horizontal_line;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(142, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // chckbox_ModOsc_Conf
            // 
            this.chckbox_ModOsc_Conf.AutoSize = true;
            this.chckbox_ModOsc_Conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbox_ModOsc_Conf.Location = new System.Drawing.Point(143, 89);
            this.chckbox_ModOsc_Conf.Name = "chckbox_ModOsc_Conf";
            this.chckbox_ModOsc_Conf.Size = new System.Drawing.Size(120, 22);
            this.chckbox_ModOsc_Conf.TabIndex = 4;
            this.chckbox_ModOsc_Conf.Text = "Modo Oscuro";
            this.chckbox_ModOsc_Conf.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chckbox_ModOsc_Conf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPantalla_Config);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPantalla_Config;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chckbox_ModOsc_Conf;
    }
}