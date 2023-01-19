namespace Market
{
    partial class MustBorcOdeme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSatinAlma = new System.Windows.Forms.DataGridView();
            this.lblMıd = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBMusId = new System.Windows.Forms.TextBox();
            this.GBMusteriAra = new System.Windows.Forms.GroupBox();
            this.btnMgetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.lblOdTutar = new System.Windows.Forms.Label();
            this.textBOdeMiktar = new System.Windows.Forms.TextBox();
            this.lblTopBorc = new System.Windows.Forms.Label();
            this.lblSatinAlmalar = new System.Windows.Forms.Label();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlma)).BeginInit();
            this.pnlBaslik.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GBMusteriAra.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSatinAlma
            // 
            this.dgvSatinAlma.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgvSatinAlma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatinAlma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSatinAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatinAlma.Location = new System.Drawing.Point(258, 100);
            this.dgvSatinAlma.Name = "dgvSatinAlma";
            this.dgvSatinAlma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSatinAlma.Size = new System.Drawing.Size(415, 313);
            this.dgvSatinAlma.TabIndex = 3;
            // 
            // lblMıd
            // 
            this.lblMıd.AutoSize = true;
            this.lblMıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMıd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMıd.Location = new System.Drawing.Point(56, 29);
            this.lblMıd.Name = "lblMıd";
            this.lblMıd.Size = new System.Drawing.Size(90, 18);
            this.lblMıd.TabIndex = 5;
            this.lblMıd.Text = "Müşteri ID:";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBaslik.Location = new System.Drawing.Point(3, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(148, 24);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "BORÇ ÖDEME";
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.BackColor = System.Drawing.Color.Gold;
            this.pnlBaslik.Controls.Add(this.panel1);
            this.pnlBaslik.Controls.Add(this.lblBaslik);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(702, 65);
            this.pnlBaslik.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnCıkıs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 65);
            this.panel1.TabIndex = 2;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.FlatAppearance.BorderSize = 0;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCıkıs.Location = new System.Drawing.Point(673, 0);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(29, 30);
            this.btnCıkıs.TabIndex = 3;
            this.btnCıkıs.Text = "X";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "BORÇ ÖDEME";
            // 
            // textBMusId
            // 
            this.textBMusId.Location = new System.Drawing.Point(59, 61);
            this.textBMusId.Name = "textBMusId";
            this.textBMusId.Size = new System.Drawing.Size(100, 21);
            this.textBMusId.TabIndex = 6;
            // 
            // GBMusteriAra
            // 
            this.GBMusteriAra.Controls.Add(this.btnMgetir);
            this.GBMusteriAra.Controls.Add(this.lblMıd);
            this.GBMusteriAra.Controls.Add(this.textBMusId);
            this.GBMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBMusteriAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBMusteriAra.Location = new System.Drawing.Point(12, 71);
            this.GBMusteriAra.Name = "GBMusteriAra";
            this.GBMusteriAra.Size = new System.Drawing.Size(214, 144);
            this.GBMusteriAra.TabIndex = 7;
            this.GBMusteriAra.TabStop = false;
            this.GBMusteriAra.Text = "Müşteri Araması";
            // 
            // btnMgetir
            // 
            this.btnMgetir.BackColor = System.Drawing.Color.Gold;
            this.btnMgetir.FlatAppearance.BorderSize = 0;
            this.btnMgetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMgetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMgetir.ForeColor = System.Drawing.Color.White;
            this.btnMgetir.Location = new System.Drawing.Point(63, 100);
            this.btnMgetir.Name = "btnMgetir";
            this.btnMgetir.Size = new System.Drawing.Size(83, 29);
            this.btnMgetir.TabIndex = 7;
            this.btnMgetir.Text = "Getir";
            this.btnMgetir.UseVisualStyleBackColor = false;
            this.btnMgetir.Click += new System.EventHandler(this.btnMgetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOde);
            this.groupBox2.Controls.Add(this.lblOdTutar);
            this.groupBox2.Controls.Add(this.textBOdeMiktar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 144);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borç Ödemesi";
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.Color.Gold;
            this.btnOde.FlatAppearance.BorderSize = 0;
            this.btnOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.ForeColor = System.Drawing.Color.White;
            this.btnOde.Location = new System.Drawing.Point(50, 101);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(117, 38);
            this.btnOde.TabIndex = 7;
            this.btnOde.Text = "Ödeme Onay";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // lblOdTutar
            // 
            this.lblOdTutar.AutoSize = true;
            this.lblOdTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdTutar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOdTutar.Location = new System.Drawing.Point(49, 31);
            this.lblOdTutar.Name = "lblOdTutar";
            this.lblOdTutar.Size = new System.Drawing.Size(118, 18);
            this.lblOdTutar.TabIndex = 5;
            this.lblOdTutar.Text = "Ödeme Miktarı";
            // 
            // textBOdeMiktar
            // 
            this.textBOdeMiktar.Location = new System.Drawing.Point(52, 62);
            this.textBOdeMiktar.Name = "textBOdeMiktar";
            this.textBOdeMiktar.Size = new System.Drawing.Size(100, 21);
            this.textBOdeMiktar.TabIndex = 6;
            // 
            // lblTopBorc
            // 
            this.lblTopBorc.AutoSize = true;
            this.lblTopBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTopBorc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTopBorc.Location = new System.Drawing.Point(255, 431);
            this.lblTopBorc.Name = "lblTopBorc";
            this.lblTopBorc.Size = new System.Drawing.Size(110, 18);
            this.lblTopBorc.TabIndex = 9;
            this.lblTopBorc.Text = "Toplam Borç:";
            // 
            // lblSatinAlmalar
            // 
            this.lblSatinAlmalar.AutoSize = true;
            this.lblSatinAlmalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatinAlmalar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSatinAlmalar.Location = new System.Drawing.Point(409, 71);
            this.lblSatinAlmalar.Name = "lblSatinAlmalar";
            this.lblSatinAlmalar.Size = new System.Drawing.Size(107, 18);
            this.lblSatinAlmalar.TabIndex = 10;
            this.lblSatinAlmalar.Text = "Satın Almalar";
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKalanBorc.Location = new System.Drawing.Point(25, 431);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(96, 18);
            this.lblKalanBorc.TabIndex = 11;
            this.lblKalanBorc.Text = "Kalan Borç:";
            // 
            // MustBorcOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(702, 471);
            this.Controls.Add(this.lblKalanBorc);
            this.Controls.Add(this.lblSatinAlmalar);
            this.Controls.Add(this.lblTopBorc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBMusteriAra);
            this.Controls.Add(this.dgvSatinAlma);
            this.Controls.Add(this.pnlBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MustBorcOdeme";
            this.Text = "MustBorcOdeme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlma)).EndInit();
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GBMusteriAra.ResumeLayout(false);
            this.GBMusteriAra.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSatinAlma;
        private System.Windows.Forms.Label lblMıd;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.TextBox textBMusId;
        private System.Windows.Forms.GroupBox GBMusteriAra;
        private System.Windows.Forms.Button btnMgetir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label lblOdTutar;
        private System.Windows.Forms.TextBox textBOdeMiktar;
        private System.Windows.Forms.Label lblTopBorc;
        private System.Windows.Forms.Label lblSatinAlmalar;
        private System.Windows.Forms.Label lblKalanBorc;
    }
}