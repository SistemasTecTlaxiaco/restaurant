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
    public partial class Pastas__Antojos_y_Ensaladas : Form
    {
        public Pastas__Antojos_y_Ensaladas()
        {
            InitializeComponent();
        }

        private void Pastas__Antojos_y_Ensaladas_Load(object sender, EventArgs e)
        {

        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show(); 
        }
    }
}
