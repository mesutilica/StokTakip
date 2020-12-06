using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public string Email { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Aktif { get; set; }
    }
}
