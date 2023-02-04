using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Productos
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public string Imagen { get; set; }
        public string Detalle { get; set; }

    }
}
