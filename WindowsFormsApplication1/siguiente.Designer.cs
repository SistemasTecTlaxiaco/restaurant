namespace WindowsFormsApplication1
{
    partial class siguiente
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
            this.menu = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adorno = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡BIENVENIDO!";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu.ImageKey = "(ninguno)";
            this.menu.Location = new System.Drawing.Point(439, 422);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(192, 61);
            this.menu.TabIndex = 4;
            this.menu.Text = "MOSTRAR MENÚ";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.regresar.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regresar.ImageKey = "(ninguno)";
            this.regresar.Location = new System.Drawing.Point(12, 422);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(192, 61);
            this.regresar.TabIndex = 5;
            this.regresar.Text = "REGRESAR";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "(ninguno)";
            this.button2.Location = new System.Drawing.Point(222, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 61);
            this.button2.TabIndex = 18;
            this.button2.Text = "ORDENAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adorno
            // 
            this.adorno.Image = global::WindowsFormsApplication1.Properties.Resources.Imagen1;
            this.adorno.Location = new System.Drawing.Point(499, 35);
            this.adorno.Name = "adorno";
            this.adorno.Size = new System.Drawing.Size(181, 72);
            this.adorno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adorno.TabIndex = 28;
            this.adorno.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApplication1.Properties.Resources.Imagen2;
            this.logo.Location = new System.Drawing.Point(149, 211);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(390, 191);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 19;
            this.logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(23, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // siguiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(692, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adorno);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.label1);
            this.Name = "siguiente";
            this.Text = "siguente";
            ((System.ComponentModel.ISupportInitialize)(this.adorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox adorno;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}