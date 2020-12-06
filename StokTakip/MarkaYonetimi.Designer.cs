namespace StokTakip
{
    partial class MarkaYonetimi
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
            this.dgvMarkalar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.chbAktif = new System.Windows.Forms.CheckBox();
            this.txtMarkaAciklamasi = new System.Windows.Forms.TextBox();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarkalar
            // 
            this.dgvMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkalar.Location = new System.Drawing.Point(12, 27);
            this.dgvMarkalar.Name = "dgvMarkalar";
            this.dgvMarkalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarkalar.Size = new System.Drawing.Size(776, 167);
            this.dgvMarkalar.TabIndex = 0;
            this.dgvMarkalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkalar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.lblEklenmeTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.chbAktif);
            this.groupBox1.Controls.Add(this.txtMarkaAciklamasi);
            this.groupBox1.Controls.Add(this.txtMarkaAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(226, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka Yönetimi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(42, 209);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // chbAktif
            // 
            this.chbAktif.AutoSize = true;
            this.chbAktif.Checked = true;
            this.chbAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktif.Location = new System.Drawing.Point(148, 149);
            this.chbAktif.Name = "chbAktif";
            this.chbAktif.Size = new System.Drawing.Size(75, 17);
            this.chbAktif.TabIndex = 4;
            this.chbAktif.Text = "Aktif/Pasif";
            this.chbAktif.UseVisualStyleBackColor = true;
            // 
            // txtMarkaAciklamasi
            // 
            this.txtMarkaAciklamasi.Location = new System.Drawing.Point(148, 81);
            this.txtMarkaAciklamasi.Multiline = true;
            this.txtMarkaAciklamasi.Name = "txtMarkaAciklamasi";
            this.txtMarkaAciklamasi.Size = new System.Drawing.Size(100, 53);
            this.txtMarkaAciklamasi.TabIndex = 3;
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(148, 44);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka Açıklaması";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
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
            this.kullaniciYonetimiToolStripMenuItem.Click += new System.EventHandler(this.kullaniciYonetimiToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem1.Text = "Çıkış";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(145, 183);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(10, 13);
            this.lblEklenmeTarihi.TabIndex = 6;
            this.lblEklenmeTarihi.Text = ":";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(123, 209);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(204, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MarkaYonetimi
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMarkalar);
            this.Name = "MarkaYonetimi";
            this.Text = "Marka Yönetimi";
            this.Load += new System.EventHandler(this.MarkaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkalar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarkalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMarkaAciklamasi;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbAktif;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}