using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    public class Pregunta
    {
        public byte id { get; set; }
        public String pregunta { get; set; }
        public List<Respuesta> respuestas{ get; set; }
        public bool dificultad { get; set; }


        public Pregunta(byte id, string pregunta, List<Respuesta> respuestas, bool dificultad)
        {
            this.id = id;
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.dificultad = dificultad;
        }

        public Pregunta(byte id, string pregunta)
        {
            this.id = id;
            this.pregunta = pregunta;
        }
    }
}
