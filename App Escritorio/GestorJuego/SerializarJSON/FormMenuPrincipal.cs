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
 * FUNCIONAMIENTO:
 *          1. Al abrirse el formulario por primera vez, se instancian 9 planetas con su id correspondiente
 *          2. Segun el idioma seleccionado y el planeta pulsado, se pasar al constructor del gestor de contenido un planeta u otro
 *          
 * 
 * El código está ordenado respectivamente por Constantes, Atributos, Constructores, Eventos y Métodos
 *      Nota: Existen más métodos en la clase Metodo (Archivo Metodo.cs) que se usan desde varios formularios (Reciclaje de código)
 */
namespace SerializarJSON
{    
    public partial class FormMenuPrincipal : Form
    {
        /***
        *     ██████╗ ██████╗ ███╗   ██╗███████╗████████╗ █████╗ ███╗   ██╗████████╗███████╗███████╗
        *    ██╔════╝██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗████╗  ██║╚══██╔══╝██╔════╝██╔════╝
        *    ██║     ██║   ██║██╔██╗ ██║███████╗   ██║   ███████║██╔██╗ ██║   ██║   █████╗  ███████╗
        *    ██║     ██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██║██║╚██╗██║   ██║   ██╔══╝  ╚════██║
        *    ╚██████╗╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║██║ ╚████║   ██║   ███████╗███████║
        *     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚══════╝
        *                                                                                           
        */

        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // Constante max planetas totales
        private const byte MAX_PLANETAS = 9;
        // Constante maximo de lenguajes
        private const byte MAX_LENGUAJES = 3;
        // Constante maximo de planetas por lenguaje
        private const byte PLANETASxIDIOMA = 3;
        // Constantes que hacen referencia al planeta pulsado
        private const byte PLANETA1 = 0;
        private const byte PLANETA2 = 1;
        private const byte PLANETA3 = 2;


        /***
        *     █████╗ ████████╗██████╗ ██╗██████╗ ██╗   ██╗████████╗ ██████╗ ███████╗
        *    ██╔══██╗╚══██╔══╝██╔══██╗██║██╔══██╗██║   ██║╚══██╔══╝██╔═══██╗██╔════╝
        *    ███████║   ██║   ██████╔╝██║██████╔╝██║   ██║   ██║   ██║   ██║███████╗
        *    ██╔══██║   ██║   ██╔══██╗██║██╔══██╗██║   ██║   ██║   ██║   ██║╚════██║
        *    ██║  ██║   ██║   ██║  ██║██║██████╔╝╚██████╔╝   ██║   ╚██████╔╝███████║
        *    ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═════╝  ╚═════╝    ╚═╝    ╚═════╝ ╚══════╝
        *                                                                           
        */
        // Lista de planetas
        public static List<Planeta> planetas = new List<Planeta>();


        /***
        *     ██████╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗ ██╗   ██╗ ██████╗████████╗ ██████╗ ██████╗ ███████╗███████╗
        *    ██╔════╝██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗██╔════╝██╔════╝
        *    ██║     ██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝██║   ██║██║        ██║   ██║   ██║██████╔╝█████╗  ███████╗
        *    ██║     ██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██║   ██║██║        ██║   ██║   ██║██╔══██╗██╔══╝  ╚════██║
        *    ╚██████╗╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║╚██████╔╝╚██████╗   ██║   ╚██████╔╝██║  ██║███████╗███████║
        *     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝  ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝
        *                                                                                                                   
        */

        // Constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            
            // Crea 9 planetas con su id correspondiente [0-8]
            crearPlanetas();
        }


