namespace ProyectoDINT
{
    partial class productos
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
            this.btnAgreg_Prod = new System.Windows.Forms.Button();
            this.btnAtras_prod = new System.Windows.Forms.Button();
            this.flowLyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgreg_Prod
            // 
            this.btnAgreg_Prod.AutoSize = true;
            this.btnAgreg_Prod.BackColor = System.Drawing.Color.Transparent;
            this.btnAgreg_Prod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnAgreg_Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgreg_Prod.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgreg_Prod.Location = new System.Drawing.Point(637, 605);
            this.btnAgreg_Prod.Name = "btnAgreg_Prod";
            this.btnAgreg_Prod.Size = new System.Drawing.Size(118, 50);
            this.btnAgreg_Prod.TabIndex = 1;
            this.btnAgreg_Prod.Text = "+";
            this.btnAgreg_Prod.UseVisualStyleBackColor = false;
            this.btnAgreg_Prod.Click += new System.EventHandler(this.btnAgreg_Prod_Click);
            // 
            // btnAtras_prod
            // 
            this.btnAtras_prod.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras_prod.BackgroundImage = global::ProyectoDINT.Properties.Resources._3643764_back_backward_left_reply_turn_113415;
            this.btnAtras_prod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras_prod.FlatAppearance.BorderSize = 0;
            this.btnAtras_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras_prod.Location = new System.Drawing.Point(12, 12);
            this.btnAtras_prod.Name = "btnAtras_prod";
            this.btnAtras_prod.Size = new System.Drawing.Size(46, 51);
            this.btnAtras_prod.TabIndex = 5;
            this.btnAtras_prod.UseVisualStyleBackColor = false;
            this.btnAtras_prod.Click += new System.EventHandler(this.btnAtras_prod_Click);
            // 
            // flowLyPanel
            // 
            this.flowLyPanel.AutoScroll = true;
            this.flowLyPanel.Location = new System.Drawing.Point(76, 98);
            this.flowLyPanel.Name = "flowLyPanel";
            this.flowLyPanel.Size = new System.Drawing.Size(1098, 469);
            this.flowLyPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(610, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoría";
            // 
            // productos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProyectoDINT.Properties.Resources.piso_madera_clara_53876_92977;
            this.ClientSize = new System.Drawing.Size(1229, 635);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLyPanel);
            this.Controls.Add(this.btnAtras_prod);
            this.Controls.Add(this.btnAgreg_Prod);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "productos";
            this.Text = "productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgreg_Prod;
        private System.Windows.Forms.Button btnAtras_prod;
        public System.Windows.Forms.FlowLayoutPanel flowLyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}