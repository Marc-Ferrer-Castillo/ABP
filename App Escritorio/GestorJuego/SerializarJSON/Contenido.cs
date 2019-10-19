using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    public class Contenido
    {
        public Pregunta pregunta { get; set; }
        public List<Respuesta> respuestas { get; set; }
        public byte respuestaCorrecta { get; set; }
        //Propiedad para mostrar en la listbox
        public string displayMember { get {return pregunta.strPregunta;}}

        public Contenido(Pregunta pregunta, List<Respuesta> respuestas, byte respuestaCorrecta)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
            this.respuestaCorrecta = respuestaCorrecta;
        }
    }
}
