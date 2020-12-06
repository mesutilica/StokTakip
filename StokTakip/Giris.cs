using BL;
using System;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        KullaniciManager kullaniciManager = new KullaniciManager();
        GirisManager girisManager = new GirisManager();

        private void btnGiris_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) && !string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                var kullanici = kullaniciManager.Get(txtKullaniciAdi.Text, txtSifre.Text);
                if (kullanici != null)
                {
                    this.Hide();
                    UrunYonetimi urunYonetimi = new UrunYonetimi();
                    urunYonetimi.Show();
                }
                else MessageBox.Show("Kullanıcı Bulunamadı!");
            }
            else MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!");
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kullanici = girisManager.Find(k => k.KullaniciAdi == txtKullaniciAdi.Text && k.KullaniciSifre == txtSifre.Text);
            if (kullanici != null)
            {
                this.Hide();
                UrunYonetimi urunYonetimi = new UrunYonetimi();
                urunYonetimi.Show();
            }
            else MessageBox.Show("Kullanıcı Bulunamadı!");
        }
    }
}
