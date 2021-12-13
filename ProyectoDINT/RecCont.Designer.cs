namespace ProyectoDINT
{
    partial class RecCont
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
            this.txtboxUsuCorr_RecCont = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEmail_RecCont = new System.Windows.Forms.TextBox();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introducir usuario correspondiente";
            // 
            // txtboxUsuCorr_RecCont
            // 
            this.txtboxUsuCorr_RecCont.Location = new System.Drawing.Point(110, 64);
            this.txtboxUsuCorr_RecCont.Name = "txtboxUsuCorr_RecCont";
            this.txtboxUsuCorr_RecCont.Size = new System.Drawing.Size(309, 20);
            this.txtboxUsuCorr_RecCont.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introducir la direccion de correo electronico para recibir el correo";
            // 
            // txtboxEmail_RecCont
            // 
            this.txtboxEmail_RecCont.Location = new System.Drawing.Point(110, 158);
            this.txtboxEmail_RecCont.Name = "txtboxEmail_RecCont";
            this.txtboxEmail_RecCont.Size = new System.Drawing.Size(309, 20);
            this.txtboxEmail_RecCont.TabIndex = 3;
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Location = new System.Drawing.Point(185, 204);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(131, 51);
            this.btnEnviarCorreo.TabIndex = 4;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // RecCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 298);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.txtboxEmail_RecCont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxUsuCorr_RecCont);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecCont";
            this.Text = "RecCont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxUsuCorr_RecCont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEmail_RecCont;
        private System.Windows.Forms.Button btnEnviarCorreo;
    }
}