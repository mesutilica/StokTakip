using StokTakip.DAL;
using StokTakip.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BL
{
    public class UrunManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<Urun> GetAll()
        {
            return context.Urunler.ToList();
        }
        public Urun Get(int id)
        {
            return context.Urunler.Find(id);
        }
        public int Add(Urun Urun)
        {
            context.Urunler.Add(Urun);
            return context.SaveChanges();
        }
        public int Update(Urun urun)
        {
            context.Urunler.AddOrUpdate(urun);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            context.Urunler.Remove(this.Get(id));
            return context.SaveChanges();
        }
    }
}
