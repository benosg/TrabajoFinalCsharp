using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int precio { get; set; }
        public List<Producto> lstProducto { get; set; }
    }
}
