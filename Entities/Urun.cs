using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Urun : IEntity
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public int MarkaId { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int Kdv { get; set; }
        public int StokMiktari { get; set; }
        public bool Aktif { get; set; }
    }
}
