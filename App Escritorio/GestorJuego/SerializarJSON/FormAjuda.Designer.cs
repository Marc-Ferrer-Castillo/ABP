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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            this.pictureBoxAjudaMainMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjudaMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAjudaMainMenu
            // 
            this.pictureBoxAjudaMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAjudaMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAjudaMainMenu.Image")));
            this.pictureBoxAjudaMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAjudaMainMenu.MaximumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.MinimumSize = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.Name = "pictureBoxAjudaMainMenu";
            this.pictureBoxAjudaMainMenu.Size = new System.Drawing.Size(1000, 600);
            this.pictureBoxAjudaMainMenu.TabIndex = 0;
            this.pictureBoxAjudaMainMenu.TabStop = false;
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pictureBoxAjudaMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormAjuda";
            this.Text = "FormAjuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjudaMainMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAjudaMainMenu;
    }
}