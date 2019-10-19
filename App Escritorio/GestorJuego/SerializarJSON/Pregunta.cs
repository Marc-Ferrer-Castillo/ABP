using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    public class Pregunta
    {
        public int idPregunta { get; set; }
        /// <summary>
        /// False = Facil // True = Dificil
        /// </summary>
        public bool dificultat { get; set; }
        public string strPregunta { get; set; }

        public Pregunta(int idPregunta, bool dificultat, string strPregunta)
        {
            this.idPregunta = idPregunta;
            this.dificultat = dificultat;
            this.strPregunta = strPregunta;
        }
    }
}
