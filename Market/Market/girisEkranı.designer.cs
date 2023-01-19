namespace Market
{
    partial class girisEkranı
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.hosgeldiniz_txt = new System.Windows.Forms.TextBox();
            this.k_adi_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.beni_hatirla = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.giris_foto = new System.Windows.Forms.PictureBox();
            this.sifre_foto = new System.Windows.Forms.PictureBox();
            this.kadi_foto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.design_foto = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Button();
            this.button_giris = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifre_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadi_foto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.design_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(766, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 48);
            this.panel3.TabIndex = 15;
            // 
            // hosgeldiniz_txt
            // 
            this.hosgeldiniz_txt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hosgeldiniz_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hosgeldiniz_txt.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldiniz_txt.Location = new System.Drawing.Point(56, 194);
            this.hosgeldiniz_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hosgeldiniz_txt.Name = "hosgeldiniz_txt";
            this.hosgeldiniz_txt.Size = new System.Drawing.Size(304, 30);
            this.hosgeldiniz_txt.TabIndex = 8;
            this.hosgeldiniz_txt.Text = "Hoş geldiniz!";
            this.hosgeldiniz_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // k_adi_txt
            // 
            this.k_adi_txt.BackColor = System.Drawing.SystemColors.Menu;
            this.k_adi_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.k_adi_txt.Location = new System.Drawing.Point(70, 295);
            this.k_adi_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.k_adi_txt.Name = "k_adi_txt";
            this.k_adi_txt.Size = new System.Drawing.Size(249, 19);
            this.k_adi_txt.TabIndex = 10;
            this.k_adi_txt.Text = "Kullanıcı adı";
            this.k_adi_txt.TextChanged += new System.EventHandler(this.k_adi_txt_TextChanged);
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Menu;
            this.sifre_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre_txt.Location = new System.Drawing.Point(70, 381);
            this.sifre_txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(249, 19);
            this.sifre_txt.TabIndex = 12;
            this.sifre_txt.Text = "Şifre";
            // 
            // beni_hatirla
            // 
            this.beni_hatirla.AutoSize = true;
            this.beni_hatirla.Cursor = System.Windows.Forms.Cursors.Default;
            this.beni_hatirla.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.beni_hatirla.Location = new System.Drawing.Point(56, 443);
            this.beni_hatirla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beni_hatirla.Name = "beni_hatirla";
            this.beni_hatirla.Size = new System.Drawing.Size(98, 21);
            this.beni_hatirla.TabIndex = 6;
            this.beni_hatirla.Text = "Beni hatırla";
            this.beni_hatirla.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.beni_hatirla);
            this.panel2.Controls.Add(this.sifre_txt);
            this.panel2.Controls.Add(this.giris_foto);
            this.panel2.Controls.Add(this.sifre_foto);
            this.panel2.Controls.Add(this.k_adi_txt);
            this.panel2.Controls.Add(this.hosgeldiniz_txt);
            this.panel2.Controls.Add(this.kadi_foto);
            this.panel2.Controls.Add(this.button_giris);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(424, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 954);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // giris_foto
            // 
          
            this.giris_foto.Location = new System.Drawing.Point(145, 81);
            this.giris_foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.giris_foto.Name = "giris_foto";
            this.giris_foto.Size = new System.Drawing.Size(117, 103);
            this.giris_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.giris_foto.TabIndex = 4;
            this.giris_foto.TabStop = false;
            this.giris_foto.Click += new System.EventHandler(this.giris_foto_Click);
            // 
            // sifre_foto
            // 
        
            this.sifre_foto.Location = new System.Drawing.Point(42, 336);
            this.sifre_foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sifre_foto.Name = "sifre_foto";
            this.sifre_foto.Size = new System.Drawing.Size(304, 116);
            this.sifre_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sifre_foto.TabIndex = 11;
            this.sifre_foto.TabStop = false;
            // 
            // kadi_foto
            // 
            
            this.kadi_foto.Location = new System.Drawing.Point(42, 234);
            this.kadi_foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kadi_foto.Name = "kadi_foto";
            this.kadi_foto.Size = new System.Drawing.Size(304, 137);
            this.kadi_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kadi_foto.TabIndex = 1;
            this.kadi_foto.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.design_foto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 954);
            this.panel1.TabIndex = 13;
            // 
            // design_foto
            // 
            this.design_foto.Dock = System.Windows.Forms.DockStyle.Left;
            
            this.design_foto.Location = new System.Drawing.Point(0, 0);
            this.design_foto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.design_foto.Name = "design_foto";
            this.design_foto.Size = new System.Drawing.Size(458, 954);
            this.design_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.design_foto.TabIndex = 0;
            this.design_foto.TabStop = false;
            this.design_foto.Click += new System.EventHandler(this.design_foto_Click);
            // 
            // close_button
            // 
 
            this.close_button.Location = new System.Drawing.Point(773, 12);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(34, 34);
            this.close_button.TabIndex = 5;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_giris.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_giris.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_giris.Location = new System.Drawing.Point(99, 497);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(179, 59);
            this.button_giris.TabIndex = 13;
            this.button_giris.Text = "Giriş Yap";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // girisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 954);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "girisEkranı";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giris_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sifre_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kadi_foto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.design_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox design_foto;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox kadi_foto;
        private System.Windows.Forms.TextBox hosgeldiniz_txt;
        private System.Windows.Forms.TextBox k_adi_txt;
        private System.Windows.Forms.PictureBox sifre_foto;
        private System.Windows.Forms.PictureBox giris_foto;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.CheckBox beni_hatirla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_giris;
    }
}