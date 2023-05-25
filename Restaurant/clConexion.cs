﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clConexion
    {
        //variables necesarias para la conexion con la base de datos
        private string stringconexion = "server=localhost; user id=root; pwd=; database=restaurante";
        private MySqlConnection conexion;

        //constructor
        public clConexion()
        {
            try
            {
                conexion = new MySqlConnection(stringconexion);
                conexion.Open();
            }
            catch
            {
                MessageBox.Show("Error al iniciar la conexion!");
            }
        }

        //metodo que regresa la conexion instanciada
        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }

        //metodo que cierra la conexion instanciada
        public void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
