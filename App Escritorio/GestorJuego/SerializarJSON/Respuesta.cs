using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    class Respuesta
    {
        public byte id { get; set; }
        public String respuesta { get; set; }
        public bool esCorrecta { get; set; }
    }
}
