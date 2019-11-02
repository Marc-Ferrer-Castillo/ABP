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

        // Permite mover la ventana
        protected override void WndProc(ref Message n)
        {
            base.WndProc(ref n);
            if (n.Msg == WM_NCHITTEST)
                n.Result = (IntPtr)(HT_CAPTION);
        }


        public FormAjuda(byte idAjuda)
        {
            InitializeComponent();

            switch (idAjuda)
            {
                //muestra la ayuda del gestor de preguntas
                case 0:
                    pictureBoxAjuda.Image = Properties.Resources.Ajuda_Preguntes;
                    break;

                //muestra la ayuda del gestor de personatges
                case 1:
                    pictureBoxAjuda.Image = Properties.Resources.Ajuda_Personatges;
                    break;

                //muestra la ayuda del gestor de contingut
                case 2:
                    pictureBoxAjuda.Image = Properties.Resources.Ajuda_Contingut;
                    break;
                // muestra la ayuda del menu principal
                case 3:
                    pictureBoxAjuda.Image = Properties.Resources.Ajuda_Menu_Inici;
                    break;
            }
            
        }

        private void FormAjuda_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxSortir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
