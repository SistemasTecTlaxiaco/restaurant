using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public class clConsultasOrdenar
    {
        //actualizar stock de ordenar
        public static void ActualizaStock(string codigo, string cantidad)
        {
            try
            {
                clOrdenar prod = BuscarPorCodigo(int.Parse(codigo));
                prod.Stock1 = prod.Stock1 + float.Parse(cantidad);
                clConexion conexion = new clConexion();
                string consulta = "update restaurante.Ordenar set Stock = " + prod.Stock1 + " where codigo = " + prod.Codigo1 + ";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!!!");
            }
        }
        //buscar producto por codigo 
        public static clOrdenar BuscarPorCodigo(int codigo)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM restaurante.Ordenar where Codigo=" + codigo;
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clOrdenar producto = new clOrdenar(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //buscar producto por desayunos
        public static clOrdenar BuscarPorDesayunos(String desayunos)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM restaurante.Ordenar where desayunos=" + desayunos;
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clOrdenar producto = new clOrdenar(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //buscar producto por platillos...
        public static clOrdenar BuscarPorPlatillos(string platillos)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM restaurante.Ordenar where platillos='" + platillos + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clOrdenar producto = new clOrdenar(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //buscar producto por postres...
        public static clOrdenar BuscarPorPostres(string postres)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM restaurante.Ordenar where postres='" + postres + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clOrdenar producto = new clOrdenar(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //buscar producto por bebidas...
        public static clOrdenar BuscarPorBebidas(string bebidas)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT * FROM restaurante.Ordenar where bebidas='" + bebidas + "'";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                //obtener resultado
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                clOrdenar producto = new clOrdenar(lector);
                return producto;
            }
            catch
            {
                MessageBox.Show("Error en la conexion a la base de datos!");
                return null;
            }
        }

        //editar producto...
        public static void EditarProducto(clOrdenar producto)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "update restaurante.Ordenar set " +
                                  "desayunos='" + producto.desayunos1 + "'," +
                                  "platillos='" + producto.platillos1 + "',postres=" + producto.postres1 + ",bebidas=" + producto.bebidas1 +
                                  ",Stock= " + producto.Stock1 + ",Iva=" + producto.IVA1 + " where Codigo=" + producto.Codigo1 + ";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
            }
        }

        //agregar nuevo producto...
        public static void NuevoOrden(clOrdenar Orden)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "insert into Ordenar(Codigo,platillos,desayunos,postres,bebidas,Iva,Stock) " +
                                  "values(" + Orden.Codigo1 + ",'" + Orden.platillos1 + "','" +
                                  Orden.desayunos1 + "','" + Orden.postres1 + "'," +
                                  Orden.bebidas1 + ","  + "," + Orden.IVA1 + "," + Orden.Stock1 + ")";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MessageBox.Show("Producto agregado con éxito!");
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo insertar el registro!");
            }
        }

        //eliminar producto...
        public static void EliminarProducto(clOrdenar Ordenes)
        {
            clConexion conexion = new clConexion();
            string consulta = "delete from Ordenar where Codigo=" + Ordenes.Codigo1 + ";";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
        }

        //metodo para obtener el siguiente registro a insertar en la tabla ordenar
        public static string SiguienteRegistro()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(Codigo) FROM Ordenar";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
                MySqlDataReader lector = enviarSQL.ExecuteReader();
                lector.Read();
                return (int.Parse(lector.GetValue(0).ToString()) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Error en la conexion!");
                return null;
            }
        }
    }
}
