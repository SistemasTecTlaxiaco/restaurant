using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class siguiente : Form
    {
        public siguiente()
        {
            InitializeComponent();//inicializacion de los componentes
        }

        private void menu_Click(object sender, EventArgs e)
        {
            // lineas de codigo que nos permite mostrar el menu 
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            //En el windows for llamado siguiente en el boton regresar  se crea un windows para regresarlo a la ventana de inicio
            Iniciar f = new Iniciar();
            this.Hide();
            f.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //En el boton ordenar  se crea un windows para cuando seleccionemos el boton ordenar nos mande a la ventana de tomar orden
            Tomarorden f = new Tomarorden();
            this.Hide();
            f.Show(); 
        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show(); 
        }
    }
}
