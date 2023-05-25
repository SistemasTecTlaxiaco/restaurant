using Restaurant.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class clConsultasClientes
    {
        //metodo que regresa los nombres de los clientes registrados en la base de datos
        public static MySqlDataReader ObtenerNombresUsuarios()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select nombre from Clientes";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                return lector;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //metodo que regresa los datos de un cliente, consulta
        public static MySqlDataReader ObtenerDatosUsuario(string nombre)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select * from Clientes where Nombre = '" + nombre + "'";
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return lector;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //metodo para obtener el siguiente registro a insertar en la tabla clientes
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(IdCliente) FROM Clientes";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return lector.GetValue(0).ToString();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        //metodo para insertar un nuevo registro en la tabla clientes
        public static void InsertarRegistro(clClientes usuario)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into clientes(IdCliente,Nombre,Direccionc,Telefonoc) values ('"
                                  + usuario.IdCliente + "','" + usuario.Nombre + "','" + usuario.Direccionc + "','" + usuario.Telefonoc + "')";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        public static clClientes ObtenerClienteporIdCliente(string IdCliente)
        {
            try
            {
                string consulta = "select * from Clientes where IdCliente = '" + IdCliente + "'";
                clConexion conex1 = new clConexion();
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conex1.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clClientes usuario = new clClientes(lector);
                return usuario;
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        public static void ActualizarRegistro(clClientes clientes)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update Clientes set Nombre='" + clientes.Nombre + "',Direccionc='" + clientes.Direccionc + "',Telefono='" + clientes.Telefonoc + "' where IdCliente='" + clientes.IdCliente + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        public static void EliminarRegistro(string IdCliente)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from Clientes where IdClientes='" + IdCliente + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }
    }
}
