namespace Market
{
    partial class Urun
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
            this.gBoxUrunBilg = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textUadi = new System.Windows.Forms.TextBox();
            this.labelUAd = new System.Windows.Forms.Label();
            this.textMiktar = new System.Windows.Forms.TextBox();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.textFiyat = new System.Windows.Forms.TextBox();
            this.labelBFiyat = new System.Windows.Forms.Label();
            this.textUrunKod = new System.Windows.Forms.TextBox();
            this.labelUrunKod = new System.Windows.Forms.Label();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.btnStokİsle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gBoxUrunBilg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxUrunBilg
            // 
            this.gBoxUrunBilg.BackColor = System.Drawing.Color.DimGray;
            this.gBoxUrunBilg.Controls.Add(this.btnGuncelle);
            this.gBoxUrunBilg.Controls.Add(this.textUadi);
            this.gBoxUrunBilg.Controls.Add(this.labelUAd);
            this.gBoxUrunBilg.Controls.Add(this.textMiktar);
            this.gBoxUrunBilg.Controls.Add(this.labelMiktar);
            this.gBoxUrunBilg.Controls.Add(this.textFiyat);
            this.gBoxUrunBilg.Controls.Add(this.labelBFiyat);
            this.gBoxUrunBilg.Controls.Add(this.textUrunKod);
            this.gBoxUrunBilg.Controls.Add(this.labelUrunKod);
            this.gBoxUrunBilg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxUrunBilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxUrunBilg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBoxUrunBilg.Location = new System.Drawing.Point(62, 57);
            this.gBoxUrunBilg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxUrunBilg.Name = "gBoxUrunBilg";
            this.gBoxUrunBilg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBoxUrunBilg.Size = new System.Drawing.Size(342, 515);
            this.gBoxUrunBilg.TabIndex = 0;
            this.gBoxUrunBilg.TabStop = false;
            this.gBoxUrunBilg.Text = "Ürün Bilgileri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(110, 397);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 62);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textUadi
            // 
            this.textUadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUadi.Location = new System.Drawing.Point(166, 174);
            this.textUadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUadi.Name = "textUadi";
            this.textUadi.Size = new System.Drawing.Size(149, 30);
            this.textUadi.TabIndex = 13;
            // 
            // labelUAd
            // 
            this.labelUAd.AutoSize = true;
            this.labelUAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUAd.Location = new System.Drawing.Point(9, 171);
            this.labelUAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUAd.Name = "labelUAd";
            this.labelUAd.Size = new System.Drawing.Size(42, 29);
            this.labelUAd.TabIndex = 12;
            this.labelUAd.Text = "Ad";
            // 
            // textMiktar
            // 
            this.textMiktar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMiktar.Location = new System.Drawing.Point(166, 305);
            this.textMiktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMiktar.Name = "textMiktar";
            this.textMiktar.Size = new System.Drawing.Size(149, 30);
            this.textMiktar.TabIndex = 9;
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMiktar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMiktar.Location = new System.Drawing.Point(9, 308);
            this.labelMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(78, 29);
            this.labelMiktar.TabIndex = 8;
            this.labelMiktar.Text = "Miktar";
            // 
            // textFiyat
            // 
            this.textFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFiyat.Location = new System.Drawing.Point(166, 235);
            this.textFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(149, 30);
            this.textFiyat.TabIndex = 7;
            // 
            // labelBFiyat
            // 
            this.labelBFiyat.AutoSize = true;
            this.labelBFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBFiyat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBFiyat.Location = new System.Drawing.Point(9, 235);
            this.labelBFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBFiyat.Name = "labelBFiyat";
            this.labelBFiyat.Size = new System.Drawing.Size(64, 29);
            this.labelBFiyat.TabIndex = 6;
            this.labelBFiyat.Text = "Fiyat";
            // 
            // textUrunKod
            // 
            this.textUrunKod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUrunKod.Location = new System.Drawing.Point(166, 91);
            this.textUrunKod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUrunKod.Name = "textUrunKod";
            this.textUrunKod.Size = new System.Drawing.Size(149, 30);
            this.textUrunKod.TabIndex = 3;
            // 
            // labelUrunKod
            // 
            this.labelUrunKod.AutoSize = true;
            this.labelUrunKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunKod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUrunKod.Location = new System.Drawing.Point(9, 91);
            this.labelUrunKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUrunKod.Name = "labelUrunKod";
            this.labelUrunKod.Size = new System.Drawing.Size(127, 29);
            this.labelUrunKod.TabIndex = 2;
            this.labelUrunKod.Text = "Ürün Kodu";
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.GridColor = System.Drawing.Color.Gold;
            this.dgvUrunler.Location = new System.Drawing.Point(464, 57);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 62;
            this.dgvUrunler.Size = new System.Drawing.Size(720, 742);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            // 
            // btnStokİsle
            // 
            this.btnStokİsle.BackColor = System.Drawing.Color.Gold;
            this.btnStokİsle.FlatAppearance.BorderSize = 0;
            this.btnStokİsle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokİsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokİsle.ForeColor = System.Drawing.Color.White;
            this.btnStokİsle.Location = new System.Drawing.Point(171, 668);
            this.btnStokİsle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStokİsle.Name = "btnStokİsle";
            this.btnStokİsle.Size = new System.Drawing.Size(124, 62);
            this.btnStokİsle.TabIndex = 5;
            this.btnStokİsle.Text = "Stok İşle";
            this.btnStokİsle.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1202, 817);
            this.Controls.Add(this.btnStokİsle);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.gBoxUrunBilg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Urun";
            this.Text = "Ürün";
            this.gBoxUrunBilg.ResumeLayout(false);
            this.gBoxUrunBilg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxUrunBilg;
        private System.Windows.Forms.TextBox textFiyat;
        private System.Windows.Forms.Label labelBFiyat;
        private System.Windows.Forms.TextBox textUrunKod;
        private System.Windows.Forms.Label labelUrunKod;
        private System.Windows.Forms.TextBox textMiktar;
        private System.Windows.Forms.Label labelMiktar;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.TextBox textUadi;
        private System.Windows.Forms.Label labelUAd;
        private System.Windows.Forms.Button btnStokİsle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}