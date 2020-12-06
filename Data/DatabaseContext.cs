using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//veritabanında oluşan tablolara eklenen s takısını kaldırmak için bu kodu yazmalıyız
            base.OnModelCreating(modelBuilder);
        }
        
        public DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());            
        }

        public class DatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                if (context.Kullanicilar.FirstOrDefault() == null)
                {
                    context.Kullanicilar.Add(new Kullanici()
                    {
                        Adi = "Mesut",
                        Soyadi = "Ilıca",
                        Aktif = true,
                        Email = "mesut@posta.la",
                        KullaniciAdi = "admin",
                        KullaniciSifre = "123456"
                    });
                    context.SaveChanges();
                }
                base.Seed(context);
            }
        }/**/
    }
}
