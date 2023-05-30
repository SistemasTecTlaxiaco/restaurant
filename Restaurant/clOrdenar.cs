using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clOrdenar
    {
        //propiedades...
        private int Codigo;
        public int Codigo1
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        private string desayunos;
        public string desayunos1
        {
            get { return desayunos; }
            set { desayunos = value; }
        }

        private string platillos;
        public string platillos1
        {
            get { return platillos; }
            set { platillos = value; }
        }

        private string postres;
        public string postres1
        {
            get { return postres; }
            set { postres = value; }
        }

        private String bebidas;
        public String bebidas1
        {
            get { return bebidas; }
            set { bebidas = value; }
        }

        private int IVA;
        public int IVA1
        {
            get { return IVA; }
            set { IVA = value; }
        }

        private float Stock;
        public float Stock1
        {
            get { return Stock; }
            set { Stock = value; }
        }

        //constructores...
        public clOrdenar(MySqlDataReader datos)
        {
            try
            {
                Codigo = int.Parse(datos.GetValue(0).ToString());
                platillos = datos.GetValue(1).ToString();
                desayunos = datos.GetValue(2).ToString();
                postres = datos.GetValue(3).ToString();
                bebidas = datos.GetValue(4).ToString();
                IVA = int.Parse(datos.GetValue(5).ToString());
                Stock = float.Parse(datos.GetValue(6).ToString());
            }
            catch
            {
                MessageBox.Show("Error en los datos del producto!");
            }
        }

        public clOrdenar()
        {
            Codigo = 0;
            platillos = "";
            desayunos = "";
            postres = "";
            bebidas = "";
            IVA = 0;
            Stock = 0;
        }
    }
}
