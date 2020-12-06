using StokTakip.DAL;
using StokTakip.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BL
{
    public class KullaniciManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<Kullanici> GetAll()
        {
            return context.Kullanicilar.ToList();
        }
        public Kullanici Get(int id)
        {
            return context.Kullanicilar.Find(id);
        }
        public Kullanici Get(string kullaniciAdi, string sifre)
        {
            return context.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.KullaniciSifre == sifre);
        }
        public int Add(Kullanici Kullanici)
        {
            context.Kullanicilar.Add(Kullanici);
            return context.SaveChanges();
        }
        public int Update(Kullanici Kullanici)
        {
            context.Kullanicilar.AddOrUpdate(Kullanici);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            context.Kullanicilar.Remove(this.Get(id));
            return context.SaveChanges();
        }
    }
}
