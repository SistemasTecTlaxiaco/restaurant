namespace Restaurant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Desayunos = new Label();
            Platillos = new Label();
            Postres = new Label();
            Bebidas = new Label();
            TOTAL = new Label();
            Orddesayuno = new ComboBox();
            textTOTAL = new ComboBox();
            ordbebidas = new ComboBox();
            ordpostres = new ComboBox();
            ordplatillos = new ComboBox();
            btGuardar = new Button();
            INICIAR_COBRO = new Button();
            Borrar_Orden = new Button();
            Cerrar = new Button();
            logo = new PictureBox();
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Fredoka One", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(206, 65);
            label1.Name = "label1";
            label1.Size = new Size(318, 66);
            label1.TabIndex = 27;
            label1.Text = "¡ORDENAR!";
            // 
            // Desayunos
            // 
            Desayunos.AutoSize = true;
            Desayunos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Desayunos.ForeColor = SystemColors.ButtonHighlight;
            Desayunos.Location = new Point(104, 155);
            Desayunos.Name = "Desayunos";
            Desayunos.Size = new Size(79, 17);
            Desayunos.TabIndex = 28;
            Desayunos.Text = "Desayunos";
            // 
            // Platillos
            // 
            Platillos.AutoSize = true;
            Platillos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Platillos.ForeColor = SystemColors.ButtonHighlight;
            Platillos.Location = new Point(104, 189);
            Platillos.Name = "Platillos";
            Platillos.Size = new Size(56, 17);
            Platillos.TabIndex = 29;
            Platillos.Text = "Platillos";
            // 
            // Postres
            // 
            Postres.AutoSize = true;
            Postres.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Postres.ForeColor = SystemColors.ButtonHighlight;
            Postres.Location = new Point(104, 223);
            Postres.Name = "Postres";
            Postres.Size = new Size(56, 17);
            Postres.TabIndex = 30;
            Postres.Text = "Postres";
            // 
            // Bebidas
            // 
            Bebidas.AutoSize = true;
            Bebidas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Bebidas.ForeColor = SystemColors.ButtonHighlight;
            Bebidas.Location = new Point(104, 252);
            Bebidas.Name = "Bebidas";
            Bebidas.Size = new Size(59, 17);
            Bebidas.TabIndex = 31;
            Bebidas.Text = "Bebidas";
            // 
            // TOTAL
            // 
            TOTAL.AutoSize = true;
            TOTAL.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TOTAL.ForeColor = SystemColors.ButtonHighlight;
            TOTAL.Location = new Point(288, 299);
            TOTAL.Name = "TOTAL";
            TOTAL.Size = new Size(78, 17);
            TOTAL.TabIndex = 32;
            TOTAL.Text = "TOTAL    $";
            // 
            // Orddesayuno
            // 
            Orddesayuno.FormattingEnabled = true;
            Orddesayuno.Location = new Point(226, 155);
            Orddesayuno.Name = "Orddesayuno";
            Orddesayuno.Size = new Size(267, 23);
            Orddesayuno.TabIndex = 33;
            // 
            // textTOTAL
            // 
            textTOTAL.FormattingEnabled = true;
            textTOTAL.Location = new Point(372, 293);
            textTOTAL.Name = "textTOTAL";
            textTOTAL.Size = new Size(121, 23);
            textTOTAL.TabIndex = 34;
            // 
            // ordbebidas
            // 
            ordbebidas.FormattingEnabled = true;
            ordbebidas.Location = new Point(226, 258);
            ordbebidas.Name = "ordbebidas";
            ordbebidas.Size = new Size(267, 23);
            ordbebidas.TabIndex = 35;
            // 
            // ordpostres
            // 
            ordpostres.FormattingEnabled = true;
            ordpostres.Location = new Point(226, 223);
            ordpostres.Name = "ordpostres";
            ordpostres.Size = new Size(267, 23);
            ordpostres.TabIndex = 36;
            // 
            // ordplatillos
            // 
            ordplatillos.FormattingEnabled = true;
            ordplatillos.Location = new Point(226, 189);
            ordplatillos.Name = "ordplatillos";
            ordplatillos.Size = new Size(267, 23);
            ordplatillos.TabIndex = 37;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = SystemColors.MenuHighlight;
            btGuardar.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btGuardar.Location = new Point(571, 197);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(94, 49);
            btGuardar.TabIndex = 39;
            btGuardar.Text = "GUARDAR";
            btGuardar.UseVisualStyleBackColor = false;
            // 
            // INICIAR_COBRO
            // 
            INICIAR_COBRO.BackColor = SystemColors.MenuHighlight;
            INICIAR_COBRO.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            INICIAR_COBRO.Location = new Point(104, 348);
            INICIAR_COBRO.Name = "INICIAR_COBRO";
            INICIAR_COBRO.Size = new Size(94, 58);
            INICIAR_COBRO.TabIndex = 40;
            INICIAR_COBRO.Text = "INICIAR COBRO";
            INICIAR_COBRO.UseVisualStyleBackColor = false;
            INICIAR_COBRO.Click += INICIAR_COBRO_Click;
            // 
            // Borrar_Orden
            // 
            Borrar_Orden.BackColor = SystemColors.MenuHighlight;
            Borrar_Orden.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Borrar_Orden.Location = new Point(272, 348);
            Borrar_Orden.Name = "Borrar_Orden";
            Borrar_Orden.Size = new Size(94, 58);
            Borrar_Orden.TabIndex = 41;
            Borrar_Orden.Text = "BORRAR ORDEN";
            Borrar_Orden.UseVisualStyleBackColor = false;
            Borrar_Orden.Click += Borrar_Orden_Click;
            // 
            // Cerrar
            // 
            Cerrar.BackColor = SystemColors.MenuHighlight;
            Cerrar.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cerrar.Location = new Point(430, 348);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(94, 58);
            Cerrar.TabIndex = 42;
            Cerrar.Text = "CERRAR";
            Cerrar.UseVisualStyleBackColor = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.ActiveCaptionText;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(558, 272);
            logo.Name = "logo";
            logo.Size = new Size(230, 154);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 43;
            logo.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 44;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(logo);
            Controls.Add(Cerrar);
            Controls.Add(Borrar_Orden);
            Controls.Add(INICIAR_COBRO);
            Controls.Add(btGuardar);
            Controls.Add(ordplatillos);
            Controls.Add(ordpostres);
            Controls.Add(ordbebidas);
            Controls.Add(textTOTAL);
            Controls.Add(Orddesayuno);
            Controls.Add(TOTAL);
            Controls.Add(Bebidas);
            Controls.Add(Postres);
            Controls.Add(Platillos);
            Controls.Add(Desayunos);
            Controls.Add(label1);
            ForeColor = Color.MidnightBlue;
            Name = "Form1";
            Text = "Tomarorden";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Desayunos;
        private Label Platillos;
        private Label Postres;
        private Label Bebidas;
        private Label TOTAL;
        private ComboBox Orddesayuno;
        private ComboBox textTOTAL;
        private ComboBox ordbebidas;
        private ComboBox ordpostres;
        private ComboBox ordplatillos;
        private Button btGuardar;
        private Button INICIAR_COBRO;
        private Button Borrar_Orden;
        private Button Cerrar;
        private PictureBox logo;
        private ToolStrip toolStrip1;
    }
}