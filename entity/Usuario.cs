using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class Usuario
    {
        public string rut { get; set; }
        public string  nombre { get; set; }
        public int sistema { get; set; }
        public List<Usuario> lstUsuario{ get; set; }
}
}
