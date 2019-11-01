using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    class Planeta
    {
        public byte id { get; set; }
        public String contenido { get; set; }
        public List<Pregunta> preguntas { get; set; }
    }
}
