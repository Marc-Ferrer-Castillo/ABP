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
            FormAjuda ajuda = new FormAjuda(3);
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

        

        // Cuanndo un idioma es seleccionado
        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // catala seleccionado
            if (comboBoxIdioma.SelectedIndex == 0)
            {
                // Cambia la imagen y hace el control visible
                pictureBoxBandera.Image = SerializarJSON.Properties.Resources.cat;
                pictureBoxBandera.Visible = true;
            }
            // castella seleccionado
            else if (comboBoxIdioma.SelectedIndex == 1)
            {
                // Cambia la imagen y hace el control visible
                pictureBoxBandera.Image = SerializarJSON.Properties.Resources.esp;
                pictureBoxBandera.Visible = true;
            }
            // angles seleccionado
            else if (comboBoxIdioma.SelectedIndex == 2)
            {
                // Cambia la imagen y hace el control visible
                pictureBoxBandera.Image = SerializarJSON.Properties.Resources.eng;
                pictureBoxBandera.Visible = true;
            }
        }

        // Click Planeta 1
        private void pictureBoxPlaneta1_Click(object sender, EventArgs e)
        {
            pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1true;
        }
        // Click Planeta 2
        private void pictureBoxPlaneta2_Click(object sender, EventArgs e)
        {
            pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2true;
        }
        // Click Planeta 3
        private void pictureBoxPlaneta3_Click(object sender, EventArgs e)
        {
            pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3true;
        }

        //Obrir gestor de personatges
        private void pictureBoxGestorPersonatges_Click(object sender, EventArgs e)
        {
            FormGestorPersonatges formGestorPersonatges = new FormGestorPersonatges();
            formGestorPersonatges.Show();
        }
    }
}
