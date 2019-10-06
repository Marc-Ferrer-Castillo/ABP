using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    public class Contenido
    {
        public string pregunta { get; set; }
        public List<String> respuestas { get; set; }
        public int respuestaCorrecta { get; set; }

        public Contenido(string pregunta, List<string> respuestas, int respuestaCorrecta)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.respuestaCorrecta = respuestaCorrecta;
        }
    }
}
