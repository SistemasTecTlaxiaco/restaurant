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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Bebidas f = new Bebidas();
            this.Hide();
            f.Show();


        }

        private void postres_Click(object sender, EventArgs e)
        {
            Postres f = new Postres();
            this.Hide();
            f.Show();

        }

        private void Caldos_Click(object sender, EventArgs e)
        {

            Caldos f = new Caldos();
            this.Hide();
            f.Show(); 

        }

        private void Delmar_Click(object sender, EventArgs e)
        {
            DelMar f = new DelMar();
            this.Hide();
            f.Show(); 
        }

        private void pollo_Click(object sender, EventArgs e)
        {
            Pollo_y_hamburguesas f = new Pollo_y_hamburguesas();
            this.Hide();
            f.Show(); 
        }

        private void Carnes_Click(object sender, EventArgs e)
        {
            Carne f = new Carne();
            this.Hide();
            f.Show(); 
        }

        private void pastas_Click(object sender, EventArgs e)
        {
            Pastas__Antojos_y_Ensaladas f = new Pastas__Antojos_y_Ensaladas();
            this.Hide();
            f.Show(); 
        }

        private void Desayunos_Click(object sender, EventArgs e)
        {
            Desayunos f = new Desayunos();
            this.Hide();
            f.Show(); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tomarorden f = new Tomarorden();
            this.Hide();
            f.Show(); 
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
