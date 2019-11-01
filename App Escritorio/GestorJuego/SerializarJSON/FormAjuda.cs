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
        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        public FormAjuda(byte idAjuda)
        {
            InitializeComponent();

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
            else if (idAjuda == 3)
            {
                // muestra la ayuda del menu principal
                pictureBoxAjudaMainMenu.Visible = true;
            }            
        }

        private void FormAjuda_Load(object sender, EventArgs e)
        {

        }
    }
}
