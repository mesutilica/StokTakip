namespace Data.Migrations
{
    using StokTakip.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StokTakip.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StokTakip.DAL.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Kullanici kullanici = new Kullanici()
            {
                Adi = "Mesut",
                Soyadi = "Ilıca",
                Aktif = true,
                Email = "mesut@posta.la",
                KullaniciAdi = "admin",
                KullaniciSifre = "123456"
            };
            if (context.Kullanicilar.FirstOrDefault() == null)
            {
                context.Kullanicilar.Add(kullanici);
                context.SaveChanges();
            }
            
            base.Seed(context);
        }
    }
}
