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
    public partial class MarkaYonetimi : Form
    {
        public MarkaYonetimi()
        {
            InitializeComponent();
        }

        MarkaManager markaManager = new MarkaManager();
        public static int markaId = 0;

        private void kategoriYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.Show();
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

        private void markaYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.Show();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int islemSonucu = markaManager.Add(
                     new Marka
                     {
                         Aktif = chbAktif.Checked,
                         EklenmeTarihi = DateTime.Now,
                         MarkaAciklamasi = txtMarkaAciklamasi.Text,
                         MarkaAdi = txtMarkaAdi.Text
                     }
                     );
                if (islemSonucu > 0)
                {
                    dgvMarkalar.DataSource = markaManager.GetAll();
                    MessageBox.Show("Marka Eklendi!");
                }
                else MessageBox.Show("Marka Eklenemedi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            dgvMarkalar.DataSource = markaManager.GetAll();
        }

        private void dgvMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                markaId = int.Parse(dgvMarkalar.CurrentRow.Cells[0].Value.ToString());
                var marka = markaManager.Get(markaId);
                if (marka != null)
                {
                    txtMarkaAdi.Text = marka.MarkaAdi;
                    txtMarkaAciklamasi.Text = marka.MarkaAciklamasi;
                    markaId = marka.Id;
                    lblEklenmeTarihi.Text = marka.EklenmeTarihi.ToString();
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    this.FindForm().AcceptButton = btnGuncelle;
                }
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
                markaManager.Update(
                    new Marka
                    {
                        Id = markaId,
                        Aktif = chbAktif.Checked,
                        EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text),
                        MarkaAciklamasi = txtMarkaAciklamasi.Text,
                        MarkaAdi = txtMarkaAdi.Text
                    }
                    );
                dgvMarkalar.DataSource = markaManager.GetAll();
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
                if (markaId > 0)
                {
                    markaManager.Delete(markaId);
                    btnSil.Enabled = false;
                    btnGuncelle.Enabled = false;
                    dgvMarkalar.DataSource = markaManager.GetAll();
                }
                else MessageBox.Show("Silinecek Kayıt Seçiniz!");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
