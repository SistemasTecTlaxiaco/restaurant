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
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            siguiente f = new siguiente();
            this.Hide();
            f.Show(); 
        }
    }
}
