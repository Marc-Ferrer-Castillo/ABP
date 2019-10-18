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
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        //Lista de strings para las respuestas
        List<string> listaRespuestas;
        //Lista de contenidos
        public List<Contenido> listaContenidos = new List<Contenido>();
        //Crea un objeto save dialog
        SaveFileDialog SaveFileDialogGuardar = new SaveFileDialog();

        //Inicializa los componentes
        public GestorJuego()
        {
            InitializeComponent();
        }
       
        //Permite mover la ventana
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //Refrescar listBoxContenidos
        private void refrescarListBox()
        {
            listBoxContenidos.DataSource = null;
            listBoxContenidos.DataSource = listaContenidos;
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

        // Limpia los textboxs
        private void limpiarCampos()
        {
            textBoxPregunta.Clear();
            textBoxResposta1.Text = " A) ";
            textBoxResposta2.Text = " B) ";
            textBoxResposta3.Text = " C) ";
            textBoxResposta4.Text = " D) ";

            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }



        // Selección de un elemento de la listbox de contenidos
        private void listBoxContenidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Asigna a ContenidoMostrado el contenido seleccionado en la listbox
                //(Contenido): Cast para convertir de object a Pelicula
            Contenido ContenidoMostrado = (Contenido)listBoxContenidos.SelectedItem;

            //Si el contenido no es nulo
            if (ContenidoMostrado != null)
            {
                //Muestra en los campos correspondientes los valores guardados
                textBoxPregunta.Text = ContenidoMostrado.pregunta;
                textBoxResposta1.Text = ContenidoMostrado.respuestas[0];
                textBoxResposta2.Text = ContenidoMostrado.respuestas[1];
                textBoxResposta3.Text = ContenidoMostrado.respuestas[2];
                textBoxResposta4.Text = ContenidoMostrado.respuestas[3];
                switch (ContenidoMostrado.respuestaCorrecta)
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

        // Guardar
        private void pictureBoxGuardar_Click(object sender, EventArgs e)
        {
            //Comprovacion datos validos
            bool formularioCorrecto = false;
            if (!string.IsNullOrEmpty(textBoxPregunta.Text))
            {
                if (!string.IsNullOrEmpty(textBoxResposta1.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxResposta2.Text))
                    {
                        if (!string.IsNullOrEmpty(textBoxResposta3.Text))
                        {
                            if (!string.IsNullOrEmpty(textBoxResposta4.Text))
                            {
                                if (radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked || radioButtonD.Checked)
                                {
                                    bool coincidencia = true;
                                    for (int i = 0; i < listaContenidos.Count; i++)
                                    {
                                        if (textBoxPregunta.Text == listaContenidos[i].pregunta)
                                        {
                                            MessageBox.Show("Aquesta pregunta ja existeix", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBoxPregunta.Focus();
                                            coincidencia = false;
                                        }
                                    }
                                    formularioCorrecto = coincidencia;
                                }
                                else
                                {
                                    MessageBox.Show("Indica quina es la resposta correcte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    panelRespostaCorrecte.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introdueix una resposta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxResposta4.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introdueix una resposta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxResposta3.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introdueix una resposta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxResposta2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Introdueix una resposta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxResposta1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Introdueix una pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPregunta.Focus();
            }

            //Si el formulario es correcto
            if (formularioCorrecto)
            {
                //Instancia una lista de respuestas
                listaRespuestas = new List<string>();
                //Guarda la respuesta correctada marcada en el radiobutton
                int respuestaCorrecta = -1;

                //Añade todas las respuestas a la lista
                listaRespuestas.Add(textBoxResposta1.Text);
                listaRespuestas.Add(textBoxResposta2.Text);
                listaRespuestas.Add(textBoxResposta3.Text);
                listaRespuestas.Add(textBoxResposta4.Text);

                if (radioButtonA.Checked)
                {
                    respuestaCorrecta = 1;
                }
                else
                {
                    if (radioButtonB.Checked)
                    {
                        respuestaCorrecta = 2;
                    }
                    else
                    {
                        if (radioButtonC.Checked)
                        {
                            respuestaCorrecta = 3;
                        }
                        else
                        {
                            if (radioButtonD.Checked)
                            {
                                respuestaCorrecta = 4;
                            }
                            else
                            {

                            }
                        }
                    }
                }

                //Instancia y crea contenido
                Contenido contenido = new Contenido(textBoxPregunta.Text, listaRespuestas, respuestaCorrecta);

                //Añade contenido a la lista de contenidos
                listaContenidos.Add(contenido);

                //Limpia textboxs
                limpiarCampos();

                //Añade al listBox el nuevo contenido
                refrescarListBox();
            }
        }

        // Elimina elemento del listbox
        private void pictureBoxEliminarSel_Click(object sender, EventArgs e)
        {
            if (listBoxContenidos.SelectedItems.Count > 0)
            {
                listaContenidos.RemoveAt(listBoxContenidos.SelectedIndex);
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
            }
            else if (!textBoxResposta4.Visible)
            {
                textBoxResposta4.Visible = true;
                radioButtonD.Visible = true;
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
            }
            else if (textBoxResposta3.Visible)
            {
                textBoxResposta3.Visible = false;
                textBoxResposta3.Clear();
                radioButtonC.Visible = false;
                radioButtonC.Checked = false;
            }
        }
    }
}
