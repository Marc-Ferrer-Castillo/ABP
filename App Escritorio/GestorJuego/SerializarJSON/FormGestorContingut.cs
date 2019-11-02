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
    public partial class FormGestorContingut : Form
    {
        public Planeta planeta { get; set; }

        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private byte idPlaneta;

        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        // Inicializa el formulario y recibe un planeta por parametro
        public FormGestorContingut(Planeta planeta, byte idPlaneta)
        {            
            InitializeComponent();
            this.planeta = planeta;
            this.idPlaneta = idPlaneta;
        }

        // Cierra el formulario, y abre FormGestorPreguntes
        private void pictureBoxSiguiente_Click(object sender, EventArgs e)
        {
            // Si el contenido es correcto
            if (Metodo.revisarContenido(textBoxContenido.Text) )
            {
                // Instancia un formulario de preguntas pasando por parametro el contenido del textbox
                FormGestorPreguntes gestorPreguntes = new FormGestorPreguntes(textBoxContenido.Text, idPlaneta);
                // Muestra el formulario
                gestorPreguntes.ShowDialog();
                // Cierra este formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("Introdueix un contingut per continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContenido.Focus();
            }
            
        }

        private void FormGestorContingut_Load(object sender, EventArgs e)
        {

        }
    }
}
