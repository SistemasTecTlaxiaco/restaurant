namespace WindowsFormsApplication1
{
    partial class Iniciar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.facebook = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Instagram = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.siguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).BeginInit();
            this.SuspendLayout();
            // 
            // facebook
            // 
            this.facebook.Image = global::WindowsFormsApplication1.Properties.Resources.facebook;
            this.facebook.Location = new System.Drawing.Point(58, 502);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(62, 50);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.facebook.TabIndex = 1;
            this.facebook.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.Imagen2;
            this.logo.Location = new System.Drawing.Point(147, 94);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(418, 311);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Instagram
            // 
            this.Instagram.Image = global::WindowsFormsApplication1.Properties.Resources.instagram;
            this.Instagram.Location = new System.Drawing.Point(126, 502);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(69, 50);
            this.Instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Instagram.TabIndex = 2;
            this.Instagram.TabStop = false;
            this.Instagram.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.siguiente.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siguiente.ImageKey = "(ninguno)";
            this.siguiente.Location = new System.Drawing.Point(449, 481);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(145, 61);
            this.siguiente.TabIndex = 3;
            this.siguiente.Text = "SIGUIENTE";
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 622);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.facebook);
            this.Controls.Add(this.logo);
            this.MaximizeBox = false;
            this.Name = "Iniciar";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Instagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox Instagram;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button siguiente;

    }
}

