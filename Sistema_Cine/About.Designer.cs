namespace Sistema_Cine
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Line_1 = new System.Windows.Forms.PictureBox();
            this.About_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Film_Pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Line_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Line_1
            // 
            this.Line_1.BackColor = System.Drawing.Color.White;
            this.Line_1.Location = new System.Drawing.Point(-1, -1);
            this.Line_1.Name = "Line_1";
            this.Line_1.Size = new System.Drawing.Size(288, 43);
            this.Line_1.TabIndex = 1;
            this.Line_1.TabStop = false;
            // 
            // About_Lbl
            // 
            this.About_Lbl.AutoSize = true;
            this.About_Lbl.BackColor = System.Drawing.Color.White;
            this.About_Lbl.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.About_Lbl.Location = new System.Drawing.Point(63, 9);
            this.About_Lbl.Name = "About_Lbl";
            this.About_Lbl.Size = new System.Drawing.Size(166, 26);
            this.About_Lbl.TabIndex = 3;
            this.About_Lbl.Text = "INFORMACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 136);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desarrollado por Venados Technology\r\n\r\nISC. Gómez Bazúa Enrique.\r\nISC. Grijalva T" +
    "acho Juan Pablo.\r\nISC. López Núñez Luis Antonio.\r\n\r\nContacto:\r\nvenadostechnology" +
    "@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Film_Pbx
            // 
            this.Film_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("Film_Pbx.Image")));
            this.Film_Pbx.Location = new System.Drawing.Point(203, 131);
            this.Film_Pbx.Name = "Film_Pbx";
            this.Film_Pbx.Size = new System.Drawing.Size(75, 62);
            this.Film_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Film_Pbx.TabIndex = 19;
            this.Film_Pbx.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(280, 199);
            this.Controls.Add(this.Film_Pbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.About_Lbl);
            this.Controls.Add(this.Line_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.Line_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Film_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Line_1;
        private System.Windows.Forms.Label About_Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Film_Pbx;
    }
}