namespace SerializarJSON
{
    partial class GestorJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorJuego));
            this.pictureBoxSortir = new System.Windows.Forms.PictureBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.groupBoxContenido = new System.Windows.Forms.GroupBox();
            this.pictureBoxNetejar = new System.Windows.Forms.PictureBox();
            this.panelRespostaCorrecte = new System.Windows.Forms.Panel();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfegir = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuardar = new System.Windows.Forms.PictureBox();
            this.groupBoxDificultat = new System.Windows.Forms.GroupBox();
            this.radioButtonDificil = new System.Windows.Forms.RadioButton();
            this.radioButtonFacil = new System.Windows.Forms.RadioButton();
            this.textBoxResposta4 = new System.Windows.Forms.TextBox();
            this.textBoxResposta3 = new System.Windows.Forms.TextBox();
            this.textBoxResposta2 = new System.Windows.Forms.TextBox();
            this.textBoxResposta1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBoxContenidos = new System.Windows.Forms.ListBox();
            this.groupBoxListadoContenidos = new System.Windows.Forms.GroupBox();
            this.pictureBoxGestPersonatges = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxImportar = new System.Windows.Forms.PictureBox();
            this.pictureBoxExportar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminarSel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).BeginInit();
            this.groupBoxContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetejar)).BeginInit();
            this.panelRespostaCorrecte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfegir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).BeginInit();
            this.groupBoxDificultat.SuspendLayout();
            this.groupBoxListadoContenidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestPersonatges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarSel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSortir
            // 
            this.pictureBoxSortir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSortir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxSortir, "pictureBoxSortir");
            this.pictureBoxSortir.Name = "pictureBoxSortir";
            this.pictureBoxSortir.TabStop = false;
            this.pictureBoxSortir.Click += new System.EventHandler(this.pictureBoxSortir_Click);
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBoxPregunta.AutoCompleteCustomSource")});
            this.textBoxPregunta.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPregunta, "textBoxPregunta");
            this.textBoxPregunta.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPregunta.Name = "textBoxPregunta";
            // 
            // groupBoxContenido
            // 
            this.groupBoxContenido.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxContenido.Controls.Add(this.pictureBoxNetejar);
            this.groupBoxContenido.Controls.Add(this.panelRespostaCorrecte);
            this.groupBoxContenido.Controls.Add(this.pictureBoxEliminar);
            this.groupBoxContenido.Controls.Add(this.pictureBoxAfegir);
            this.groupBoxContenido.Controls.Add(this.pictureBoxGuardar);
            this.groupBoxContenido.Controls.Add(this.groupBoxDificultat);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta4);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta3);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta2);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta1);
            this.groupBoxContenido.Controls.Add(this.textBoxPregunta);
            resources.ApplyResources(this.groupBoxContenido, "groupBoxContenido");
            this.groupBoxContenido.Name = "groupBoxContenido";
            this.groupBoxContenido.TabStop = false;
            // 
            // pictureBoxNetejar
            // 
            this.pictureBoxNetejar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxNetejar, "pictureBoxNetejar");
            this.pictureBoxNetejar.Name = "pictureBoxNetejar";
            this.pictureBoxNetejar.TabStop = false;
            this.pictureBoxNetejar.Click += new System.EventHandler(this.pictureBoxNetejar_Click);
            // 
            // panelRespostaCorrecte
            // 
            this.panelRespostaCorrecte.Controls.Add(this.radioButtonD);
            this.panelRespostaCorrecte.Controls.Add(this.radioButtonA);
            this.panelRespostaCorrecte.Controls.Add(this.radioButtonC);
            this.panelRespostaCorrecte.Controls.Add(this.radioButtonB);
            resources.ApplyResources(this.panelRespostaCorrecte, "panelRespostaCorrecte");
            this.panelRespostaCorrecte.Name = "panelRespostaCorrecte";
            // 
            // radioButtonD
            // 
            resources.ApplyResources(this.radioButtonD, "radioButtonD");
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.TabStop = true;
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            resources.ApplyResources(this.radioButtonA, "radioButtonA");
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.TabStop = true;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            resources.ApplyResources(this.radioButtonC, "radioButtonC");
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.TabStop = true;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            resources.ApplyResources(this.radioButtonB, "radioButtonB");
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.TabStop = true;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxEliminar, "pictureBoxEliminar");
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.TabStop = false;
            this.pictureBoxEliminar.Click += new System.EventHandler(this.pictureBoxEliminar_Click);
            // 
            // pictureBoxAfegir
            // 
            this.pictureBoxAfegir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxAfegir, "pictureBoxAfegir");
            this.pictureBoxAfegir.Name = "pictureBoxAfegir";
            this.pictureBoxAfegir.TabStop = false;
            this.pictureBoxAfegir.Click += new System.EventHandler(this.pictureBoxAfegir_Click);
            // 
            // pictureBoxGuardar
            // 
            this.pictureBoxGuardar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxGuardar, "pictureBoxGuardar");
            this.pictureBoxGuardar.Name = "pictureBoxGuardar";
            this.pictureBoxGuardar.TabStop = false;
            this.pictureBoxGuardar.Click += new System.EventHandler(this.pictureBoxGuardar_Click);
            // 
            // groupBoxDificultat
            // 
            this.groupBoxDificultat.Controls.Add(this.radioButtonDificil);
            this.groupBoxDificultat.Controls.Add(this.radioButtonFacil);
            resources.ApplyResources(this.groupBoxDificultat, "groupBoxDificultat");
            this.groupBoxDificultat.Name = "groupBoxDificultat";
            this.groupBoxDificultat.TabStop = false;
            // 
            // radioButtonDificil
            // 
            resources.ApplyResources(this.radioButtonDificil, "radioButtonDificil");
            this.radioButtonDificil.Name = "radioButtonDificil";
            this.radioButtonDificil.TabStop = true;
            this.radioButtonDificil.UseVisualStyleBackColor = true;
            // 
            // radioButtonFacil
            // 
            resources.ApplyResources(this.radioButtonFacil, "radioButtonFacil");
            this.radioButtonFacil.Name = "radioButtonFacil";
            this.radioButtonFacil.TabStop = true;
            this.radioButtonFacil.UseVisualStyleBackColor = true;
            // 
            // textBoxResposta4
            // 
            this.textBoxResposta4.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResposta4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxResposta4, "textBoxResposta4");
            this.textBoxResposta4.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxResposta4.Name = "textBoxResposta4";
            // 
            // textBoxResposta3
            // 
            this.textBoxResposta3.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResposta3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxResposta3, "textBoxResposta3");
            this.textBoxResposta3.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxResposta3.Name = "textBoxResposta3";
            // 
            // textBoxResposta2
            // 
            this.textBoxResposta2.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResposta2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxResposta2, "textBoxResposta2");
            this.textBoxResposta2.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxResposta2.Name = "textBoxResposta2";
            // 
            // textBoxResposta1
            // 
            this.textBoxResposta1.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResposta1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxResposta1, "textBoxResposta1");
            this.textBoxResposta1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxResposta1.Name = "textBoxResposta1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.FileName = "Contingut";
            // 
            // listBoxContenidos
            // 
            this.listBoxContenidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.listBoxContenidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBoxContenidos, "listBoxContenidos");
            this.listBoxContenidos.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBoxContenidos.FormattingEnabled = true;
            this.listBoxContenidos.Name = "listBoxContenidos";
            this.listBoxContenidos.SelectedIndexChanged += new System.EventHandler(this.listBoxContenidos_SelectedIndexChanged);
            // 
            // groupBoxListadoContenidos
            // 
            this.groupBoxListadoContenidos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxListadoContenidos.Controls.Add(this.listBoxContenidos);
            resources.ApplyResources(this.groupBoxListadoContenidos, "groupBoxListadoContenidos");
            this.groupBoxListadoContenidos.Name = "groupBoxListadoContenidos";
            this.groupBoxListadoContenidos.TabStop = false;
            // 
            // pictureBoxGestPersonatges
            // 
            this.pictureBoxGestPersonatges.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGestPersonatges.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxGestPersonatges, "pictureBoxGestPersonatges");
            this.pictureBoxGestPersonatges.Name = "pictureBoxGestPersonatges";
            this.pictureBoxGestPersonatges.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxMinimizar, "pictureBoxMinimizar");
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxImportar
            // 
            this.pictureBoxImportar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImportar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxImportar, "pictureBoxImportar");
            this.pictureBoxImportar.Name = "pictureBoxImportar";
            this.pictureBoxImportar.TabStop = false;
            this.pictureBoxImportar.Click += new System.EventHandler(this.pictureBoxImportar_Click);
            // 
            // pictureBoxExportar
            // 
            this.pictureBoxExportar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxExportar, "pictureBoxExportar");
            this.pictureBoxExportar.Name = "pictureBoxExportar";
            this.pictureBoxExportar.TabStop = false;
            this.pictureBoxExportar.Click += new System.EventHandler(this.pictureBoxExportar_Click);
            // 
            // pictureBoxEliminarSel
            // 
            this.pictureBoxEliminarSel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEliminarSel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pictureBoxEliminarSel, "pictureBoxEliminarSel");
            this.pictureBoxEliminarSel.Name = "pictureBoxEliminarSel";
            this.pictureBoxEliminarSel.TabStop = false;
            this.pictureBoxEliminarSel.Click += new System.EventHandler(this.pictureBoxEliminarSel_Click);
            // 
            // GestorJuego
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = global::SerializarJSON.Properties.Resources.Disseny_Final;
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxEliminarSel);
            this.Controls.Add(this.pictureBoxExportar);
            this.Controls.Add(this.pictureBoxGestPersonatges);
            this.Controls.Add(this.pictureBoxImportar);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxSortir);
            this.Controls.Add(this.groupBoxContenido);
            this.Controls.Add(this.groupBoxListadoContenidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestorJuego";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).EndInit();
            this.groupBoxContenido.ResumeLayout(false);
            this.groupBoxContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNetejar)).EndInit();
            this.panelRespostaCorrecte.ResumeLayout(false);
            this.panelRespostaCorrecte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfegir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuardar)).EndInit();
            this.groupBoxDificultat.ResumeLayout(false);
            this.groupBoxDificultat.PerformLayout();
            this.groupBoxListadoContenidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGestPersonatges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminarSel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSortir;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.GroupBox groupBoxContenido;
        private System.Windows.Forms.TextBox textBoxResposta1;
        private System.Windows.Forms.TextBox textBoxResposta4;
        private System.Windows.Forms.TextBox textBoxResposta3;
        private System.Windows.Forms.TextBox textBoxResposta2;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBoxContenidos;
        private System.Windows.Forms.GroupBox groupBoxListadoContenidos;
        private System.Windows.Forms.GroupBox groupBoxDificultat;
        private System.Windows.Forms.RadioButton radioButtonDificil;
        private System.Windows.Forms.RadioButton radioButtonFacil;
        private System.Windows.Forms.PictureBox pictureBoxGestPersonatges;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxImportar;
        private System.Windows.Forms.PictureBox pictureBoxExportar;
        private System.Windows.Forms.PictureBox pictureBoxGuardar;
        private System.Windows.Forms.PictureBox pictureBoxEliminarSel;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
        private System.Windows.Forms.PictureBox pictureBoxAfegir;
        private System.Windows.Forms.Panel panelRespostaCorrecte;
        private System.Windows.Forms.PictureBox pictureBoxNetejar;
    }
}

