using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    class Pregunta
    {
        public byte id { get; set; }
        public String pregunta { get; set; }
        public List<Respuesta> respuestas{ get; set; }
        public bool dificultad { get; set; }
    }
}
