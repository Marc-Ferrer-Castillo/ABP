namespace SerializarJSON
{
    partial class FormGestorContingut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestorContingut));
            this.pictureBoxSiguiente = new System.Windows.Forms.PictureBox();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSiguiente
            // 
            this.pictureBoxSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSiguiente.Location = new System.Drawing.Point(980, 527);
            this.pictureBoxSiguiente.Name = "pictureBoxSiguiente";
            this.pictureBoxSiguiente.Size = new System.Drawing.Size(145, 41);
            this.pictureBoxSiguiente.TabIndex = 0;
            this.pictureBoxSiguiente.TabStop = false;
            this.pictureBoxSiguiente.Click += new System.EventHandler(this.pictureBoxSiguiente_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxContenido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContenido.Font = new System.Drawing.Font("Myriad Pro Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContenido.Location = new System.Drawing.Point(99, 182);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(1026, 336);
            this.textBoxContenido.TabIndex = 1;
            // 
            // FormGestorContingut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.pictureBoxSiguiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1230, 600);
            this.MinimumSize = new System.Drawing.Size(1230, 600);
            this.Name = "FormGestorContingut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestorContingut";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiguiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSiguiente;
        private System.Windows.Forms.TextBox textBoxContenido;
    }
}