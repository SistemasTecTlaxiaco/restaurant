using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class clClientes
    {
        int idCliente;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        string direccionc;

        public string Direccionc
        {
            get { return direccionc; }
            set { direccionc = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string tefonoc;

        public string Telefonoc
        {
            get { return tefonoc; }
            set { tefonoc = value; }
        }


        //constructores
        public clClientes()
        {
            idCliente = 0;
            direccionc = "";
            nombre = "";
            tefonoc = "";
        }

        //constructor que asigna los valores obtenidos de un dataReader
        public clClientes(MySqlDataReader datos)
        {
            try
            {
                idCliente = int.Parse(datos.GetValue(0).ToString());
                direccionc = datos.GetValue(1).ToString();
                nombre = datos.GetValue(2).ToString();
                tefonoc = datos.GetValue(3).ToString();
            }
            catch
            {
                MessageBox.Show("Error con los datos del usuario!");
            }
        }
    }
}
