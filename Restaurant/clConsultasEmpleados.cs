using Restaurant.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class clConsultasEmpleados
    {
        //metodo que regresa los nombres de los empleados registrados en la base de datos
        public static MySqlDataReader ObtenerNombresEmpleados()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select nombree from  Empleados";
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

        //metodo que regresa los datos de un empleados, consulta
        public static MySqlDataReader ObtenerDatosEmpleados(string nombre)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "select * from Empleados where Nombree = '" + nombre + "'";
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

        //metodo para obtener el siguiente registro a insertar en la tabla empleados
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(IdEmpleados) FROM Empleados";
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

        //metodo para insertar un nuevo registro en la tabla Empleados
        public static void InsertarRegistro(clEmpleados empleado)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into Empleados(IdEmpleados,Nombree,Telefonoe,Direccione,Cargoe) values ('"
                                  + empleado.IdEmpleados + "','" + empleado.Nombree + "','" + empleado.Telefonoe + "','" + empleado.Direccione + "','" + empleado.Cargoe + "')";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        public static clEmpleados ObtenerEmpleadoporIdEmpleados(string IdEmpleados)
        {
            try
            {
                string consulta = "select * from Empleados where IdEmpleados = '" + IdEmpleados + "'";
                clConexion conex1 = new clConexion();
                //enviar consulta
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conex1.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clEmpleados usuario = new clEmpleados(lector);
                return usuario;
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }

        public static void ActualizarRegistro(clEmpleados empleado)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update Empleados set Nombree='" + empleado.Nombree + "',Telefonoe='" + empleado.Telefonoe + "',Direccione='" + empleado.Direccione + "',Cargoe= '" + empleado.Cargoe + "' where IdEmpleados='" + empleado.IdEmpleados + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        public static void EliminarRegistro(string IdEmpleados)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from Empleados where IdEmpleados='" + IdEmpleados + "'";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }
    }
}
