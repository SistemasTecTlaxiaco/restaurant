namespace WindowsFormsApplication1
{
    partial class Tomarorden
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
            this.ordplatillos = new System.Windows.Forms.TextBox();
            this.ordpostres = new System.Windows.Forms.TextBox();
            this.ordbebidas = new System.Windows.Forms.TextBox();
            this.Orddesayuno = new System.Windows.Forms.TextBox();
            this.Platillos = new System.Windows.Forms.Label();
            this.Postres = new System.Windows.Forms.Label();
            this.Bebidas = new System.Windows.Forms.Label();
            this.Desayunos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menucasa = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordplatillos
            // 
            this.ordplatillos.Location = new System.Drawing.Point(218, 170);
            this.ordplatillos.Margin = new System.Windows.Forms.Padding(2);
            this.ordplatillos.Name = "ordplatillos";
            this.ordplatillos.Size = new System.Drawing.Size(185, 20);
            this.ordplatillos.TabIndex = 26;
            this.ordplatillos.TextChanged += new System.EventHandler(this.ordplatillos_TextChanged);
            // 
            // ordpostres
            // 
            this.ordpostres.Location = new System.Drawing.Point(218, 202);
            this.ordpostres.Margin = new System.Windows.Forms.Padding(2);
            this.ordpostres.Name = "ordpostres";
            this.ordpostres.Size = new System.Drawing.Size(185, 20);
            this.ordpostres.TabIndex = 25;
            // 
            // ordbebidas
            // 
            this.ordbebidas.Location = new System.Drawing.Point(218, 239);
            this.ordbebidas.Margin = new System.Windows.Forms.Padding(2);
            this.ordbebidas.Name = "ordbebidas";
            this.ordbebidas.Size = new System.Drawing.Size(185, 20);
            this.ordbebidas.TabIndex = 24;
            // 
            // Orddesayuno
            // 
            this.Orddesayuno.Location = new System.Drawing.Point(218, 139);
            this.Orddesayuno.Margin = new System.Windows.Forms.Padding(2);
            this.Orddesayuno.Name = "Orddesayuno";
            this.Orddesayuno.Size = new System.Drawing.Size(185, 20);
            this.Orddesayuno.TabIndex = 23;
            this.Orddesayuno.TextChanged += new System.EventHandler(this.Orddesayuno_TextChanged);
            // 
            // Platillos
            // 
            this.Platillos.AutoSize = true;
            this.Platillos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Platillos.Location = new System.Drawing.Point(101, 170);
            this.Platillos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Platillos.Name = "Platillos";
            this.Platillos.Size = new System.Drawing.Size(42, 13);
            this.Platillos.TabIndex = 22;
            this.Platillos.Text = "Platillos";
            // 
            // Postres
            // 
            this.Postres.AutoSize = true;
            this.Postres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Postres.Location = new System.Drawing.Point(101, 202);
            this.Postres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Postres.Name = "Postres";
            this.Postres.Size = new System.Drawing.Size(42, 13);
            this.Postres.TabIndex = 21;
            this.Postres.Text = "Postres";
            // 
            // Bebidas
            // 
            this.Bebidas.AutoSize = true;
            this.Bebidas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bebidas.Location = new System.Drawing.Point(101, 241);
            this.Bebidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bebidas.Name = "Bebidas";
            this.Bebidas.Size = new System.Drawing.Size(45, 13);
            this.Bebidas.TabIndex = 20;
            this.Bebidas.Text = "Bebidas";
            // 
            // Desayunos
            // 
            this.Desayunos.AutoSize = true;
            this.Desayunos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Desayunos.Location = new System.Drawing.Point(101, 139);
            this.Desayunos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Desayunos.Name = "Desayunos";
            this.Desayunos.Size = new System.Drawing.Size(60, 13);
            this.Desayunos.TabIndex = 19;
            this.Desayunos.Text = "Desayunos";
            this.Desayunos.Click += new System.EventHandler(this.Desayunos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(250, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka One", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 58);
            this.label1.TabIndex = 27;
            this.label1.Text = "¡ORDENAR!";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "(ninguno)";
            this.button2.Location = new System.Drawing.Point(338, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 37);
            this.button2.TabIndex = 30;
            this.button2.Text = "CERRAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "(ninguno)";
            this.button1.Location = new System.Drawing.Point(192, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 31;
            this.button1.Text = "BORRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "(ninguno)";
            this.button3.Location = new System.Drawing.Point(50, 318);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 37);
            this.button3.TabIndex = 32;
            this.button3.Text = "GUARDAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menucasa
            // 
            this.menucasa.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CasaBlanca;
            this.menucasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menucasa.Cursor = System.Windows.Forms.Cursors.Default;
            this.menucasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menucasa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.menucasa.Location = new System.Drawing.Point(9, 20);
            this.menucasa.Margin = new System.Windows.Forms.Padding(2);
            this.menucasa.Name = "menucasa";
            this.menucasa.Size = new System.Drawing.Size(86, 59);
            this.menucasa.TabIndex = 35;
            this.menucasa.UseVisualStyleBackColor = true;
            this.menucasa.Click += new System.EventHandler(this.menucasa_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.regresar.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regresar.ImageKey = "(ninguno)";
            this.regresar.Location = new System.Drawing.Point(192, 388);
            this.regresar.Margin = new System.Windows.Forms.Padding(2);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(126, 49);
            this.regresar.TabIndex = 36;
            this.regresar.Text = "REGRESAR";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Tomarorden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(519, 505);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.menucasa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordplatillos);
            this.Controls.Add(this.ordpostres);
            this.Controls.Add(this.ordbebidas);
            this.Controls.Add(this.Orddesayuno);
            this.Controls.Add(this.Platillos);
            this.Controls.Add(this.Postres);
            this.Controls.Add(this.Bebidas);
            this.Controls.Add(this.Desayunos);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tomarorden";
            this.Text = "Tomarorden";
            this.Load += new System.EventHandler(this.Tomarorden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ordplatillos;
        private System.Windows.Forms.TextBox ordpostres;
        private System.Windows.Forms.TextBox ordbebidas;
        private System.Windows.Forms.TextBox Orddesayuno;
        private System.Windows.Forms.Label Platillos;
        private System.Windows.Forms.Label Postres;
        private System.Windows.Forms.Label Bebidas;
        private System.Windows.Forms.Label Desayunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button menucasa;
        private System.Windows.Forms.Button regresar;
    }
}