using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializarJSON
{
    public partial class FormAjuda : Form
    {
        public FormAjuda(byte idAjuda)
        {
            if (idAjuda == 0)
            {
                //muestra la ayuda del gestor de preguntas
            }
            else if (idAjuda == 1)
            {
                //muestra la ayuda del gestor de personatges  
            }
            else if (idAjuda == 2)
            {
                //muestra la ayuda del gestor de contingut
            }
            InitializeComponent();
        }
    }
}
