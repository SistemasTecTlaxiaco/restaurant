using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clEmpleados
    {
        int idempleados;

        public int IdEmpleados
        {
            get { return idempleados; }
            set { idempleados = value; }
        }
        string telefonoe;

        public string Telefonoe
        {
            get { return telefonoe; }
            set { telefonoe = value; }
        }
        string nombree;

        public string Nombree
        {
            get { return nombree; }
            set { nombree = value; }
        }
        string direccione;

        public string Direccione
        {
            get { return direccione; }
            set { direccione = value; }
        }

        string cargoe;

        public string Cargoe
        {
            get { return cargoe; }
            set { cargoe = value; }
        }

        //constructores
        public clEmpleados()
        {
            idempleados = 0;
            telefonoe = "";
            nombree = "";
            direccione = "";
            cargoe = "";
        }

        //constructor que asigna los valores obtenidos de un dataReader
        public clEmpleados(MySqlDataReader datos)
        {
            try
            {
                idempleados = int.Parse(datos.GetValue(0).ToString());
                telefonoe = datos.GetValue(1).ToString();
                nombree = datos.GetValue(2).ToString();
                direccione = datos.GetValue(3).ToString();
                cargoe = datos.GetValue(4).ToString();
            }
            catch
            {
                MessageBox.Show("Error con los datos del usuario!");
            }
        }
    }
}
