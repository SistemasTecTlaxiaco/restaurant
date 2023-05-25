using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class clConsultasFacturas
    {
        public static string SiguienteFactura()
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "SELECT MAX(IdFacturas) FROM Facturas";
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

        public static void ActualizaFactura(int idFacturas, float subtotal, float iva, float total)
        {
            try
            {
                clConexion conexion = new clConexion();
                string consulta = "UPDATE `restaurante`.`Facturas` SET `Subtotal`='" + subtotal + "', `Iva`='" + iva + "', `Total`='" + total + "' WHERE `IdFacturas`='" + idFacturas + "';";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch
            {
            }
        }

        public static void RegistrarFactura(clFactura factura)
        {
            try
            {
                clConexion conexion = new clConexion();
                string fecha = "'" + factura.Hora.Year + "-" + factura.Hora.Month + "-" + factura.Hora.Day + " " + factura.Hora.Hour + ":" + factura.Hora.Minute + ":" + factura.Hora.Second + "'";
                string consulta = "insert into restaurante.Facturas(Hora, SubTotal, Iva, Total, Corte) values(" + fecha + "," + factura.SubTotal + "," + factura.Iva + "," + factura.Total + "," + factura.Corte + ");";
                MySqlCommand ejecutar = new MySqlCommand(consulta, conexion.ObtenerConexion());
                ejecutar.ExecuteNonQuery();
            }
            catch { }
        }

        public static void ActualizarCorte(int IdCorte, float total)
        {
            try
            {
                clCorte corte = clConsultascorte.ObtenerCorte(IdCorte);
                corte.Total = corte.Total + total;

                clConexion conexion = new clConexion();
                string consulta = "update restaurante.Corte set Total = " + corte.Total + " where IdCorte = " + IdCorte + ";";
                MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
                enviarSQL.ExecuteNonQuery();
            }
            catch { }
        }

        public static void RegistrarDetalle(string idOrdenarOrd, float cant, float subT, float iva, float Tot)
        {
            string consulta = "insert into restaurante.DetalleFactura (IdOrdenarO,Cantidad,SubTotal,Iva,Total)" +
                "values('" + idOrdenarOrd +  "'," + cant + "," + subT + "," + iva + "," + Tot + ");";
            clConexion conexion1 = new clConexion();
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion1.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();

            //update restaurante.Ordenar set Stock = 10 where IdOrdenar = 1
            clOrdenar prod = clConsultasOrdenar.BuscarporIdOrdenar(idOrdenarOrd);
            prod.Stock1 = prod.Stock1 - cant;
            string consulta2 = "update restaurante.Ordenar set Stock = " + prod.Stock1 + " where IdOrdenar = " + prod.IdOrdenar1;

            clConexion conexion2 = new clConexion();
            MySqlCommand enviarSQL2 = new MySqlCommand(consulta2, conexion2.ObtenerConexion());
            enviarSQL2.ExecuteNonQuery();
        }

        public static void Registra_Factura_Detalle(int factura)
        {
            clConexion conexion = new clConexion();
            string consulta = "select max(IdDetalleFactura) from restaurante.DetalleFactura;";
            MySqlCommand enviarSQL = new MySqlCommand(consulta, conexion.ObtenerConexion());
            enviarSQL.ExecuteNonQuery();
            MySqlDataReader lector = enviarSQL.ExecuteReader();
            lector.Read();
            int detalle = int.Parse(lector.GetValue(0).ToString());
            conexion.CerrarConexion();

            clConexion conexion2 = new clConexion();
            string consulta2 = "insert into restaurante.FacturaDetalle (Factura,Detalle) values (" + factura + "," + detalle + ");";
            MySqlCommand enviarSQL2 = new MySqlCommand(consulta2, conexion2.ObtenerConexion());
            enviarSQL2.ExecuteNonQuery();
            conexion2.CerrarConexion();
        }
    }
    }