        /*    EVENTOS
         *    ███████╗██╗   ██╗ ███████╗ ███╗   ██╗████████╗ ██████╗  ███████╗
         *    ██╔════╝██║   ██║ ██╔════╝ ████╗  ██║╚══██╔══╝██╔═══██╗ ██╔════╝
         *    █████╗  ██║   ██║ █████╗   ██╔██╗ ██║   ██║   ██║   ██║ ███████╗
         *    ██╔══╝  ╚██╗ ██╔╝ ██╔══╝   ██║╚██╗██║   ██║   ██║   ██║ ╚════██║
         *    ███████╗ ╚████╔╝  ███████╗ ██║ ╚████║   ██║   ╚██████╔╝ ███████║
         *    ╚══════╝  ╚═══╝   ╚══════╝ ╚═╝  ╚═══╝   ╚═╝    ╚═════╝  ╚══════╝                                                                 
         */

        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
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
            // Colorea los planetas si tienen alguna pregunta dentro, sino los descolorea
            // Hace aparecer la bandera correspondiente al idioma seleccionado            
            colorPlanetas(comboBoxIdioma.SelectedIndex);
        }

        // Click Planeta 1
        private void pictureBoxPlaneta1_Click(object sender, EventArgs e)
        {
            abrirGestorContenido(PLANETA1);            
        }

        // Click Planeta 2
        private void pictureBoxPlaneta2_Click(object sender, EventArgs e)
        {
            abrirGestorContenido(PLANETA2);            
        }

        // Click Planeta 3
        private void pictureBoxPlaneta3_Click(object sender, EventArgs e)
        {
            abrirGestorContenido(PLANETA3);            
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
        /// Pasa el planeta correspondiente al formulario gestor de contenido por su constructor.
        /// Finalmente reemplaza la imagen del planeta.
        /// </summary>
        /// <param name="numPlaneta"></param>
        private void abrirGestorContenido(byte numPlaneta)
        {
            // Si el idioma es Catalan
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
            }
            // Si el idioma es Español
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
            }
            // Si el idioma es Ingles
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
            }
            // Si ningún idioma es selccionado y se pulsa sobre un planeta
            else
            {
                MessageBox.Show("Selecciona l'idioma per aquests planetes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Cambia el color de los planetas si tienen > 0 preguntas
            colorPlanetas(comboBoxIdioma.SelectedIndex);
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
        /// Instancia 9 planetas con su atributo id y una lista de 1 pregunta vacia en la priemera posicion
        /// Los añade en la lista estatica "planetas"
        /// 
        /// Los 3 primeros planetas son idioma Catalan [0 - 1 - 2]
        /// Los 3 siguientes son Español [3 - 4 - 5]
        /// Los 3 últimos English [6 - 7 - 8]
        /// </summary>
        private void crearPlanetas()
        {
            for (byte i = 0; i < MAX_PLANETAS; i++)
            {
                // Instancia una pregunta con id 0 y string vacío
                Pregunta preguntaVacia = new Pregunta(0, "");
                
                // Instancia una lista de preguntas vacias 
                List<Pregunta> preguntasVacias = new List<Pregunta>();

                // Añade la pregunta vacía a la lista
                preguntasVacias.Add(preguntaVacia);

                // Crea un planeta con el id = i
                Planeta planetaVacio = new Planeta( i );

                // La lista de preguntas del planeta será la lista de preguntas vacías
                planetaVacio.preguntas = preguntasVacias;

                // Añade el planeta con su id y una pregunta vacía la lista estatica de planetas
                planetas.Add(planetaVacio);
            }
        }

        /// <summary>
        /// Hace dos cosas:
        ///     Da color a aquellos planetas que contengan almenos 1 pregunta
        ///     Al cambiar de idioma cambia la imagen de la bandera correspondiente
        /// </summary>
        /// <param name="idioma"></param> 
        private void colorPlanetas(int idioma)
        {
            switch (idioma)
            {
                case 0:
                    // Cambia la imagen y hace el control visible
                    pictureBoxBandera.Image = SerializarJSON.Properties.Resources.cat;
                    pictureBoxBandera.Visible = true;

                    if (planetas[0].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1false;
                    }
                    if (planetas[1].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2false;
                    }
                    if (planetas[2].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3false;
                    }

                    break;

                case 1:
                    // Cambia la imagen y hace el control visible
                    pictureBoxBandera.Image = SerializarJSON.Properties.Resources.esp;
                    pictureBoxBandera.Visible = true;
                    if (planetas[3].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1false;
                    }
                    if (planetas[4].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2false;
                    }
                    if (planetas[5].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3false;
                    }
                    break;

                case 2:
                    // Cambia la imagen y hace el control visible
                    pictureBoxBandera.Image = SerializarJSON.Properties.Resources.eng;
                    pictureBoxBandera.Visible = true;

                    if (planetas[6].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta1.Image = SerializarJSON.Properties.Resources.Planeta1false;
                    }
                    if (planetas[7].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta2.Image = SerializarJSON.Properties.Resources.planeta2false;
                    }
                    if (planetas[8].preguntas.Count > 1)
                    {
                        // Cambia el planeta a color
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3true;
                    }
                    else
                    {
                        // Quita el color del planeta
                        pictureBoxPlaneta3.Image = SerializarJSON.Properties.Resources.planeta3false;
                    }
                    break;
            }
        }
        
    }
}
