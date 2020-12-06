using StokTakip.DAL;
using StokTakip.Entities;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KategoriManager
    {
        public List<Kategori> GetAll()
        {
            using (DatabaseContext context = new DatabaseContext())//bl katmanımızda veritabanı işlemleri yapabilmemiz için entity framework ü bu katmana eklememiz gerekli, bunu stoktakip.bl projemize sağ tıklayıp nuget dan yükleyebiliriz veya üzerine gelince çıkan ampül yardımıyla
            {
                return context.Kategoriler.ToList();
            }
        }
        public Kategori Get(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Kategoriler.FirstOrDefault(k => k.Id == id);//Veritabanı tablolarımızın tutulduğu DatabaseContext classımızdan context isminde bir nesne oluşturduk, context.Kategoriler.FirstOrDefault kodu ile context nesnesi içindeki kategoriler tablosundaki kategorilerden (k => k.Id == id); şartı ile id si parametreden gelen id ile eşleşen kaydı bize geri döndürür. (k => k.Id == id) kodundaki k => kodu kategori sınıfını temsil etmeye başlar, sonrasındaki k.Id artık kategori nesnesinin ıd sidir ve kategori nesnesinin tüm özelliklerine k. yazarak erişebiliriz
            }
        }
        public int Add(Kategori kategori)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Kategoriler.Add(kategori);
                return context.SaveChanges();
            }
        }

        public int Update(Kategori kategori)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Kategoriler.AddOrUpdate(kategori);
                return context.SaveChanges();
            }
        }

        public int Delete(Kategori kategori)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var entity = context.Entry(kategori);
                entity.State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }
    }
}
