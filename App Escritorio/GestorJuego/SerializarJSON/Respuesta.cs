using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarJSON
{
    public class Respuesta
    { 
        public byte id { get; set; }
        public String strResposta{ get; set; }
        public bool esCorrecte { get; set; }


        public Respuesta(byte id, string strResposta, bool esCorrecte)
        {
            this.id = id;
            this.strResposta = strResposta;
            this.esCorrecte = esCorrecte;
        }

        public Respuesta(string strResposta)
        {
            this.strResposta = strResposta;            
        }
    }
}
