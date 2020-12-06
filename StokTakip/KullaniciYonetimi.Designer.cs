namespace StokTakip
{
    partial class KullaniciYonetimi
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAktif = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 27);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.Size = new System.Drawing.Size(776, 180);
            this.dgvKullanicilar.TabIndex = 0;
            this.dgvKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKullanicilar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.chbAktif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(212, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Yönetimi";
            // 
            // chbAktif
            // 
            this.chbAktif.AutoSize = true;
            this.chbAktif.Location = new System.Drawing.Point(151, 158);
            this.chbAktif.Name = "chbAktif";
            this.chbAktif.Size = new System.Drawing.Size(15, 14);
            this.chbAktif.TabIndex = 10;
            this.chbAktif.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aktif/Pasif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(151, 132);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(151, 106);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(151, 54);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(71, 196);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(151, 28);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
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
            this.urunYonetimiToolStripMenuItem.Click += new System.EventHandler(this.urunYonetimiToolStripMenuItem_Click);
            // 
            // kullaniciYonetimiToolStripMenuItem
            // 
            this.kullaniciYonetimiToolStripMenuItem.Name = "kullaniciYonetimiToolStripMenuItem";
            this.kullaniciYonetimiToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.kullaniciYonetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem1.Text = "Çıkış";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(152, 196);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(233, 196);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // KullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "KullaniciYonetimi";
            this.Text = "Kullanıcı Yönetimi";
            this.Load += new System.EventHandler(this.KullaniciYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.CheckBox chbAktif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}