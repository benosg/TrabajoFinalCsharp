using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
   public class Factura
    {
        public int numFactura { get; set; }
        public string  rutCliente { get; set; }
        public string razonSocial { get; set; }
        public DateTime fecha { get; set; }
        public int iva { get; set; }
        public int neto { get; set; }
        public int total { get; set; }
        public int usuario { get; set; }

        
        public  List<DetalleFactura> lstFactura { get; set; }

    }
    public class DetalleFactura
    {
         
        public int idProducto { get; set; }
        public int precioProducto { get; set; }
        public int cantidad { get; set; }
        public int subTotal { get; set; }
    }
}
