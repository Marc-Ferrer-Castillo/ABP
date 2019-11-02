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
            this.pictureBoxAjuda = new System.Windows.Forms.PictureBox();
            this.pictureBoxAjudaMainMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxSortir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjudaMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAjuda
            // 
            this.pictureBoxAjuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAjuda.Image = global::SerializarJSON.Properties.Resources.Ajuda_Preguntes;
            this.pictureBoxAjuda.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAjuda.Name = "pictureBoxAjuda";
            this.pictureBoxAjuda.Size = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjuda.TabIndex = 1;
            this.pictureBoxAjuda.TabStop = false;
            // 
            // pictureBoxAjudaMainMenu
            // 
            this.pictureBoxAjudaMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAjudaMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAjudaMainMenu.MaximumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.MinimumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.Name = "pictureBoxAjudaMainMenu";
            this.pictureBoxAjudaMainMenu.Size = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.TabIndex = 0;
            this.pictureBoxAjudaMainMenu.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(819, 12);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(84, 33);
            this.pictureBoxMinimizar.TabIndex = 3;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxSortir
            // 
            this.pictureBoxSortir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSortir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSortir.Location = new System.Drawing.Point(912, 12);
            this.pictureBoxSortir.Name = "pictureBoxSortir";
            this.pictureBoxSortir.Size = new System.Drawing.Size(80, 33);
            this.pictureBoxSortir.TabIndex = 4;
            this.pictureBoxSortir.TabStop = false;
            this.pictureBoxSortir.Click += new System.EventHandler(this.pictureBoxSortir_Click);
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBoxSortir);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxAjuda);
            this.Controls.Add(this.pictureBoxAjudaMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormAjuda";
            this.Text = "FormAjuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjudaMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAjudaMainMenu;
        private System.Windows.Forms.PictureBox pictureBoxAjuda;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxSortir;
    }
}