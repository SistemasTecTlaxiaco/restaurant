using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clMesa
    {
        int idmesa;

        public int IdMesa
        {
            get { return idmesa; }
            set { idmesa = value; }
        }
        string numesa;

        public string Numesa
        {
            get { return numesa; }
            set { numesa = value; }
        }

        //constructores
        public clMesa()
        {
            idmesa = 0;
            numesa = "";
        }

        //constructor que asigna los valores obtenidos de un dataReader
        public clMesa(MySqlDataReader datos)
        {
            try
            {
                idmesa = int.Parse(datos.GetValue(0).ToString());
                numesa = datos.GetValue(1).ToString();
            }
            catch
            {
                MessageBox.Show("Error con los datos del usuario!");
            }
        }
    }
}
