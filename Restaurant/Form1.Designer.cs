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
            btBuscar = new Button();
            btAceptar = new Button();
            btCancelar = new Button();
            logo = new PictureBox();
            toolStrip1 = new ToolStrip();
            cONSULTARToolStripSplitBtn = new ToolStripSplitButton();
            nUEVOToolStripSplitBtn = new ToolStripSplitButton();
            eDITARToolStripSplitBtn = new ToolStripSplitButton();
            eLIMINARToolStripSplitBtn = new ToolStripSplitButton();
            aCTUALIZARSTOCKToolStripSplitBtn = new ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            toolStrip1.SuspendLayout();
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
            // btBuscar
            // 
            btBuscar.BackColor = SystemColors.MenuHighlight;
            btBuscar.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btBuscar.Location = new Point(596, 140);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 49);
            btBuscar.TabIndex = 39;
            btBuscar.Text = "BUSCAR";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // btAceptar
            // 
            btAceptar.BackColor = SystemColors.MenuHighlight;
            btAceptar.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAceptar.Location = new Point(147, 348);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(94, 58);
            btAceptar.TabIndex = 40;
            btAceptar.Text = "ACEPTAR";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = SystemColors.MenuHighlight;
            btCancelar.Font = new Font("Fredoka One", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelar.Location = new Point(339, 348);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(107, 58);
            btCancelar.TabIndex = 42;
            btCancelar.Text = "CANCELAR";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += Cerrar_Click;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.ActiveCaptionText;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(530, 223);
            logo.Name = "logo";
            logo.Size = new Size(258, 203);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 43;
            logo.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { cONSULTARToolStripSplitBtn, nUEVOToolStripSplitBtn, eDITARToolStripSplitBtn, eLIMINARToolStripSplitBtn, aCTUALIZARSTOCKToolStripSplitBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 44;
            toolStrip1.Text = "toolStrip1";
            // 
            // cONSULTARToolStripSplitBtn
            // 
            cONSULTARToolStripSplitBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cONSULTARToolStripSplitBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cONSULTARToolStripSplitBtn.Image = (Image)resources.GetObject("cONSULTARToolStripSplitBtn.Image");
            cONSULTARToolStripSplitBtn.ImageTransparentColor = Color.Magenta;
            cONSULTARToolStripSplitBtn.Name = "cONSULTARToolStripSplitBtn";
            cONSULTARToolStripSplitBtn.Size = new Size(119, 22);
            cONSULTARToolStripSplitBtn.Text = "CONSULTAR";
            cONSULTARToolStripSplitBtn.ButtonClick += cONSULTARToolStripSplitBtn_ButtonClick;
            // 
            // nUEVOToolStripSplitBtn
            // 
            nUEVOToolStripSplitBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            nUEVOToolStripSplitBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nUEVOToolStripSplitBtn.Image = (Image)resources.GetObject("nUEVOToolStripSplitBtn.Image");
            nUEVOToolStripSplitBtn.ImageTransparentColor = Color.Magenta;
            nUEVOToolStripSplitBtn.Name = "nUEVOToolStripSplitBtn";
            nUEVOToolStripSplitBtn.Size = new Size(80, 22);
            nUEVOToolStripSplitBtn.Text = "NUEVO";
            nUEVOToolStripSplitBtn.ButtonClick += nUEVOToolStripSplitBtn_ButtonClick;
            // 
            // eDITARToolStripSplitBtn
            // 
            eDITARToolStripSplitBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eDITARToolStripSplitBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            eDITARToolStripSplitBtn.Image = (Image)resources.GetObject("eDITARToolStripSplitBtn.Image");
            eDITARToolStripSplitBtn.ImageTransparentColor = Color.Magenta;
            eDITARToolStripSplitBtn.Name = "eDITARToolStripSplitBtn";
            eDITARToolStripSplitBtn.Size = new Size(80, 22);
            eDITARToolStripSplitBtn.Text = "EDITAR";
            eDITARToolStripSplitBtn.ButtonClick += eDITARToolStripSplitBtn_ButtonClick;
            // 
            // eLIMINARToolStripSplitBtn
            // 
            eLIMINARToolStripSplitBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            eLIMINARToolStripSplitBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            eLIMINARToolStripSplitBtn.Image = (Image)resources.GetObject("eLIMINARToolStripSplitBtn.Image");
            eLIMINARToolStripSplitBtn.ImageTransparentColor = Color.Magenta;
            eLIMINARToolStripSplitBtn.Name = "eLIMINARToolStripSplitBtn";
            eLIMINARToolStripSplitBtn.Size = new Size(96, 22);
            eLIMINARToolStripSplitBtn.Text = "ELIMINAR";
            eLIMINARToolStripSplitBtn.ButtonClick += eLIMINARToolStripSplitBtn_ButtonClick;
            // 
            // aCTUALIZARSTOCKToolStripSplitBtn
            // 
            aCTUALIZARSTOCKToolStripSplitBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            aCTUALIZARSTOCKToolStripSplitBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aCTUALIZARSTOCKToolStripSplitBtn.Image = (Image)resources.GetObject("aCTUALIZARSTOCKToolStripSplitBtn.Image");
            aCTUALIZARSTOCKToolStripSplitBtn.ImageTransparentColor = Color.Magenta;
            aCTUALIZARSTOCKToolStripSplitBtn.Name = "aCTUALIZARSTOCKToolStripSplitBtn";
            aCTUALIZARSTOCKToolStripSplitBtn.Size = new Size(180, 22);
            aCTUALIZARSTOCKToolStripSplitBtn.Text = "ACTUALIZAR STOCK";
            aCTUALIZARSTOCKToolStripSplitBtn.ButtonClick += aCTUALIZARSTOCKToolStripSplitBtn_ButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(logo);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Controls.Add(btBuscar);
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
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private Button btBuscar;
        private Button btAceptar;
        private Button btCancelar;
        private PictureBox logo;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton cONSULTARToolStripSplitBtn;
        private ToolStripSplitButton nUEVOToolStripSplitBtn;
        private ToolStripSplitButton eDITARToolStripSplitBtn;
        private ToolStripSplitButton eLIMINARToolStripSplitBtn;
        private ToolStripSplitButton aCTUALIZARSTOCKToolStripSplitBtn;
    }
}