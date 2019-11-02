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
        public FormGestorContingut()
        {
            InitializeComponent();
        }

        // Cierra el formulario, y abre FormGestorPreguntes
        private void pictureBoxSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestorPreguntes  gestorPreguntes = new FormGestorPreguntes();
            gestorPreguntes.ShowDialog();
        }

        private void FormGestorContingut_Load(object sender, EventArgs e)
        {

        }
    }
}
