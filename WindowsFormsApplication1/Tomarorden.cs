using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Practica4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
//En esta clase agregamos el codigo de nuestra aplicación. 

namespace WindowsFormsApplication1
{
    public partial class Tomarorden : Form
    {
        public Tomarorden()
        {
            InitializeComponent();
        }
        String Desayuno, resultado,Pasta,Pollo,Carne,Mar,Caldo,Postre,Bebida;
        private void button1_Click(object sender, EventArgs e)
        {
            Orddesayuno.Text = "";
            ordplatillos.Text = "";
            ordpostres.Text = "";
            ordbebidas.Text = "";
            Orddesayuno.Focus(); 
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Esta seguro de realizar esta orden? ", "", MessageBoxButtons.YesNoCancel);
            if (DialogResult == DialogResult.Yes)
            {
            }
            else
                Orddesayuno.Focus();

            resultado = Ordenar.Orden1(Desayuno);
            resultado = Ordenar.Orden2(Pasta);
            resultado = Ordenar.Orden3(Pollo);
            resultado = Ordenar.Orden4(Carne);
            resultado = Ordenar.Orden5(Mar);
            resultado = Ordenar.Orden6(Caldo);
            resultado = Ordenar.Orden7(Postre);
            resultado = Ordenar.Orden8(Bebida);

        }

        private void Orddesayuno_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Desayunos_Click(object sender, EventArgs e)
        {

        }

        private void ordplatillos_TextChanged(object sender, EventArgs e)
        {

        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show(); 
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            siguiente f = new siguiente();
            this.Hide();
            f.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tomarorden_Load(object sender, EventArgs e)
        {

        }
    }
}
