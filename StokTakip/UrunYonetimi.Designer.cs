namespace StokTakip
{
    partial class UrunYonetimi
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAktif = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbUrunMarkasi = new System.Windows.Forms.ComboBox();
            this.cbUrunKategorisi = new System.Windows.Forms.ComboBox();
            this.rtbUrunAciklamasi = new System.Windows.Forms.RichTextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 27);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.Size = new System.Drawing.Size(776, 176);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEklenmeTarihi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chbAktif);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cbUrunMarkasi);
            this.groupBox1.Controls.Add(this.cbUrunKategorisi);
            this.groupBox1.Controls.Add(this.rtbUrunAciklamasi);
            this.groupBox1.Controls.Add(this.txtStokMiktari);
            this.groupBox1.Controls.Add(this.txtKdv);
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(97, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Yönetimi";
            // 
            // chbAktif
            // 
            this.chbAktif.AutoSize = true;
            this.chbAktif.Checked = true;
            this.chbAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktif.Location = new System.Drawing.Point(292, 140);
            this.chbAktif.Name = "chbAktif";
            this.chbAktif.Size = new System.Drawing.Size(47, 17);
            this.chbAktif.TabIndex = 16;
            this.chbAktif.Text = "Aktif";
            this.chbAktif.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(298, 202);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(217, 202);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(136, 202);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbUrunMarkasi
            // 
            this.cbUrunMarkasi.FormattingEnabled = true;
            this.cbUrunMarkasi.Location = new System.Drawing.Point(136, 67);
            this.cbUrunMarkasi.Name = "cbUrunMarkasi";
            this.cbUrunMarkasi.Size = new System.Drawing.Size(121, 21);
            this.cbUrunMarkasi.TabIndex = 12;
            // 
            // cbUrunKategorisi
            // 
            this.cbUrunKategorisi.FormattingEnabled = true;
            this.cbUrunKategorisi.Location = new System.Drawing.Point(136, 25);
            this.cbUrunKategorisi.Name = "cbUrunKategorisi";
            this.cbUrunKategorisi.Size = new System.Drawing.Size(121, 21);
            this.cbUrunKategorisi.TabIndex = 11;
            // 
            // rtbUrunAciklamasi
            // 
            this.rtbUrunAciklamasi.Location = new System.Drawing.Point(136, 138);
            this.rtbUrunAciklamasi.Name = "rtbUrunAciklamasi";
            this.rtbUrunAciklamasi.Size = new System.Drawing.Size(121, 62);
            this.rtbUrunAciklamasi.TabIndex = 10;
            this.rtbUrunAciklamasi.Text = "";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(383, 105);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtStokMiktari.TabIndex = 9;
            // 
            // txtKdv
            // 
            this.txtKdv.Location = new System.Drawing.Point(383, 67);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(100, 20);
            this.txtKdv.TabIndex = 9;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(383, 30);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyati.TabIndex = 8;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(136, 105);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(121, 20);
            this.txtUrunAdi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stok Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kdv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Açıklaması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Markası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kategorisi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYonetimiToolStripMenuItem,
            this.markaYonetimiToolStripMenuItem,
            this.urunYonetimiToolStripMenuItem,
            this.kullaniciYonetimiToolStripMenuItem,
            this.cikisToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYonetimiToolStripMenuItem
            // 
            this.kategoriYonetimiToolStripMenuItem.Name = "kategoriYonetimiToolStripMenuItem";
            this.kategoriYonetimiToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.kategoriYonetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            this.kategoriYonetimiToolStripMenuItem.Click += new System.EventHandler(this.kategoriYonetimiToolStripMenuItem_Click);
            // 
            // markaYonetimiToolStripMenuItem
            // 
            this.markaYonetimiToolStripMenuItem.Name = "markaYonetimiToolStripMenuItem";
            this.markaYonetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.markaYonetimiToolStripMenuItem.Text = "Marka Yönetimi";
            this.markaYonetimiToolStripMenuItem.Click += new System.EventHandler(this.markaYonetimiToolStripMenuItem_Click);
            // 
            // urunYonetimiToolStripMenuItem
            // 
            this.urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            this.urunYonetimiToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.urunYonetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // kullaniciYonetimiToolStripMenuItem
            // 
            this.kullaniciYonetimiToolStripMenuItem.Name = "kullaniciYonetimiToolStripMenuItem";
            this.kullaniciYonetimiToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.kullaniciYonetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            this.kullaniciYonetimiToolStripMenuItem.Click += new System.EventHandler(this.kullaniciYonetimiToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem1.Text = "Çıkış";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Eklenme Tarihi";
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(380, 173);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(0, 13);
            this.lblEklenmeTarihi.TabIndex = 18;
            // 
            // UrunYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UrunYonetimi";
            this.Text = "Ürün Yönetimi";
            this.Load += new System.EventHandler(this.UrunYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbUrunMarkasi;
        private System.Windows.Forms.ComboBox cbUrunKategorisi;
        private System.Windows.Forms.RichTextBox rtbUrunAciklamasi;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox chbAktif;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.Windows.Forms.Label label8;
    }
}