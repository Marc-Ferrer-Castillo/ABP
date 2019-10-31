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
    public partial class FormMenuPrincipal : Form
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

        // Inicializar componentes
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        // Cerrar formulario
        private void pictureBoxSortir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Segur que vols sortir?", "Confirmar sortida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Minimizar formulario
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Abre ventana de ayuda
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormAjuda ajuda = new FormAjuda(0);
            ajuda.Show();
        }

        private void pictureBoxExportar_Click(object sender, EventArgs e)
        {
            // PROGRAMAR GUARDADO DE DATOS EN CARPETAS

            ////Opciones del saveDialog para nombre y extension
            //SaveFileDialogGuardar.FileName = "Contingut";
            //SaveFileDialogGuardar.DefaultExt = "*.json";
            //SaveFileDialogGuardar.DefaultExt = ".json";

            ////Muestra pantalla para guardar el fichero
            //if (SaveFileDialogGuardar.ShowDialog() == DialogResult.OK)
            //{
            //    Stream fileStream = SaveFileDialogGuardar.OpenFile();
            //    StreamWriter sw = new StreamWriter(fileStream);

            //    //Serializa JSON y guarda
            //    sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(listaContenidos));

            //    //Cierra streams
            //    sw.Close();
            //    fileStream.Close();
            //}
        }

        // Planeta 1: obre gestor de contingut
        private void buttonPlaneta1_Click(object sender, EventArgs e)
        {
            FormGestorContingut gestorContingut = new FormGestorContingut();
            gestorContingut.ShowDialog();
        }
    }
}
