using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class clDetalleFactura
    {
        int idDetalle;
        string idOrdenarOrd;
        float cantidad;
        float subtotal;
        float iva;
        float total;

        public int IdDetalle
        {
            get
            {
                return idDetalle;
            }

            set
            {
                idDetalle = value;
            }
        }

        public string IdOrdenarOrd
        {
            get
            {
                return idOrdenarOrd;
            }

            set
            {
                idOrdenarOrd = value;
            }
        }

        public float Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public float Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public float Iva
        {
            get
            {
                return iva;
            }

            set
            {
                iva = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
