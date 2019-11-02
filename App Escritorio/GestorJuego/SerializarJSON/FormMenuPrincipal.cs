using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Este es el primer formulario en abrirse, se instancia por primera vez desde la clase Program.cs por defecto
 * 
 * El código está ordenado respectivamente por Constantes, Variables, Eventos y Métodos
 *      Nota: Existen más métodos en la clase Metodo (Archivo Metodo.cs) que se usan desde varios formularios (Reciclaje de código)
 */
namespace SerializarJSON
{    
    public partial class FormMenuPrincipal : Form
    {
        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        
        // Constante max planetas
        private const int MAX_PLANETAS = 9;

        // Lista de planetas
        public static List<Planeta> planetas = new List<Planeta>();

         

        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }



        // Constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            crearPlanetas();
        }

        // Constructor con parametros usado al volver de la edicion
        public FormMenuPrincipal(Planeta planeta)
        {
            InitializeComponent();            

            //Guarda el planeta recibido por parámetro en su lugar correspondiente de la lista
            guardarPlaneta(planeta);
        }




        /*    EVENTOS
         *    ███████╗██╗   ██╗ ███████╗ ███╗   ██╗████████╗ ██████╗  ███████╗
         *    ██╔════╝██║   ██║ ██╔════╝ ████╗  ██║╚══██╔══╝██╔═══██╗ ██╔════╝
         *    █████╗  ██║   ██║ █████╗   ██╔██╗ ██║   ██║   ██║   ██║ ███████╗
         *    ██╔══╝  ╚██╗ ██╔╝ ██╔══╝   ██║╚██╗██║   ██║   ██║   ██║ ╚════██║
         *    ███████╗ ╚████╔╝  ███████╗ ██║ ╚████║   ██║   ╚██████╔╝ ███████║
         *    ╚══════╝  ╚═══╝   ╚══════╝ ╚═╝  ╚═══╝   ╚═╝    ╚═════╝  ╚══════╝                                                                 
         */

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

        // Botón exportar FALTA PROGRAMAR
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
        
        // Cuando un idioma es seleccionado
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
            abrirGestorContenido(0);            
        }

        // Click Planeta 2
        private void pictureBoxPlaneta2_Click(object sender, EventArgs e)
        {
            abrirGestorContenido(1);            
        }

        // Click Planeta 3
        private void pictureBoxPlaneta3_Click(object sender, EventArgs e)
        {
            abrirGestorContenido(2);            
        }

        //Obrir gestor de personatges
        private void pictureBoxGestorPersonatges_Click(object sender, EventArgs e)
        {
            FormGestorPersonatges formGestorPersonatges = new FormGestorPersonatges();
            formGestorPersonatges.Show();
        }


        /*    METODOS
         *    ███╗   ███╗ ███████╗████████╗ ██████╗  ██████╗    ██████╗  ███████╗
         *    ████╗ ████║ ██╔════╝╚══██╔══╝██╔═══██╗ ██╔══██╗  ██╔═══██╗ ██╔════╝
         *    ██╔████╔██║ █████╗     ██║   ██║   ██║ ██║   ██║ ██║   ██║ ███████╗
         *    ██║╚██╔╝██║ ██╔══╝     ██║   ██║   ██║ ██║  ██║  ██║   ██║ ╚════██║
         *    ██║ ╚═╝ ██║ ███████╗   ██║   ╚██████╔╝ ██████╔╝  ╚██████╔╝ ███████║
         *    ╚═╝     ╚═╝ ╚══════╝   ╚═╝    ╚═════╝  ╚═════╝    ╚═════╝  ╚══════╝                                                                
         */

        /// <summary>
        /// Abre el formulario Gestor de Contenido 
        /// según el idioma seleccionado en el comboBox
        /// y pasa el planeta correspondiente al nuevo formulario por su constructor.
        /// Finalmente reemplaza la imagen del planeta.
        /// </summary>
        /// <param name="numPlaneta"></param>
        private void abrirGestorContenido(byte numPlaneta)
        {
            if (comboBoxIdioma.SelectedIndex == 0)
            {
                switch (numPlaneta)
                {
                    case 0:
                        FormGestorContingut gestorContingut1 = new FormGestorContingut(planetas[0]);
                        gestorContingut1.ShowDialog();                        
                        break;

                    case 1:
                        FormGestorContingut gestorContingut2 = new FormGestorContingut(planetas[1]);
                        gestorContingut2.ShowDialog();                        
                        break;

                    case 2:
                        FormGestorContingut gestorContingut3 = new FormGestorContingut(planetas[2]);
                        gestorContingut3.ShowDialog();                        
                        break;
                }
                // Cambia el planeta a color
                pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1true;
            }
            else if (comboBoxIdioma.SelectedIndex == 1)
            {
                switch (numPlaneta)
                {
                    case 0:
                        FormGestorContingut gestorContingut1 = new FormGestorContingut(planetas[3]);
                        gestorContingut1.ShowDialog();                       
                        break;

                    case 1:
                        FormGestorContingut gestorContingut2 = new FormGestorContingut(planetas[4]);
                        gestorContingut2.ShowDialog();
                        break;

                    case 2:
                        FormGestorContingut gestorContingut3 = new FormGestorContingut(planetas[5]);
                        gestorContingut3.ShowDialog();
                        break;
                }
                // Cambia el planeta a color
                pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2true;
            }
            else if (comboBoxIdioma.SelectedIndex == 2)
            {
                switch (numPlaneta)
                {
                    case 0:
                        FormGestorContingut gestorContingut1 = new FormGestorContingut(planetas[6]);
                        gestorContingut1.ShowDialog();
                        break;

                    case 1:
                        FormGestorContingut gestorContingut2 = new FormGestorContingut(planetas[7]);
                        gestorContingut2.ShowDialog();
                        break;

                    case 2:
                        FormGestorContingut gestorContingut3 = new FormGestorContingut(planetas[8]);
                        gestorContingut3.ShowDialog();
                        break;
                }
                // Cambia el planeta a color
                pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3true;
            }
            else
            {
                MessageBox.Show("Selecciona l'idioma per aquests planetes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Guarda el planeta recibido en su lugar de la lista
        /// según su propiedad id
        /// </summary>
        /// <param name="planeta"></param>
        private void guardarPlaneta(Planeta planeta)
        {
            
            switch (planeta.id)
            {
                case 0:                    
                    planetas[0] = planeta;
                    break;
                case 1:
                    planetas[1] = planeta;
                    break;
                case 2:
                    planetas[2] = planeta;
                    break;
                case 3:
                    planetas[3] = planeta;
                    break;
                case 4:
                    planetas[4] = planeta;
                    break;
                case 5:
                    planetas[5] = planeta;
                    break;
                case 6:
                    planetas[6] = planeta;
                    break;
                case 7:
                    planetas[7] = planeta;
                    break;
                case 8:
                    planetas[8] = planeta;
                    break;
            }
        }

        /// <summary>
        /// Instancia 3 planetas de cada idioma y los guarda en su posicion de la lista correspondiente
        /// Los 3 primeros planetas son idioma Catalan[0 - 1 - 2]
        /// Los 3 siguientes son Español[3 - 4 - 5]
        /// Los 3 últimos English[6 - 7 - 8]
        /// </summary>
        private void crearPlanetas()
        {
            for (int i = 0; i < MAX_PLANETAS; i++)
            {
                if (i < 3)
                {
                    Planeta planeta = new Planeta((byte)i, 0);
                    planetas.Insert(i, planeta);
                }
                else if (i < 6)
                {
                    Planeta planeta = new Planeta((byte)i, 1);
                    planetas.Insert(i, planeta);
                }
                else if (i < MAX_PLANETAS)
                {
                    Planeta planeta = new Planeta((byte)i, 2);
                    planetas.Insert(i, planeta);
                }
            }
        }

        
    }
}
