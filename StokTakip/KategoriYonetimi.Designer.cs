namespace StokTakip
{
    partial class KategoriYonetimi
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
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEklenmeTarihiDeger = new System.Windows.Forms.Label();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.chbKategoriDurum = new System.Windows.Forms.CheckBox();
            this.txtKategoriAciklama = new System.Windows.Forms.TextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(12, 27);
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.Size = new System.Drawing.Size(776, 198);
            this.dgvKategoriler.TabIndex = 0;
            this.dgvKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEklenmeTarihiDeger);
            this.groupBox1.Controls.Add(this.lblEklenmeTarihi);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chbKategoriDurum);
            this.groupBox1.Controls.Add(this.txtKategoriAciklama);
            this.groupBox1.Controls.Add(this.txtKategoriAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(208, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Yönetimi";
            // 
            // lblEklenmeTarihiDeger
            // 
            this.lblEklenmeTarihiDeger.AutoSize = true;
            this.lblEklenmeTarihiDeger.Location = new System.Drawing.Point(161, 135);
            this.lblEklenmeTarihiDeger.Name = "lblEklenmeTarihiDeger";
            this.lblEklenmeTarihiDeger.Size = new System.Drawing.Size(0, 13);
            this.lblEklenmeTarihiDeger.TabIndex = 11;
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(38, 135);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(77, 13);
            this.lblEklenmeTarihi.TabIndex = 10;
            this.lblEklenmeTarihi.Text = "Eklenme Tarihi";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(37, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(205, 158);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(121, 158);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(40, 158);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chbKategoriDurum
            // 
            this.chbKategoriDurum.AutoSize = true;
            this.chbKategoriDurum.Checked = true;
            this.chbKategoriDurum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbKategoriDurum.Location = new System.Drawing.Point(164, 110);
            this.chbKategoriDurum.Name = "chbKategoriDurum";
            this.chbKategoriDurum.Size = new System.Drawing.Size(75, 17);
            this.chbKategoriDurum.TabIndex = 5;
            this.chbKategoriDurum.Text = "Aktif/Pasif";
            this.chbKategoriDurum.UseVisualStyleBackColor = true;
            // 
            // txtKategoriAciklama
            // 
            this.txtKategoriAciklama.Location = new System.Drawing.Point(164, 60);
            this.txtKategoriAciklama.Multiline = true;
            this.txtKategoriAciklama.Name = "txtKategoriAciklama";
            this.txtKategoriAciklama.Size = new System.Drawing.Size(100, 38);
            this.txtKategoriAciklama.TabIndex = 4;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(164, 31);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKategoriAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYonetimiToolStripMenuItem
            // 
            this.kategoriYonetimiToolStripMenuItem.Name = "kategoriYonetimiToolStripMenuItem";
            this.kategoriYonetimiToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.kategoriYonetimiToolStripMenuItem.Text = "Kategori Yönetimi";
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
            this.urunYonetimiToolStripMenuItem.Click += new System.EventHandler(this.urunYonetimiToolStripMenuItem_Click);
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
            // KategoriYonetimi
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKategoriler);
            this.Name = "KategoriYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Yönetimi";
            this.Load += new System.EventHandler(this.KategoriYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chbKategoriDurum;
        private System.Windows.Forms.TextBox txtKategoriAciklama;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.Label lblEklenmeTarihiDeger;
        private System.Windows.Forms.Label lblEklenmeTarihi;
    }
}