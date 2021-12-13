namespace ProyectoDINT {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtTicketDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btTicketAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.btTicketRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbTicketCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTicketNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTicketPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.LblIVA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoIVA = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::ProyectoDINT.Properties.Resources.piso_madera_clara_53876_92977;
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNumMesa);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::ProyectoDINT.Properties.Resources.piso_madera_clara_53876_92977;
            this.splitContainer1.Panel2.Controls.Add(this.btnImprimir);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.btnCobrar);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotal);
            this.splitContainer1.Panel2.Controls.Add(this.LblIVA);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblNoIVA);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 662);
            this.splitContainer1.SplitterDistance = 717;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 72);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(908, 129);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblNumMesa.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(295, 33);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(62, 23);
            this.lblNumMesa.TabIndex = 2;
            this.lblNumMesa.Text = "Mesa:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProyectoDINT.Properties.Resources._3643764_back_backward_left_reply_turn_113415;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 54);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 207);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(908, 455);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtTicketDelete,
            this.btTicketAdd,
            this.btTicketRemove,
            this.lbTicketCant,
            this.lbTicketNombre,
            this.lbTicketPrecio,
            this.PrecioUd});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(448, 528);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtTicketDelete
            // 
            this.BtTicketDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BtTicketDelete.HeaderText = "Eliminar";
            this.BtTicketDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtTicketDelete.Image")));
            this.BtTicketDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.BtTicketDelete.Name = "BtTicketDelete";
            this.BtTicketDelete.ReadOnly = true;
            this.BtTicketDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtTicketDelete.Width = 49;
            // 
            // btTicketAdd
            // 
            this.btTicketAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btTicketAdd.HeaderText = "Añadir";
            this.btTicketAdd.Image = ((System.Drawing.Image)(resources.GetObject("btTicketAdd.Image")));
            this.btTicketAdd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btTicketAdd.Name = "btTicketAdd";
            this.btTicketAdd.ReadOnly = true;
            this.btTicketAdd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btTicketAdd.Width = 43;
            // 
            // btTicketRemove
            // 
            this.btTicketRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btTicketRemove.HeaderText = "Restar";
            this.btTicketRemove.Image = ((System.Drawing.Image)(resources.GetObject("btTicketRemove.Image")));
            this.btTicketRemove.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btTicketRemove.Name = "btTicketRemove";
            this.btTicketRemove.ReadOnly = true;
            this.btTicketRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btTicketRemove.Width = 44;
            // 
            // lbTicketCant
            // 
            this.lbTicketCant.HeaderText = "Cant.";
            this.lbTicketCant.Name = "lbTicketCant";
            this.lbTicketCant.ReadOnly = true;
            this.lbTicketCant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lbTicketCant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbTicketNombre
            // 
            this.lbTicketNombre.HeaderText = "Nombre";
            this.lbTicketNombre.Name = "lbTicketNombre";
            this.lbTicketNombre.ReadOnly = true;
            // 
            // lbTicketPrecio
            // 
            this.lbTicketPrecio.HeaderText = "Precio";
            this.lbTicketPrecio.Name = "lbTicketPrecio";
            this.lbTicketPrecio.ReadOnly = true;
            // 
            // PrecioUd
            // 
            this.PrecioUd.HeaderText = "PrecioUd";
            this.PrecioUd.Name = "PrecioUd";
            this.PrecioUd.ReadOnly = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCobrar.Location = new System.Drawing.Point(52, 609);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(96, 59);
            this.btnCobrar.TabIndex = 10;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(336, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(336, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotal.Location = new System.Drawing.Point(259, 631);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // LblIVA
            // 
            this.LblIVA.AutoSize = true;
            this.LblIVA.BackColor = System.Drawing.Color.Transparent;
            this.LblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LblIVA.Location = new System.Drawing.Point(269, 589);
            this.LblIVA.Name = "LblIVA";
            this.LblIVA.Size = new System.Drawing.Size(24, 15);
            this.LblIVA.TabIndex = 6;
            this.LblIVA.Text = "IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(336, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // lblNoIVA
            // 
            this.lblNoIVA.AutoSize = true;
            this.lblNoIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblNoIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNoIVA.Location = new System.Drawing.Point(212, 562);
            this.lblNoIVA.Name = "lblNoIVA";
            this.lblNoIVA.Size = new System.Drawing.Size(81, 15);
            this.lblNoIVA.TabIndex = 4;
            this.lblNoIVA.Text = "Precio sin IVA";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::ProyectoDINT.Properties.Resources.cerrar_borrar_boton_eliminar_318_9073;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(52, 554);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 35);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoDINT.Properties.Resources.fondo_madera_negro;
            this.ClientSize = new System.Drawing.Size(1063, 662);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mesa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label LblIVA;
        private System.Windows.Forms.Label lblNoIVA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn BtTicketDelete;
        private System.Windows.Forms.DataGridViewImageColumn btTicketAdd;
        private System.Windows.Forms.DataGridViewImageColumn btTicketRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbTicketCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbTicketNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbTicketPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUd;
        public System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
    }
}