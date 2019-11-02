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
    public partial class FormGestorPersonatges : Form
    {
        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //inicializar componentes
        public FormGestorPersonatges()
        {
            InitializeComponent();
        }

        private void FormGestorPersonatges_Load(object sender, EventArgs e)
        {

        }

        // Cerrar formulario
        private void pictureBoxSortir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Segur que vols sortir?", "Confirmar sortida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        //click volver al menu principal
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        //click minimizar
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //click ajuda
        private void pictureBoxAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda ajuda = new FormAjuda(1);
            ajuda.Show();
        }

        private void pictureBoxExportar_Click(object sender, EventArgs e)
        {
            //lista para los 3 personajes
            List<Personaje> personajes = new List<Personaje>();

            //guardamos datos del personaje1
            personajes[0].nom = textBoxNomP1.Text;
            personajes[0].frase = textBoxDesc1.Text;

            //guardamos datos del personaje2
            personajes[1].nom = textBoxNomP2.Text;
            personajes[1].frase = textBoxDesc2.Text;

            //guardamos datos del personaje3
            personajes[2].nom = textBoxNomP3.Text;
            personajes[2].frase = textBoxDesc3.Text;

        }
    }
}
