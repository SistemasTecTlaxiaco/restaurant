namespace WindowsFormsApplication1
{
    partial class Carne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carne));
            this.carne5 = new System.Windows.Forms.Label();
            this.Carne2 = new System.Windows.Forms.Label();
            this.carne4 = new System.Windows.Forms.Label();
            this.Carne3 = new System.Windows.Forms.Label();
            this.Carne1 = new System.Windows.Forms.Label();
            this.Carness = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adorno = new System.Windows.Forms.PictureBox();
            this.menucasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adorno)).BeginInit();
            this.SuspendLayout();
            // 
            // carne5
            // 
            this.carne5.AutoSize = true;
            this.carne5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carne5.ForeColor = System.Drawing.Color.AliceBlue;
            this.carne5.Location = new System.Drawing.Point(26, 502);
            this.carne5.Name = "carne5";
            this.carne5.Size = new System.Drawing.Size(643, 105);
            this.carne5.TabIndex = 23;
            this.carne5.Text = resources.GetString("carne5.Text");
            this.carne5.Click += new System.EventHandler(this.carne5_Click);
            // 
            // Carne2
            // 
            this.Carne2.AutoSize = true;
            this.Carne2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carne2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carne2.Location = new System.Drawing.Point(483, 159);
            this.Carne2.Name = "Carne2";
            this.Carne2.Size = new System.Drawing.Size(177, 75);
            this.Carne2.TabIndex = 22;
            this.Carne2.Text = "T-BONE...............................$280\r\nNEW-YORK.........................$290\r" +
    "\n(acompañado de picaditas, \r\nguacamoles, verduras al vapor,\r\n nopal y cebolla)\r\n" +
    "";
            this.Carne2.Click += new System.EventHandler(this.Carne2_Click);
            // 
            // carne4
            // 
            this.carne4.AutoSize = true;
            this.carne4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carne4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carne4.Location = new System.Drawing.Point(107, 400);
            this.carne4.Name = "carne4";
            this.carne4.Size = new System.Drawing.Size(414, 75);
            this.carne4.TabIndex = 21;
            this.carne4.Text = resources.GetString("carne4.Text");
            this.carne4.Click += new System.EventHandler(this.carne4_Click);
            // 
            // Carne3
            // 
            this.Carne3.AutoSize = true;
            this.Carne3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carne3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carne3.Location = new System.Drawing.Point(107, 287);
            this.Carne3.Name = "Carne3";
            this.Carne3.Size = new System.Drawing.Size(475, 60);
            this.Carne3.TabIndex = 20;
            this.Carne3.Text = resources.GetString("Carne3.Text");
            this.Carne3.Click += new System.EventHandler(this.Carne3_Click);
            // 
            // Carne1
            // 
            this.Carne1.AutoSize = true;
            this.Carne1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carne1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carne1.Location = new System.Drawing.Point(51, 127);
            this.Carne1.Name = "Carne1";
            this.Carne1.Size = new System.Drawing.Size(381, 135);
            this.Carne1.TabIndex = 19;
            this.Carne1.Text = resources.GetString("Carne1.Text");
            this.Carne1.Click += new System.EventHandler(this.Carne1_Click);
            // 
            // Carness
            // 
            this.Carness.AutoSize = true;
            this.Carness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Carness.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carness.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Carness.Location = new System.Drawing.Point(262, 38);
            this.Carness.Name = "Carness";
            this.Carness.Size = new System.Drawing.Size(120, 37);
            this.Carness.TabIndex = 25;
            this.Carness.Text = "Carnes.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.CARNE;
            this.pictureBox1.Location = new System.Drawing.Point(540, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // adorno
            // 
            this.adorno.Image = global::WindowsFormsApplication1.Properties.Resources.Imagen1;
            this.adorno.Location = new System.Drawing.Point(472, 25);
            this.adorno.Name = "adorno";
            this.adorno.Size = new System.Drawing.Size(193, 84);
            this.adorno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adorno.TabIndex = 26;
            this.adorno.TabStop = false;
            // 
            // menucasa
            // 
            this.menucasa.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CasaBlanca;
            this.menucasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menucasa.Cursor = System.Windows.Forms.Cursors.Default;
            this.menucasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menucasa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.menucasa.Location = new System.Drawing.Point(25, 25);
            this.menucasa.Name = "menucasa";
            this.menucasa.Size = new System.Drawing.Size(127, 84);
            this.menucasa.TabIndex = 24;
            this.menucasa.UseVisualStyleBackColor = true;
            this.menucasa.Click += new System.EventHandler(this.menucasa_Click);
            // 
            // Carne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(692, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adorno);
            this.Controls.Add(this.Carness);
            this.Controls.Add(this.menucasa);
            this.Controls.Add(this.carne5);
            this.Controls.Add(this.Carne2);
            this.Controls.Add(this.carne4);
            this.Controls.Add(this.Carne3);
            this.Controls.Add(this.Carne1);
            this.Name = "Carne";
            this.Text = "Carne";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label carne5;
        private System.Windows.Forms.Label Carne2;
        private System.Windows.Forms.Label carne4;
        private System.Windows.Forms.Label Carne3;
        private System.Windows.Forms.Label Carne1;
        private System.Windows.Forms.Button menucasa;
        private System.Windows.Forms.Label Carness;
        private System.Windows.Forms.PictureBox adorno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}