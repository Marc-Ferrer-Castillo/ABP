﻿namespace SerializarJSON
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.pictureBoxSortir = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAjuda = new System.Windows.Forms.PictureBox();
            this.pictureBoxExportar = new System.Windows.Forms.PictureBox();
            this.buttonPlaneta1 = new System.Windows.Forms.Button();
            this.buttonPlaneta2 = new System.Windows.Forms.Button();
            this.buttonPlaneta3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSortir
            // 
            this.pictureBoxSortir.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSortir.Location = new System.Drawing.Point(422, 13);
            this.pictureBoxSortir.Name = "pictureBoxSortir";
            this.pictureBoxSortir.Size = new System.Drawing.Size(69, 29);
            this.pictureBoxSortir.TabIndex = 0;
            this.pictureBoxSortir.TabStop = false;
            this.pictureBoxSortir.Click += new System.EventHandler(this.pictureBoxSortir_Click);
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(350, 13);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(66, 29);
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxAjuda
            // 
            this.pictureBoxAjuda.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAjuda.Location = new System.Drawing.Point(286, 12);
            this.pictureBoxAjuda.Name = "pictureBoxAjuda";
            this.pictureBoxAjuda.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxAjuda.TabIndex = 2;
            this.pictureBoxAjuda.TabStop = false;
            this.pictureBoxAjuda.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxExportar
            // 
            this.pictureBoxExportar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExportar.Location = new System.Drawing.Point(179, 522);
            this.pictureBoxExportar.Name = "pictureBoxExportar";
            this.pictureBoxExportar.Size = new System.Drawing.Size(142, 42);
            this.pictureBoxExportar.TabIndex = 3;
            this.pictureBoxExportar.TabStop = false;
            this.pictureBoxExportar.Click += new System.EventHandler(this.pictureBoxExportar_Click);
            // 
            // buttonPlaneta1
            // 
            this.buttonPlaneta1.Location = new System.Drawing.Point(63, 272);
            this.buttonPlaneta1.Name = "buttonPlaneta1";
            this.buttonPlaneta1.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaneta1.TabIndex = 4;
            this.buttonPlaneta1.Text = "Planeta 1";
            this.buttonPlaneta1.UseVisualStyleBackColor = true;
            this.buttonPlaneta1.Click += new System.EventHandler(this.buttonPlaneta1_Click);
            // 
            // buttonPlaneta2
            // 
            this.buttonPlaneta2.Location = new System.Drawing.Point(210, 272);
            this.buttonPlaneta2.Name = "buttonPlaneta2";
            this.buttonPlaneta2.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaneta2.TabIndex = 5;
            this.buttonPlaneta2.Text = "Planeta 2";
            this.buttonPlaneta2.UseVisualStyleBackColor = true;
            // 
            // buttonPlaneta3
            // 
            this.buttonPlaneta3.Location = new System.Drawing.Point(364, 272);
            this.buttonPlaneta3.Name = "buttonPlaneta3";
            this.buttonPlaneta3.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaneta3.TabIndex = 6;
            this.buttonPlaneta3.Text = "Planeta 3";
            this.buttonPlaneta3.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 599);
            this.Controls.Add(this.buttonPlaneta3);
            this.Controls.Add(this.buttonPlaneta2);
            this.Controls.Add(this.buttonPlaneta1);
            this.Controls.Add(this.pictureBoxExportar);
            this.Controls.Add(this.pictureBoxAjuda);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxSortir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSortir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAjuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExportar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSortir;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxAjuda;
        private System.Windows.Forms.PictureBox pictureBoxExportar;
        private System.Windows.Forms.Button buttonPlaneta1;
        private System.Windows.Forms.Button buttonPlaneta2;
        private System.Windows.Forms.Button buttonPlaneta3;
    }
}