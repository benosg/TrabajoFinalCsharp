using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class OrdenCompra
    {
        public int numOrden { get; set; }
        public string rutCliente { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public DateTime fecha { get; set; }
        public int total { get; set; }
        public int codProducto { get; set; }
        public int cantidad { get; set; }
        public int subTotal { get; set; }
        public int usuario { get; set; }

        public List<DetalleOrden> lstOrdenCompra { get; set; }
    }
    public class DetalleOrden
    {
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public int subTotal { get; set; }
    }
}
