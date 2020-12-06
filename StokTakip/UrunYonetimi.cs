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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        UrunManager urunManager = new UrunManager();
        KategoriManager kategoriManager = new KategoriManager();
        MarkaManager markaManager = new MarkaManager();
        public static int UrunId = 0;

        void DatalariYukle()
        {
            dgvUrunler.DataSource = urunManager.GetAll();
            cbUrunKategorisi.DataSource = kategoriManager.GetAll();
            cbUrunKategorisi.DisplayMember = "KategoriAdi";
            cbUrunKategorisi.ValueMember = "Id";
            cbUrunMarkasi.DataSource = markaManager.GetAll();
            cbUrunMarkasi.DisplayMember = "MarkaAdi";
            cbUrunMarkasi.ValueMember = "Id";
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

        private void kullaniciYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.Show();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            DatalariYukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                urunManager.Add(
                    new Urun
                    {
                        UrunAdi = txtUrunAdi.Text,
                        UrunAciklamasi = rtbUrunAciklamasi.Text,
                        StokMiktari = int.Parse(txtStokMiktari.Text),
                        UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                        Aktif = chbAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString()),
                        MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString()),
                        Kdv = int.Parse(txtKdv.Text)
                    }
                    );
                DatalariYukle();
                MessageBox.Show("Ürün Eklendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunId > 0)
                {
                    Urun urun = new Urun();
                    urun.Id = UrunId;
                    urun.UrunAdi = txtUrunAdi.Text;
                    urun.UrunAciklamasi = rtbUrunAciklamasi.Text;
                    urun.StokMiktari = int.Parse(txtStokMiktari.Text);
                    urun.UrunFiyati = decimal.Parse(txtUrunFiyati.Text);
                    urun.Aktif = chbAktif.Checked;
                    urun.EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text);
                    urun.KategoriId = int.Parse(cbUrunKategorisi.SelectedValue.ToString());
                    urun.MarkaId = int.Parse(cbUrunMarkasi.SelectedValue.ToString());
                    urun.Kdv = int.Parse(txtKdv.Text);

                    urunManager.Update(urun);
                    DatalariYukle();                    
                    MessageBox.Show("Kayıt Güncellendi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunId = int.Parse(dgvUrunler.CurrentRow.Cells[0].Value.ToString());
            var urun = urunManager.Get(UrunId);
            if (urun != null)
            {
                txtUrunAdi.Text = urun.UrunAdi;
                txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                txtKdv.Text = urun.Kdv.ToString();
                txtStokMiktari.Text = urun.StokMiktari.ToString();
                rtbUrunAciklamasi.Text = urun.UrunAciklamasi;
                chbAktif.Checked = urun.Aktif;
                lblEklenmeTarihi.Text = urun.EklenmeTarihi.ToString();
                cbUrunKategorisi.SelectedItem = urun.KategoriId.ToString();
                //MessageBox.Show(cbUrunKategorisi.SelectedValue.ToString());
                cbUrunMarkasi.SelectedItem = urun.MarkaId.ToString();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunId > 0)
                {
                    var islemSonucu = urunManager.Delete(UrunId);
                    if (islemSonucu > 0)
                    {
                        DatalariYukle();
                        MessageBox.Show("Kayıt Silindi!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        public void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
