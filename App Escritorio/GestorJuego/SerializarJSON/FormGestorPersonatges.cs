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

        // Lista para los 3 personajes
        List<Personaje> listaPersonajes = new List<Personaje>();



        /***
        *     ██████╗ ██████╗ ███╗   ██╗███████╗████████╗██████╗ ██╗   ██╗ ██████╗████████╗ ██████╗ ██████╗ ███████╗███████╗
        *    ██╔════╝██╔═══██╗████╗  ██║██╔════╝╚══██╔══╝██╔══██╗██║   ██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗██╔════╝██╔════╝
        *    ██║     ██║   ██║██╔██╗ ██║███████╗   ██║   ██████╔╝██║   ██║██║        ██║   ██║   ██║██████╔╝█████╗  ███████╗
        *    ██║     ██║   ██║██║╚██╗██║╚════██║   ██║   ██╔══██╗██║   ██║██║        ██║   ██║   ██║██╔══██╗██╔══╝  ╚════██║
        *    ╚██████╗╚██████╔╝██║ ╚████║███████║   ██║   ██║  ██║╚██████╔╝╚██████╗   ██║   ╚██████╔╝██║  ██║███████╗███████║
        *     ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝  ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝
        *                                                                                                                   
        */
        //inicializar componentes
        public FormGestorPersonatges(List<Personaje> listaPersonajes)
        {
            InitializeComponent();
            inicializarPersonajes();
            this.listaPersonajes = listaPersonajes;
            
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

        private void FormGestorPersonatges_Load(object sender, EventArgs e)
        {
            //cargamos datos del 1º personaje
            textBoxNomP1.Text = listaPersonajes[0].nom;
            textBoxDesc1.Text = listaPersonajes[0].frase;

            if (listaPersonajes[0].rutaImagen != null)
            {
                pictureBoxPersonatge1.Image = Image.FromFile(listaPersonajes[0].rutaImagen);

            }


            //cargamos datos del 2º personaje
            textBoxNomP2.Text = listaPersonajes[1].nom;
            textBoxDesc2.Text = listaPersonajes[1].frase;

            if (listaPersonajes[1].rutaImagen != null)
            {
                pictureBoxPersonatge2.Image = Image.FromFile(listaPersonajes[1].rutaImagen);

            }

            //cargamos datos del 3º personaje
            textBoxNomP3.Text = listaPersonajes[2].nom;
            textBoxDesc3.Text = listaPersonajes[2].frase;


            if (listaPersonajes[2].rutaImagen != null)
            {
                pictureBoxPersonatge3.Image = Image.FromFile(listaPersonajes[2].rutaImagen);

            }

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

        // click volver al menu principal
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        // click minimizar
        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // click ajuda
        private void pictureBoxAjuda_Click(object sender, EventArgs e)
        {
            //el id 1 del FormAjuda corresponde con la ayuda para el gestor de personajes
            FormAjuda ajuda = new FormAjuda(1);
            ajuda.Show();
        }        

        //guardar personajes
        private void pictureBoxExportar_Click(object sender, EventArgs e)
        {

            //si hay campos vacios avisamos al usuario con el metodo campBuit();
            if (textBoxNomP1.Text == "")
            {
                campBuit();
                textBoxNomP1.Focus();
            }
            else if (textBoxDesc1.Text == "")
            {
                campBuit();
                textBoxDesc1.Focus();
            }
            else if (textBoxNomP2.Text == "")
            {
                campBuit();
                textBoxNomP2.Focus();
            }
            else if (textBoxDesc2.Text == "")
            {
                campBuit();
                textBoxDesc2.Focus();
            }
            else if (textBoxNomP3.Text == "")
            {
                campBuit();
                textBoxNomP3.Focus();
            }
            else if (textBoxDesc3.Text == "")
            {
                campBuit();
                textBoxDesc3.Focus();
            }
            //si hay imagenes sin cargar avisamos al usuario con el metodo campBuitImatge();
            else if (listaPersonajes[0].rutaImagen == null)
            {
                campBuitImatge();
            }
            else if (listaPersonajes[1].rutaImagen == null)
            {
                campBuitImatge();
            }
            else if (listaPersonajes[2].rutaImagen == null)
            {
                campBuitImatge();
            }
            else
            {
                //guardamos datos del 1º personaje
                listaPersonajes[0].nom = textBoxNomP1.Text;
                listaPersonajes[0].frase = textBoxDesc1.Text;

                //guardamos datos del 2º personaje
                listaPersonajes[1].nom = textBoxNomP2.Text;
                listaPersonajes[1].frase = textBoxDesc2.Text;

                //guardamos datos del 3º personaje
                listaPersonajes[2].nom = textBoxNomP3.Text;
                listaPersonajes[2].frase = textBoxDesc3.Text;

                Close();
            }

            
        }


        //Introducció de les imatges dels personatges i errors 
        private void pictureBoxPersonatge1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBoxPersonatge1.Image = Image.FromFile(imagen);
                    pictureBoxPersonatge1.BackColor = Color.DarkGray;

                    listaPersonajes[0].rutaImagen = imagen;


                }
            }
            catch (Exception)
            {
                errorImatge();
            }
        }

        private void pictureBoxPersonatge2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBoxPersonatge2.Image = Image.FromFile(imagen);
                    pictureBoxPersonatge2.BackColor = Color.DarkGray;

                    listaPersonajes[1].rutaImagen = imagen;
                }
            }
            catch (Exception)
            {
                errorImatge();
            }
        }

        private void pictureBoxPersonatge3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBoxPersonatge3.Image = Image.FromFile(imagen);
                    pictureBoxPersonatge3.BackColor = Color.DarkGray;

                    listaPersonajes[2].rutaImagen = imagen;
                }
            }
            catch (Exception)
            {
                errorImatge();
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

        //metodo para inicializar los personajes
        private void inicializarPersonajes()
        {
            foreach (var personaje in listaPersonajes)
            {
                personaje.nom = "";
                personaje.frase = "";
            }
        }

        // Muestra error en caso de que haya un campo vacio
        private void campBuit()
        {
            MessageBox.Show("Completa el camp buit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Muestra error en caso de imagen sin cargar
        private void campBuitImatge()
        {
            MessageBox.Show("Introdueixi una imatge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Muestra error en caso de que el archivo no sea una imagen
        private void errorImatge()
        {
            MessageBox.Show("El arxiu seleccionat no es una imatge");
        }

       
    }
}
