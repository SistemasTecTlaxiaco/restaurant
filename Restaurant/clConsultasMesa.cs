using Restaurant.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clConsultasMesa
    {
        //metodo que regresa el numero de las mesas registradas en la base de datos
        public static MySqlDataReader ObtenerNumeroMesa()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select numesa from Mesa";
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

        //metodo que regresa el numero de las mesas, consulta
        public static MySqlDataReader ObtenerDatosUsuario(string numesa)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select * from Mesa where Numesa = '" + numesa + "'";
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

        //metodo para obtener el siguiente registro a insertar en la tabla mesa
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(IdMesa) FROM Mesa";
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

        //metodo para insertar un nuevo registro en la tabla mesa
        public static void InsertarRegistro(clMesa mesa)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into Mesa(IdMesa,Numesa) values ('"
                                  + mesa.IdMesa + "','" + mesa.Numesa + "')";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        public static clMesa ObtenerMesaporIdMesa(string IdMesa)
        {
            try
            {
                string consulta = "select * from Mesa where IdMesa = '" + IdMesa + "'";
                clConexion conex1 = new clConexion();
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conex1.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clMesa usuario = new clMesa();
                return usuario;
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        public static void ActualizarRegistro(clMesa mesa)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update Mesa set Numesa='" + mesa.Numesa + "' where IdMesa='" + mesa.IdMesa + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        public static void EliminarRegistro(string IdMesa)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from Mesa where IdMesa='" + IdMesa + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }
    }
}
