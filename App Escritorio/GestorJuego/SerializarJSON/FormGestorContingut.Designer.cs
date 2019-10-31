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
            this.pictureBoxSiguiente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiguiente)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSiguiente
            // 
            this.pictureBoxSiguiente.Location = new System.Drawing.Point(1180, 599);
            this.pictureBoxSiguiente.Name = "pictureBoxSiguiente";
            this.pictureBoxSiguiente.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxSiguiente.TabIndex = 0;
            this.pictureBoxSiguiente.TabStop = false;
            this.pictureBoxSiguiente.Click += new System.EventHandler(this.pictureBoxSiguiente_Click);
            // 
            // FormGestorContingut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 661);
            this.Controls.Add(this.pictureBoxSiguiente);
            this.Name = "FormGestorContingut";
            this.Text = "FormGestorContingut";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiguiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSiguiente;
    }
}