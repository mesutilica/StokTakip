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
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriManager kategoriManager = new KategoriManager();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = kategoriManager.Add(
                    new Kategori
                    {
                        Aktif = chbKategoriDurum.Checked,
                        EklenmeTarihi = DateTime.Now,
                        KategoriAdi = txtKategoriAdi.Text,
                        KategoriAciklamasi = txtKategoriAciklama.Text
                    });
                dgvKategoriler.DataSource = kategoriManager.GetAll();
                if (sonuc > 0) MessageBox.Show("Kayıt Başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Eklenirken Hata Oluştu!\nLütfen Tüm Alanları Doldurunuz!");
            }
        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = kategoriManager.GetAll();
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvKategoriler.CurrentRow.Cells[0].Value.ToString();
            try
            {
                var kategori = kategoriManager.Get(int.Parse(lblId.Text));
                if (kategori != null)//veritabanından çekilen kategori boş değilse
                {
                    txtKategoriAdi.Text = kategori.KategoriAdi;
                    txtKategoriAciklama.Text = kategori.KategoriAciklamasi;
                    chbKategoriDurum.Checked = kategori.Aktif;
                    lblEklenmeTarihiDeger.Text = kategori.EklenmeTarihi.ToString();
                    this.FindForm().AcceptButton = btnGuncelle;//Güncelleme işlemi için bir kayıt seçildiğinde textbox larda işlem yaptıktan sonra enter a basınca btnguncelle butonunu çalıştırmayı sağlıyor
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

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

        private void kullaniciYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.Show();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kategoriManager.Update(
                    new Kategori
                    {
                        Id = int.Parse(lblId.Text),
                        EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihiDeger.Text),
                        Aktif = chbKategoriDurum.Checked,
                        KategoriAdi = txtKategoriAdi.Text,
                        KategoriAciklamasi = txtKategoriAciklama.Text
                    }
                    );
                dgvKategoriler.DataSource = kategoriManager.GetAll();
                MessageBox.Show("Kayıt Güncellendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblId.Text))
                {
                    kategoriManager.Delete(
                        new Kategori
                        {
                            Id = Convert.ToInt32(lblId.Text)
                        }
                        );
                    dgvKategoriler.DataSource = kategoriManager.GetAll();
                    MessageBox.Show("Kayıt Silindi!");
                }
                else MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
