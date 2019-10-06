namespace SerializarJSON
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxSortir = new System.Windows.Forms.PictureBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.groupBoxContenido = new System.Windows.Forms.GroupBox();
            this.buttonNetejar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.groupBoxRespCorrecte = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.labelResposta4 = new System.Windows.Forms.Label();
            this.labelResposta3 = new System.Windows.Forms.Label();
            this.labelResposta2 = new System.Windows.Forms.Label();
            this.labelCorrecte = new System.Windows.Forms.Label();
            this.labelResposta1 = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.textBoxResposta4 = new System.Windows.Forms.TextBox();
            this.textBoxResposta3 = new System.Windows.Forms.TextBox();
            this.textBoxResposta2 = new System.Windows.Forms.TextBox();
            this.textBoxResposta1 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBoxContenidos = new System.Windows.Forms.ListBox();
            this.groupBoxListadoContenidos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).BeginInit();
            this.groupBoxContenido.SuspendLayout();
            this.groupBoxRespCorrecte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxListadoContenidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSortir
            // 
            this.pictureBoxSortir.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBoxContenido.Controls.Add(this.buttonNetejar);
            this.groupBoxContenido.Controls.Add(this.button1);
            this.groupBoxContenido.Controls.Add(this.buttonAfegir);
            this.groupBoxContenido.Controls.Add(this.groupBoxRespCorrecte);
            this.groupBoxContenido.Controls.Add(this.labelResposta4);
            this.groupBoxContenido.Controls.Add(this.labelResposta3);
            this.groupBoxContenido.Controls.Add(this.labelResposta2);
            this.groupBoxContenido.Controls.Add(this.labelCorrecte);
            this.groupBoxContenido.Controls.Add(this.labelResposta1);
            this.groupBoxContenido.Controls.Add(this.labelPregunta);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta4);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta3);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta2);
            this.groupBoxContenido.Controls.Add(this.textBoxResposta1);
            this.groupBoxContenido.Controls.Add(this.textBoxPregunta);
            resources.ApplyResources(this.groupBoxContenido, "groupBoxContenido");
            this.groupBoxContenido.Name = "groupBoxContenido";
            this.groupBoxContenido.TabStop = false;
            // 
            // buttonNetejar
            // 
            this.buttonNetejar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonNetejar, "buttonNetejar");
            this.buttonNetejar.Name = "buttonNetejar";
            this.buttonNetejar.UseVisualStyleBackColor = false;
            this.buttonNetejar.Click += new System.EventHandler(this.buttonNetejar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonAfegir, "buttonAfegir");
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // groupBoxRespCorrecte
            // 
            this.groupBoxRespCorrecte.Controls.Add(this.radioButtonD);
            this.groupBoxRespCorrecte.Controls.Add(this.radioButtonC);
            this.groupBoxRespCorrecte.Controls.Add(this.radioButtonB);
            this.groupBoxRespCorrecte.Controls.Add(this.radioButtonA);
            resources.ApplyResources(this.groupBoxRespCorrecte, "groupBoxRespCorrecte");
            this.groupBoxRespCorrecte.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxRespCorrecte.Name = "groupBoxRespCorrecte";
            this.groupBoxRespCorrecte.TabStop = false;
            // 
            // radioButtonD
            // 
            resources.ApplyResources(this.radioButtonD, "radioButtonD");
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.TabStop = true;
            this.radioButtonD.UseVisualStyleBackColor = true;
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
            // radioButtonA
            // 
            resources.ApplyResources(this.radioButtonA, "radioButtonA");
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.TabStop = true;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // labelResposta4
            // 
            resources.ApplyResources(this.labelResposta4, "labelResposta4");
            this.labelResposta4.BackColor = System.Drawing.Color.Transparent;
            this.labelResposta4.ForeColor = System.Drawing.Color.Silver;
            this.labelResposta4.Name = "labelResposta4";
            // 
            // labelResposta3
            // 
            resources.ApplyResources(this.labelResposta3, "labelResposta3");
            this.labelResposta3.BackColor = System.Drawing.Color.Transparent;
            this.labelResposta3.ForeColor = System.Drawing.Color.Silver;
            this.labelResposta3.Name = "labelResposta3";
            // 
            // labelResposta2
            // 
            resources.ApplyResources(this.labelResposta2, "labelResposta2");
            this.labelResposta2.BackColor = System.Drawing.Color.Transparent;
            this.labelResposta2.ForeColor = System.Drawing.Color.Silver;
            this.labelResposta2.Name = "labelResposta2";
            // 
            // labelCorrecte
            // 
            resources.ApplyResources(this.labelCorrecte, "labelCorrecte");
            this.labelCorrecte.ForeColor = System.Drawing.Color.LightGray;
            this.labelCorrecte.Name = "labelCorrecte";
            // 
            // labelResposta1
            // 
            resources.ApplyResources(this.labelResposta1, "labelResposta1");
            this.labelResposta1.BackColor = System.Drawing.Color.Transparent;
            this.labelResposta1.ForeColor = System.Drawing.Color.Silver;
            this.labelResposta1.Name = "labelResposta1";
            // 
            // labelPregunta
            // 
            resources.ApplyResources(this.labelPregunta, "labelPregunta");
            this.labelPregunta.BackColor = System.Drawing.Color.Transparent;
            this.labelPregunta.ForeColor = System.Drawing.Color.Silver;
            this.labelPregunta.Name = "labelPregunta";
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
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonGuardar, "buttonGuardar");
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxSortir_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.FileName = "Contingut";
            // 
            // listBoxContenidos
            // 
            this.listBoxContenidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(56)))));
            this.listBoxContenidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBoxContenidos, "listBoxContenidos");
            this.listBoxContenidos.ForeColor = System.Drawing.Color.White;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxContenido);
            this.Controls.Add(this.pictureBoxSortir);
            this.Controls.Add(this.groupBoxListadoContenidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).EndInit();
            this.groupBoxContenido.ResumeLayout(false);
            this.groupBoxContenido.PerformLayout();
            this.groupBoxRespCorrecte.ResumeLayout(false);
            this.groupBoxRespCorrecte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxListadoContenidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSortir;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.GroupBox groupBoxContenido;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelResposta1;
        private System.Windows.Forms.TextBox textBoxResposta1;
        private System.Windows.Forms.Label labelResposta4;
        private System.Windows.Forms.Label labelResposta3;
        private System.Windows.Forms.Label labelResposta2;
        private System.Windows.Forms.TextBox textBoxResposta4;
        private System.Windows.Forms.TextBox textBoxResposta3;
        private System.Windows.Forms.TextBox textBoxResposta2;
        private System.Windows.Forms.GroupBox groupBoxRespCorrecte;
        private System.Windows.Forms.Label labelCorrecte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonNetejar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBoxContenidos;
        private System.Windows.Forms.GroupBox groupBoxListadoContenidos;
        private System.Windows.Forms.Button button1;
    }
}

