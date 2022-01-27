namespace Sistema_Cine
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Line_1 = new System.Windows.Forms.PictureBox();
            this.Line_2 = new System.Windows.Forms.PictureBox();
            this.Login_Lbl = new System.Windows.Forms.Label();
            this.Information_Btn = new System.Windows.Forms.Button();
            this.User_Pbx = new System.Windows.Forms.PictureBox();
            this.Key_Pbx = new System.Windows.Forms.PictureBox();
            this.User_Tbx = new System.Windows.Forms.TextBox();
            this.Key_Tbx = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Line_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key_Pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // Line_1
            // 
            this.Line_1.BackColor = System.Drawing.Color.White;
            this.Line_1.Location = new System.Drawing.Point(-1, -1);
            this.Line_1.Name = "Line_1";
            this.Line_1.Size = new System.Drawing.Size(301, 53);
            this.Line_1.TabIndex = 0;
            this.Line_1.TabStop = false;
            // 
            // Line_2
            // 
            this.Line_2.BackColor = System.Drawing.Color.White;
            this.Line_2.Location = new System.Drawing.Point(-1, 245);
            this.Line_2.Name = "Line_2";
            this.Line_2.Size = new System.Drawing.Size(301, 53);
            this.Line_2.TabIndex = 1;
            this.Line_2.TabStop = false;
            // 
            // Login_Lbl
            // 
            this.Login_Lbl.AutoSize = true;
            this.Login_Lbl.BackColor = System.Drawing.Color.White;
            this.Login_Lbl.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Login_Lbl.Location = new System.Drawing.Point(36, 9);
            this.Login_Lbl.Name = "Login_Lbl";
            this.Login_Lbl.Size = new System.Drawing.Size(223, 30);
            this.Login_Lbl.TabIndex = 2;
            this.Login_Lbl.Text = "INICIO DE SESION";
            // 
            // Information_Btn
            // 
            this.Information_Btn.BackColor = System.Drawing.Color.White;
            this.Information_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Information_Btn.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information_Btn.ForeColor = System.Drawing.Color.Firebrick;
            this.Information_Btn.Location = new System.Drawing.Point(-1, 245);
            this.Information_Btn.Name = "Information_Btn";
            this.Information_Btn.Size = new System.Drawing.Size(301, 53);
            this.Information_Btn.TabIndex = 3;
            this.Information_Btn.Text = "ACERCA DE";
            this.Information_Btn.UseVisualStyleBackColor = false;
            this.Information_Btn.Click += new System.EventHandler(this.Information_Btn_Click);
            // 
            // User_Pbx
            // 
            this.User_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("User_Pbx.Image")));
            this.User_Pbx.Location = new System.Drawing.Point(31, 73);
            this.User_Pbx.Name = "User_Pbx";
            this.User_Pbx.Size = new System.Drawing.Size(52, 39);
            this.User_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_Pbx.TabIndex = 4;
            this.User_Pbx.TabStop = false;
            // 
            // Key_Pbx
            // 
            this.Key_Pbx.Image = ((System.Drawing.Image)(resources.GetObject("Key_Pbx.Image")));
            this.Key_Pbx.Location = new System.Drawing.Point(31, 132);
            this.Key_Pbx.Name = "Key_Pbx";
            this.Key_Pbx.Size = new System.Drawing.Size(52, 39);
            this.Key_Pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Key_Pbx.TabIndex = 5;
            this.Key_Pbx.TabStop = false;
            // 
            // User_Tbx
            // 
            this.User_Tbx.Location = new System.Drawing.Point(100, 82);
            this.User_Tbx.Name = "User_Tbx";
            this.User_Tbx.Size = new System.Drawing.Size(168, 20);
            this.User_Tbx.TabIndex = 6;
            // 
            // Key_Tbx
            // 
            this.Key_Tbx.Location = new System.Drawing.Point(100, 142);
            this.Key_Tbx.Name = "Key_Tbx";
            this.Key_Tbx.PasswordChar = '•';
            this.Key_Tbx.Size = new System.Drawing.Size(168, 20);
            this.Key_Tbx.TabIndex = 7;
            // 
            // Login_Btn
            // 
            this.Login_Btn.BackColor = System.Drawing.Color.White;
            this.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Btn.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.Firebrick;
            this.Login_Btn.Location = new System.Drawing.Point(31, 184);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(107, 45);
            this.Login_Btn.TabIndex = 8;
            this.Login_Btn.Text = "INICIAR";
            this.Login_Btn.UseVisualStyleBackColor = false;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.BackColor = System.Drawing.Color.White;
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.Color.Firebrick;
            this.Exit_Btn.Location = new System.Drawing.Point(155, 184);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(113, 45);
            this.Exit_Btn.TabIndex = 9;
            this.Exit_Btn.Text = "SALIR";
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(299, 297);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Key_Tbx);
            this.Controls.Add(this.User_Tbx);
            this.Controls.Add(this.Key_Pbx);
            this.Controls.Add(this.User_Pbx);
            this.Controls.Add(this.Information_Btn);
            this.Controls.Add(this.Login_Lbl);
            this.Controls.Add(this.Line_2);
            this.Controls.Add(this.Line_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Line_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key_Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Line_1;
        private System.Windows.Forms.PictureBox Line_2;
        private System.Windows.Forms.Label Login_Lbl;
        private System.Windows.Forms.Button Information_Btn;
        private System.Windows.Forms.PictureBox User_Pbx;
        private System.Windows.Forms.PictureBox Key_Pbx;
        private System.Windows.Forms.TextBox User_Tbx;
        private System.Windows.Forms.TextBox Key_Tbx;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Button Exit_Btn;
    }
}