using BL;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class KullaniciYonetimi : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        public static int kullaniciId = 0;

        public KullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void kategoriYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.Show();
        }

        private void markaYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.Show();
        }

        private void urunYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.Show();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    kullaniciManager.Add(
                        new Kullanici
                        {
                            Adi = txtAdi.Text,
                            Aktif = chbAktif.Checked,
                            Email = txtEmail.Text,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            KullaniciSifre = txtSifre.Text,
                            Soyadi = txtSoyadi.Text
                        }
                        );
                    dgvKullanicilar.DataSource = kullaniciManager.GetAll();
                    MessageBox.Show("Kayıt Eklendi!");
                }
                else MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = kullaniciManager.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (kullaniciId > 0)
                {
                    kullaniciManager.Update(
                        new Kullanici
                        {
                            Id = kullaniciId,
                            Adi = txtAdi.Text,
                            Aktif = chbAktif.Checked,
                            Email = txtEmail.Text,
                            KullaniciAdi = txtKullaniciAdi.Text,
                            KullaniciSifre = txtSifre.Text,
                            Soyadi = txtSoyadi.Text
                        }
                        );
                    dgvKullanicilar.DataSource = kullaniciManager.GetAll();
                    MessageBox.Show("Kayıt Güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKullanicilar.Rows.Count > 0)
            {
                kullaniciId = int.Parse(dgvKullanicilar.CurrentRow.Cells[0].Value.ToString());
                if (kullaniciId > 0)
                {
                    var kullanici = kullaniciManager.Get(kullaniciId);
                    if (kullanici != null)
                    {
                        txtAdi.Text = kullanici.Adi;
                        txtEmail.Text = kullanici.Email;
                        txtKullaniciAdi.Text = kullanici.KullaniciAdi;
                        txtSifre.Text = kullanici.KullaniciSifre;
                        txtSoyadi.Text = kullanici.Soyadi;
                        chbAktif.Checked = kullanici.Aktif;
                    }
                }
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.Rows.Count > 0)
            {
                if (kullaniciId > 0)
                {
                    if(kullaniciManager.Delete(kullaniciId) > 0)
                    {
                        dgvKullanicilar.DataSource = kullaniciManager.GetAll();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
            }
        }
    }
}
