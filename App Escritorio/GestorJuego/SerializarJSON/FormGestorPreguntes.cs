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
    public partial class FormGestorPreguntes : Form
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


        /***
        *     █████╗ ████████╗██████╗ ██╗██████╗ ██╗   ██╗████████╗ ██████╗ ███████╗
        *    ██╔══██╗╚══██╔══╝██╔══██╗██║██╔══██╗██║   ██║╚══██╔══╝██╔═══██╗██╔════╝
        *    ███████║   ██║   ██████╔╝██║██████╔╝██║   ██║   ██║   ██║   ██║███████╗
        *    ██╔══██║   ██║   ██╔══██╗██║██╔══██╗██║   ██║   ██║   ██║   ██║╚════██║
        *    ██║  ██║   ██║   ██║  ██║██║██████╔╝╚██████╔╝   ██║   ╚██████╔╝███████║
        *    ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═════╝  ╚═════╝    ╚═╝    ╚═════╝ ╚══════╝
        *                                                                           
        */

        // Guarda información de un planeta recibido del gestor de contenido
        Planeta planeta = new Planeta();

        // Guarda el id de la pregunta
        byte idPregunta = 0;

        // Lista para guardar 4 respuestas
        List<Respuesta> listaRespuestas = new List<Respuesta>();

        // Lista de preguntas
        List<Pregunta> listaPreguntas = new List<Pregunta>();

        //// Crea un objeto save dialog
        //SaveFileDialog SaveFileDialogGuardar = new SaveFileDialog();

        // Guarda el número de respuestas posibles (Incrementa al darle a "Afegir" y decrementa con "Eliminar")
        public byte nRespostes = 2;


        /***
        *     ██████╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗ ██╗   ██╗ ██████╗████████╗ ██████╗ ██████╗ ███████╗███████╗
        *    ██╔════╝██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗██╔════╝██╔════╝
        *    ██║     ██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝██║   ██║██║        ██║   ██║   ██║██████╔╝█████╗  ███████╗
        *    ██║     ██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██║   ██║██║        ██║   ██║   ██║██╔══██╗██╔══╝  ╚════██║
        *    ╚██████╗╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║╚██████╔╝╚██████╗   ██║   ╚██████╔╝██║  ██║███████╗███████║
        *     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝  ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝
        *                                                                                                                   
        */

        // Constructor del formulario
        public FormGestorPreguntes(Planeta planeta)
        {
            InitializeComponent();
                        
            this.planeta = planeta;

            // Si el planeta recibido ya contiene preguntas, se agregan a la lista
            try
            {
                for (int i = 0; i < planeta.preguntas.Count; i++)
                {
                    // Añade las preguntas a la lista
                    listaPreguntas.Add(planeta.preguntas[i]);

                    // Borra la primera pregunta que viene vacía
                    listaPreguntas.RemoveAt(0);
                }
                
                refrescarListBox();

            }catch (Exception) { }
            
                
            
        }




        /*    EVENTOS
         *    ███████╗██╗   ██╗ ███████╗ ███╗   ██╗████████╗ ██████╗  ███████╗
         *    ██╔════╝██║   ██║ ██╔════╝ ████╗  ██║╚══██╔══╝██╔═══██╗ ██╔════╝
         *    █████╗  ██║   ██║ █████╗   ██╔██╗ ██║   ██║   ██║   ██║ ███████╗
         *    ██╔══╝  ╚██╗ ██╔╝ ██╔══╝   ██║╚██╗██║   ██║   ██║   ██║ ╚════██║
         *    ███████╗ ╚████╔╝  ███████╗ ██║ ╚████║   ██║   ╚██████╔╝ ███████║
         *    ╚══════╝  ╚═══╝   ╚══════╝ ╚═╝  ╚═══╝   ╚═╝    ╚═════╝  ╚══════╝                                                                 
         */

        // Guardar y añadir a la listbox
        private void pictureBoxGuardar_Click(object sender, EventArgs e)
        {
            // Guarda las respuestas de los textbox en una lista para ser verificadas
            List<String> respuestasTextBoxs = new List<string>();
            respuestasTextBoxs.Add(textBoxResposta1.Text);
            respuestasTextBoxs.Add(textBoxResposta2.Text);
            if (nRespostes == 3)
            {
                respuestasTextBoxs.Add(textBoxResposta3.Text);
            }
            else if (nRespostes == 4)
            {
                respuestasTextBoxs.Add(textBoxResposta3.Text);
                respuestasTextBoxs.Add(textBoxResposta4.Text);
            }


            bool formularioCorrecto = false;

            // Comprueba que se haya introducido una pregunta
            if ( Metodo.revisarContenido(textBoxPregunta.Text) )
            {
                // Comprueba que no haya ninguna pregunta repetida
                if ( Metodo.preguntaRepetida(textBoxPregunta.Text, listaPreguntas) )
                {
                    // Comprueba que no falte por marcar algun radioButton
                    if ( radioCheck() )
                    {
                        // Comprueba que se hayan introducido 
                        if ( Metodo.revisarContenido( respuestasTextBoxs) )
                        {
                            formularioCorrecto = true;
                        }
                        else
                        {
                            //Error
                            MessageBox.Show("Introdueix la resposta que falta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    
                }
                else
                {
                    //Error
                    MessageBox.Show("Aquesta pregunta ja existeix", "Pregunta duplicada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPregunta.Focus();
                }
            }
            else
            {
                //Error
                MessageBox.Show("Escriu una pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPregunta.Focus();
            }

            // Si se han pasado todas las comprobaciones
            if ( formularioCorrecto )
            {
                // Vacia la lista de respuestas
                listaRespuestas.Clear();

                // Instancia tantas respuestas como textBoxs haya activado el usuario
                // Después las añade a la lista
                Respuesta a = new Respuesta(1, textBoxResposta1.Text, radioButtonA.Checked);
                Respuesta b = new Respuesta(2, textBoxResposta2.Text, radioButtonB.Checked);
                listaRespuestas.Add(a);
                listaRespuestas.Add(b);
                if (nRespostes == 3)
                {
                    Respuesta c = new Respuesta(3, textBoxResposta3.Text, radioButtonC.Checked);
                    listaRespuestas.Add(c);
                }
                else if (nRespostes == 4)
                {
                    Respuesta c = new Respuesta(3, textBoxResposta3.Text, radioButtonC.Checked);
                    Respuesta d = new Respuesta(4, textBoxResposta4.Text, radioButtonD.Checked);
                    listaRespuestas.Add(c);
                    listaRespuestas.Add(d);
                }

                // Instancia pregunta y la añade a la lista de preguntas
                Pregunta pregunta = new Pregunta(idPregunta++, textBoxPregunta.Text, listaRespuestas, radioButtonFacil.Checked);
                listaPreguntas.Add(pregunta);

                //Añade al listBox el nuevo contenido
                refrescarListBox();

                //Limpia todos los campos para rellenar de nuevo el formulario
                limpiarCampos();
            }
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
            listBoxContenidos.DataSource = listaPreguntas;
            listBoxContenidos.DisplayMember = "pregunta";
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

        // Selección de un elemento de la listbox de contenidos FALTA PROGRAMAR
        private void listBoxContenidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Asigna a ContenidoMostrado el contenido seleccionado en la listbox
            //    //(Contenido): Cast para convertir de object a Pelicula
            //Contenido contenidoMostrado = (Contenido)listBoxContenidos.SelectedItem;

            ////Si el contenido no es nulo
            //if (contenidoMostrado != null)
            //{
            //    //Muestra en los campos correspondientes a los valores guardados
            //    textBoxPregunta.Text = contenidoMostrado.pregunta.strPregunta;
            //    textBoxResposta1.Text = contenidoMostrado.respuestas[0].strResposta;
            //    textBoxResposta2.Text = contenidoMostrado.respuestas[1].strResposta;
            //    textBoxResposta3.Text = contenidoMostrado.respuestas[2].strResposta;
            //    textBoxResposta4.Text = contenidoMostrado.respuestas[3].strResposta;

            //    switch (contenidoMostrado.respuestaCorrecta)
            //    {
            //        case 1:
            //            radioButtonA.Checked = true;
            //            break;
            //        case 2:
            //            radioButtonB.Checked = true;
            //            break;
            //        case 3:
            //            radioButtonC.Checked = true;
            //            break;
            //        case 4:
            //            radioButtonD.Checked = true;
            //            break;
            //    }
            //    if (contenidoMostrado.pregunta.dificultat)
            //    {
            //        radioButtonDificil.Checked = true;
            //    }
            //    else
            //    {
            //        radioButtonFacil.Checked = true;
            //    }
            //}
            
        }
     
        // Boton importar FALTA PROGRAMAR Y CAMBIAR NOMBRE
        private void pictureBoxImportar_Click(object sender, EventArgs e)
        {
            //Importar JSON CODIGO
        }

        //Limpia todos los campos para poder añadir una nueva pregunta FALTA PROGRAMAR
        private void pictureBoxNetejar_Click(object sender, EventArgs e)
        {
            //limpiarCampos();
            //listBoxContenidos.ClearSelected();
            //textBoxPregunta.Focus();
        }

        // Elimina elemento del listbox y de la lista de contenidos FALTA PROGRAMAR
        private void pictureBoxEliminarSel_Click(object sender, EventArgs e)
        {
            //if (listBoxContenidos.SelectedItems.Count > 0)
            //{
            //    listaContenidos.RemoveAt(listBoxContenidos.SelectedIndex);
            //    idPregunta--;
            //    refrescarListBox();
            //}
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

        // Abre ventana de ayuda
        private void pictureBoxAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda ajuda = new FormAjuda(0);
            ajuda.Show();
        }

        // Botón Continuar
        private void pictureBoxContinuar_Click(object sender, EventArgs e)
        {
            // Si hay alguna pregunta
            if (listaPreguntas.Count > 0)
            {
                // Instancia un planeta nuevo                
                Planeta planetaNuevo = new Planeta(this.planeta.id, this.planeta.contenido, listaPreguntas);

                FormMenuPrincipal.planetas[this.planeta.id] = planetaNuevo;

                this.Close();
            }
            else
            {
                //Error
                MessageBox.Show("No hi han dades per guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Abre formulario gestor de personatges FALTA PROGRAMAR
        private void pictureBoxGestPersonatges_Click(object sender, EventArgs e)
        {
            ////Pasa por constructor el numero de preguntas para limitar el numero de personajes/rangos
            //if (listaContenidos.Count > 0)
            //{
            //    FormGestorPersonatges formPersonatges = new FormGestorPersonatges(listaContenidos.Count);
            //    formPersonatges.ShowDialog();
            //}

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
        /// Retorna FALSE si falta por marcar un radioButton
        /// </summary>
        /// <returns></returns>
        private bool radioCheck()
        {
            //Resposta correcte seleccionada
            bool retorno = false;

            if (radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked || radioButtonD.Checked)
            {
                retorno = true;
            }
            else
            {
                //Error
                MessageBox.Show("Indica una resposta correcte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelRespostaCorrecte.Focus();
            }
            if (radioButtonFacil.Checked || radioButtonDificil.Checked)
            {
                retorno = true;
            }
            else
            {
                //Error
                MessageBox.Show("Indica una dificultat", "Error dificultat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelRespostaCorrecte.Focus();
            }

            return retorno;
        }

        
    }
}
