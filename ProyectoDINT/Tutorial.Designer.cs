namespace ProyectoDINT
{
    partial class Tutorial
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnTuto_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://youtu.be/TiiKU8Z7t-I", System.UriKind.Absolute);
            // 
            // btnTuto_volver
            // 
            this.btnTuto_volver.BackgroundImage = global::ProyectoDINT.Properties.Resources.button_computer_icons_clip_art_exit;
            this.btnTuto_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTuto_volver.FlatAppearance.BorderSize = 0;
            this.btnTuto_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuto_volver.Location = new System.Drawing.Point(13, 13);
            this.btnTuto_volver.Name = "btnTuto_volver";
            this.btnTuto_volver.Size = new System.Drawing.Size(48, 38);
            this.btnTuto_volver.TabIndex = 1;
            this.btnTuto_volver.UseVisualStyleBackColor = true;
            this.btnTuto_volver.Click += new System.EventHandler(this.btnTuto_volver_Click);
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTuto_volver);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial";
            this.Text = "Ayuda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tutorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnTuto_volver;
    }
}