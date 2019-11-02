namespace SerializarJSON
{
    partial class FormAjuda
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
            this.pictureBoxSortir = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAjuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSortir
            // 
            this.pictureBoxSortir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSortir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSortir.Location = new System.Drawing.Point(913, 15);
            this.pictureBoxSortir.Name = "pictureBoxSortir";
            this.pictureBoxSortir.Size = new System.Drawing.Size(80, 33);
            this.pictureBoxSortir.TabIndex = 1;
            this.pictureBoxSortir.TabStop = false;
            this.pictureBoxSortir.Click += new System.EventHandler(this.pictureBoxSortir_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(823, 15);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(84, 33);
            this.pictureBoxMinimizar.TabIndex = 2;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxAjuda
            // 
            this.pictureBoxAjuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAjuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAjuda.Image = global::SerializarJSON.Properties.Resources.Ajuda_Menu_Inici;
            this.pictureBoxAjuda.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAjuda.MaximumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjuda.MinimumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjuda.Name = "pictureBoxAjuda";
            this.pictureBoxAjuda.Size = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjuda.TabIndex = 0;
            this.pictureBoxAjuda.TabStop = false;
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBoxSortir);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxAjuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormAjuda";
            this.Text = "FormAjuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAjuda;
        private System.Windows.Forms.PictureBox pictureBoxSortir;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
    }
}