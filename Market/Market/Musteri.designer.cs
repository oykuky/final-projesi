namespace Market
{
    partial class Musteri
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
            this.gBoxMusBilg = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.textBoxAdS = new System.Windows.Forms.TextBox();
            this.labelMadSoy = new System.Windows.Forms.Label();
            this.textBoxMusId = new System.Windows.Forms.TextBox();
            this.labelİrsNo = new System.Windows.Forms.Label();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.gBoxMBBakiye = new System.Windows.Forms.GroupBox();
            this.btOde = new System.Windows.Forms.Button();
            this.textBoxBorcMiktr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxMusBilg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.gBoxMBBakiye.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxMusBilg
            // 
            this.gBoxMusBilg.BackColor = System.Drawing.Color.DimGray;
            this.gBoxMusBilg.Controls.Add(this.textBoxBorcMiktr);
            this.gBoxMusBilg.Controls.Add(this.label2);
            this.gBoxMusBilg.Controls.Add(this.btnGuncelle);
            this.gBoxMusBilg.Controls.Add(this.btnSil);
            this.gBoxMusBilg.Controls.Add(this.btnEkle);
            this.gBoxMusBilg.Controls.Add(this.textBoxAdS);
            this.gBoxMusBilg.Controls.Add(this.labelMadSoy);
            this.gBoxMusBilg.Controls.Add(this.textBoxMusId);
            this.gBoxMusBilg.Controls.Add(this.labelİrsNo);
            this.gBoxMusBilg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxMusBilg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxMusBilg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBoxMusBilg.Location = new System.Drawing.Point(12, 31);
            this.gBoxMusBilg.Name = "gBoxMusBilg";
            this.gBoxMusBilg.Size = new System.Drawing.Size(239, 290);
            this.gBoxMusBilg.TabIndex = 4;
            this.gBoxMusBilg.TabStop = false;
            this.gBoxMusBilg.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(128, 183);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(83, 29);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gold;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(69, 227);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 29);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gold;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(10, 183);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 29);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // textBoxAdS
            // 
            this.textBoxAdS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdS.Location = new System.Drawing.Point(111, 79);
            this.textBoxAdS.Name = "textBoxAdS";
            this.textBoxAdS.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdS.TabIndex = 3;
            // 
            // labelMadSoy
            // 
            this.labelMadSoy.AutoSize = true;
            this.labelMadSoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMadSoy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMadSoy.Location = new System.Drawing.Point(6, 79);
            this.labelMadSoy.Name = "labelMadSoy";
            this.labelMadSoy.Size = new System.Drawing.Size(71, 18);
            this.labelMadSoy.TabIndex = 2;
            this.labelMadSoy.Text = "Ad Soyad";
            // 
            // textBoxMusId
            // 
            this.textBoxMusId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMusId.Location = new System.Drawing.Point(111, 38);
            this.textBoxMusId.Name = "textBoxMusId";
            this.textBoxMusId.Size = new System.Drawing.Size(100, 22);
            this.textBoxMusId.TabIndex = 1;
            // 
            // labelİrsNo
            // 
            this.labelİrsNo.AutoSize = true;
            this.labelİrsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelİrsNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelİrsNo.Location = new System.Drawing.Point(6, 38);
            this.labelİrsNo.Name = "labelİrsNo";
            this.labelİrsNo.Size = new System.Drawing.Size(75, 18);
            this.labelİrsNo.TabIndex = 0;
            this.labelİrsNo.Text = "Müşteri ID";
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.GridColor = System.Drawing.Color.Gold;
            this.dgvMusteriler.Location = new System.Drawing.Point(282, 36);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.Size = new System.Drawing.Size(480, 476);
            this.dgvMusteriler.TabIndex = 5;
            this.dgvMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriler_CellContentClick);
            // 
            // gBoxMBBakiye
            // 
            this.gBoxMBBakiye.Controls.Add(this.btOde);
            this.gBoxMBBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxMBBakiye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBoxMBBakiye.Location = new System.Drawing.Point(12, 338);
            this.gBoxMBBakiye.Name = "gBoxMBBakiye";
            this.gBoxMBBakiye.Size = new System.Drawing.Size(239, 182);
            this.gBoxMBBakiye.TabIndex = 6;
            this.gBoxMBBakiye.TabStop = false;
            this.gBoxMBBakiye.Text = "BORÇ ÖDEME iŞLEMLERİNİ BAŞLATMAK İÇİN TIKLAYIN";
            // 
            // btOde
            // 
            this.btOde.BackColor = System.Drawing.Color.Gold;
            this.btOde.FlatAppearance.BorderSize = 0;
            this.btOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOde.ForeColor = System.Drawing.Color.White;
            this.btOde.Location = new System.Drawing.Point(56, 88);
            this.btOde.Name = "btOde";
            this.btOde.Size = new System.Drawing.Size(118, 45);
            this.btOde.TabIndex = 8;
            this.btOde.Text = "Borç Ödeme";
            this.btOde.UseVisualStyleBackColor = false;
            this.btOde.Click += new System.EventHandler(this.btOde_Click);
            // 
            // textBoxBorcMiktr
            // 
            this.textBoxBorcMiktr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBorcMiktr.Location = new System.Drawing.Point(112, 118);
            this.textBoxBorcMiktr.Name = "textBoxBorcMiktr";
            this.textBoxBorcMiktr.Size = new System.Drawing.Size(100, 22);
            this.textBoxBorcMiktr.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Borç Miktarı";
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(774, 532);
            this.Controls.Add(this.gBoxMBBakiye);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.gBoxMusBilg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musteri";
            this.Text = "Müsteri";
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.gBoxMusBilg.ResumeLayout(false);
            this.gBoxMusBilg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.gBoxMBBakiye.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxMusBilg;
        private System.Windows.Forms.TextBox textBoxAdS;
        private System.Windows.Forms.Label labelMadSoy;
        private System.Windows.Forms.TextBox textBoxMusId;
        private System.Windows.Forms.Label labelİrsNo;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox gBoxMBBakiye;
        private System.Windows.Forms.Button btOde;
        private System.Windows.Forms.TextBox textBoxBorcMiktr;
        private System.Windows.Forms.Label label2;
    }
}