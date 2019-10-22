using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SerializarJSON
{
    public partial class GestorJuego : Form
    {
        //Constantes necesarias para mover form
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
                
        // Lista para guardarlas
        List<Respuesta> listaRespuestas = new List<Respuesta>();
        // Lista de contenidos
        public List<Contenido> listaContenidos = new List<Contenido>();
        // Crea un objeto save dialog
        SaveFileDialog SaveFileDialogGuardar = new SaveFileDialog();
        // Guarda el número de respuestas posibles (Incrementa al darle a "Afegir" y decrementa con "Eliminar")
        public byte nRespostes = 2;
        // id de pregunta guardada
        int idPregunta = 0;



        /*    EVENTOS
         *    ███████╗██╗   ██╗ ███████╗ ███╗   ██╗████████╗ ██████╗  ███████╗
         *    ██╔════╝██║   ██║ ██╔════╝ ████╗  ██║╚══██╔══╝██╔═══██╗ ██╔════╝
         *    █████╗  ██║   ██║ █████╗   ██╔██╗ ██║   ██║   ██║   ██║ ███████╗
         *    ██╔══╝  ╚██╗ ██╔╝ ██╔══╝   ██║╚██╗██║   ██║   ██║   ██║ ╚════██║
         *    ███████╗ ╚████╔╝  ███████╗ ██║ ╚████║   ██║   ╚██████╔╝ ███████║
         *    ╚══════╝  ╚═══╝   ╚══════╝ ╚═╝  ╚═══╝   ╚═╝    ╚═════╝  ╚══════╝                                                                 
         */

        // Inicializa los componentes
        public GestorJuego()
        {
            InitializeComponent();
        }
       
        // Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        // Refrescar listBoxContenidos
        private void refrescarListBox()
        {
            listBoxContenidos.DataSource = null;
            listBoxContenidos.DataSource = listaContenidos;
            listBoxContenidos.DisplayMember = "displayMember";            
        }
        
        // Botón para salir
        private void pictureBoxSortir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Segur que vols sortir?", "Confirmar sortida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }        

        // Selección de un elemento de la listbox de contenidos
        private void listBoxContenidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Asigna a ContenidoMostrado el contenido seleccionado en la listbox
                //(Contenido): Cast para convertir de object a Pelicula
            Contenido contenidoMostrado = (Contenido)listBoxContenidos.SelectedItem;

            //Si el contenido no es nulo
            if (contenidoMostrado != null)
            {
                //Muestra en los campos correspondientes a los valores guardados
                textBoxPregunta.Text = contenidoMostrado.pregunta.strPregunta;
                textBoxResposta1.Text = contenidoMostrado.respuestas[0].strResposta;
                textBoxResposta2.Text = contenidoMostrado.respuestas[1].strResposta;
                textBoxResposta3.Text = contenidoMostrado.respuestas[2].strResposta;
                textBoxResposta4.Text = contenidoMostrado.respuestas[3].strResposta;

                switch (contenidoMostrado.respuestaCorrecta)
                {
                    case 1:
                        radioButtonA.Checked = true;
                        break;
                    case 2:
                        radioButtonB.Checked = true;
                        break;
                    case 3:
                        radioButtonC.Checked = true;
                        break;
                    case 4:
                        radioButtonD.Checked = true;
                        break;
                }
                if (contenidoMostrado.pregunta.dificultat)
                {
                    radioButtonDificil.Checked = true;
                }
                else
                {
                    radioButtonFacil.Checked = true;
                }
            }
            
        }
     
        // Boton importar
        private void pictureBoxImportar_Click(object sender, EventArgs e)
        {
            //Importar JSON CODIGO
        }

        // Boton Exportar
        private void pictureBoxExportar_Click(object sender, EventArgs e)
        {
            //Opciones del saveDialog para nombre y extension
            SaveFileDialogGuardar.FileName = "Contingut";
            SaveFileDialogGuardar.DefaultExt = "*.json";
            SaveFileDialogGuardar.DefaultExt = ".json";

            //Muestra pantalla para guardar el fichero
            if (SaveFileDialogGuardar.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = SaveFileDialogGuardar.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                //Serializa JSON y guarda
                sw.Write(Newtonsoft.Json.JsonConvert.SerializeObject(listaContenidos));

                //Cierra streams
                sw.Close();
                fileStream.Close();
            }
        }

        // Guardar y añadir a la listbox
        private void pictureBoxGuardar_Click(object sender, EventArgs e)
        {
            // Vacia la lista de respuestas
            listaRespuestas.Clear();

            // Instancia 4 respuestas (Algunas pueden contener string vacío)
            Respuesta a = new Respuesta(textBoxResposta1.Text);
            Respuesta b = new Respuesta(textBoxResposta2.Text);
            Respuesta c = new Respuesta(textBoxResposta3.Text);
            Respuesta d = new Respuesta(textBoxResposta4.Text);

            // Añade las 4 respuesta a la listaRespuestas
            listaRespuestas.Add(a);
            listaRespuestas.Add(b);
            listaRespuestas.Add(c);
            listaRespuestas.Add(d);

            // Si el formulario es correcto
            if (validarDatos(textBoxPregunta.Text, listaRespuestas))
            {
                // Instancia pregunta con id, dificultad y la pregunta
                Pregunta pregunta = new Pregunta(idPregunta, dificultat(), textBoxPregunta.Text);
                
                // La siguiente pregunta tendrá un id distinto
                idPregunta++;

                // Instancia 4 respuestas con id, respuesta y si es correcta o no
                //  (Algunas pueden contener string vacío)
                Respuesta respuestaA = new Respuesta(1, a.strResposta, esCorrecte(1));
                Respuesta respuestaB = new Respuesta(2, b.strResposta, esCorrecte(2));
                Respuesta respuestaC = new Respuesta(3, c.strResposta, esCorrecte(3));
                Respuesta respuestaD = new Respuesta(4, d.strResposta, esCorrecte(4));

                //Vacia la lista de respuestas
                listaRespuestas.Clear();

                //Añade aquellas respuestas que contengan una respuesta(string) a la lista
                listaRespuestas.Add(respuestaA);
                listaRespuestas.Add(respuestaB);
                listaRespuestas.Add(respuestaC);
                listaRespuestas.Add(respuestaD);
                    
                

                //Instancia y crea contenido
                Contenido contenido = new Contenido(pregunta, listaRespuestas, respCorrecte(respuestaA, respuestaB, respuestaC, respuestaD));

                //Añade contenido a la lista de contenidos
                listaContenidos.Add(contenido);

                //Añade al listBox el nuevo contenido
                refrescarListBox();

                //Limpia textboxs
                limpiarCampos();
            }
        }

        //Limpia todos los campos para poder añadir una nueva pregunta
        private void pictureBoxNetejar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            listBoxContenidos.ClearSelected();
            textBoxPregunta.Focus();
        }

        // Elimina elemento del listbox y de la lista de contenidos
        private void pictureBoxEliminarSel_Click(object sender, EventArgs e)
        {
            if (listBoxContenidos.SelectedItems.Count > 0)
            {
                listaContenidos.RemoveAt(listBoxContenidos.SelectedIndex);
                idPregunta--;
                refrescarListBox();
            }
        }

        // Minimizar formulario
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Afegir textbox resposta
        private void pictureBoxAfegir_Click(object sender, EventArgs e)
        {            
            if (!textBoxResposta3.Visible)
            {
                textBoxResposta3.Visible = true;
                radioButtonC.Visible = true;
                nRespostes++;
            }
            else if (!textBoxResposta4.Visible)
            {
                textBoxResposta4.Visible = true;
                radioButtonD.Visible = true;
                nRespostes++;
            }
        }

        // Eliminar textbox reposta
        private void pictureBoxEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxResposta4.Visible)
            {
                textBoxResposta4.Visible = false;
                textBoxResposta4.Clear();
                radioButtonD.Visible = false;
                radioButtonD.Checked = false;
                nRespostes--;
            }
            else if (textBoxResposta3.Visible)
            {
                textBoxResposta3.Visible = false;
                textBoxResposta3.Clear();
                radioButtonC.Visible = false;
                radioButtonC.Checked = false;
                nRespostes--;
            }
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
        /// Limpia textbox pregunta/respuestas y desmarca todos los radioButtons.
        /// </summary>
        private void limpiarCampos()
        {
            textBoxPregunta.Clear();
            textBoxResposta1.Clear();
            textBoxResposta2.Clear();
            textBoxResposta3.Clear();
            textBoxResposta4.Clear();

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

            radioButtonDificil.Checked = false;
            radioButtonFacil.Checked = false;
        }

        /// <summary>
        /// Retorna TRUE si se ha seleccionado alguna respuesta correcta
        /// </summary>
        /// <returns></returns>
        private bool respostaCorrecteSeleccioanda()
        {
            //Resposta correcte seleccionada
            bool correcte = false;
            if (radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked || radioButtonD.Checked)
            {
                correcte = true;
            }
            else
            {
                MessageBox.Show("Selecciona quina és la resposta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelRespostaCorrecte.Focus();
            }

            return correcte;
        }

        /// <summary>
        /// Retorna TRUE si se ha seleccionado una dificultad.
        /// </summary>
        /// <returns></returns>
        private bool dificultatSeleccionada()
        {
            // Dificultat seleccionada
            bool dificultat = false;
            if (radioButtonFacil.Checked || radioButtonDificil.Checked)
            {
                dificultat = true;
            }
            else
            {
                MessageBox.Show("Selecciona la dificultat de la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPregunta.Focus();
            }

            return dificultat;
        }

        /// <summary>
        /// Si el usuario ha rellenado el formulario y no existe ya la pregunta: retorna TRUE. Sino FALSE.
        /// </summary>
        /// <param name="pregunta"></param>
        /// <param name="respostes"></param>
        /// <returns></returns>
        private bool validarDatos(String pregunta, List<Respuesta> respostes)
        {
            //Comprovacion datos validos
            bool formularioCorrecto = false;

            if ((!string.IsNullOrEmpty(textBoxPregunta.Text)) && comprobarRespuestas(respostes) && respostaCorrecteSeleccioanda() && dificultatSeleccionada() && (!comprobarRepetidas()))
            {
                formularioCorrecto = true;
            }

            return formularioCorrecto;
        }

        /// <summary>
        /// Devuelve TRUE si la pregunta ya existe. Sino FALSE.
        /// </summary>
        /// <returns></returns>
        private bool comprobarRepetidas()
        {
            bool coincidencia = false;
            for (int i = 0; i < listaContenidos.Count; i++)
            {
                if (textBoxPregunta.Text == listaContenidos[i].pregunta.strPregunta)
                {
                    MessageBox.Show("Aquesta pregunta ja existeix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPregunta.Focus();
                    coincidencia = true;
                }
            }
            return coincidencia;
        }
        
        /// <summary>
        /// Comprueba que todas las respuestas no sean nulas o estén vacías. Usa método respuestaIsNullOrEmpty().
        /// </summary>
        /// <param name="respostes"></param>
        /// <returns></returns>
        private bool comprobarRespuestas(List<Respuesta> ListRespostes)
        {
            bool retorno = false;
            byte numRespCorrectes = 0;
            for (int i = 0; i < nRespostes; i++)
            {
                if (respuestaIsNullOrEmpty(ListRespostes[i].strResposta))
                {
                    numRespCorrectes++;
                }
                else
                {
                    MessageBox.Show("Introdueix la resposta que falta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (numRespCorrectes == nRespostes)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Retorna TRUE si la respuesta es nula o vacía, sino FALSE
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns></returns>
        private bool respuestaIsNullOrEmpty(String respuesta)
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(respuesta))
            {
                retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// Devuelve TRUE si la pregunta es dificil, FALSE si es facil.
        /// </summary>
        /// <returns></returns>
        private bool dificultat()
        {
            bool dificultat = false;
            if (radioButtonDificil.Checked)
            {
                dificultat = true;
            }
            return dificultat;
        }

        /// <summary>
        /// Retorna: 0 = ERROR // Numero de la respuesta correcta (1,2,3,4)
        /// </summary>
        /// <param name="respuestaA"></param>
        /// <param name="respuestaB"></param>
        /// <param name="respuestaC"></param>
        /// <param name="respuestaD"></param>
        /// <returns></returns>
        private static byte respCorrecte(Respuesta respuestaA, Respuesta respuestaB, Respuesta respuestaC, Respuesta respuestaD)
        {
            byte respCorrecte = 0;
            if (respuestaA.esCorrecte)
            {
                respCorrecte = 1;
            }
            else if (respuestaB.esCorrecte)
            {
                respCorrecte = 2;
            }
            else if (respuestaC.esCorrecte)
            {
                respCorrecte = 3;
            }
            else if (respuestaD.esCorrecte)
            {
                respCorrecte = 4;
            }
            return respCorrecte;
        }

        /// <summary>
        /// Retorna TRUE si esta respuesta es marcada como correcta, sino FALSE.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool esCorrecte(byte id)
        {
            bool correcte = false;
            switch (id)
            {
                case 1:
                    if (radioButtonA.Checked)
                    {
                        correcte = true;
                    }
                    break;
                case 2:
                    if (radioButtonB.Checked)
                    {
                        correcte = true;
                    }
                    break;
                case 3:
                    if (radioButtonC.Checked)
                    {
                        correcte = true;
                    }
                    break;
                case 4:
                    if (radioButtonD.Checked)
                    {
                        correcte = true;
                    }
                    break;

            }

            return correcte;
        }
        // Abre ventana de ayuda
        private void pictureBoxAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda ajuda = new FormAjuda(0);
            ajuda.Show();
        }
    }
}
