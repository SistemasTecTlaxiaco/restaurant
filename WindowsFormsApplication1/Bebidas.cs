﻿using System;
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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        private void menucasa_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show(); 
        }
    }
}
