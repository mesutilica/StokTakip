using StokTakip.DAL;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Repository<T> where T : class, IEntity, new()//Repository<T> bu classa dışarıdan T tipinde class gelecek, where T : demek bu class a gelecek olan tipteki class için şart koymamızı sağlar, : class, buraya gelecek olan T nin referans tipli bir class olmasını şart koşar IEntity, buraya gelecek olan T nin Ientity olarak işaretlediğimiz classlardan biri olabileceğini şart koşar böylece projedeki diğer class lar buraya gönderilemez, new() ise buraya gönderilecek olan T nin new lenebilir bir class olmasını sağlar, böylece newlenebilir olmayan ama referans tipli olan örneğin string sınıflı bir eleman buraya gönderilemez.
    {
        private DatabaseContext context;// Veritabanı işlemleri yaptığımız nesneden örnek aldık.
        private DbSet<T> _objectSet;
        public Repository()//Class ımızın kurucu metodu
        {
            if (context == null)//Eğer veritabanı context imiz yoksa
            {
                context = new DatabaseContext();//veritabanı context ini oluştur
                _objectSet = context.Set<T>();//veritabanı işlemleri için gelen class ı context e ayarla
            }
        }
        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }
        public T Get(int id)
        {
            return _objectSet.Find(id);
        }
        public T Find(Expression<Func<T, bool>> expression)
        {
            return _objectSet.FirstOrDefault(expression);
        }
        public int Add(T entity)
        {
            _objectSet.Add(entity);
            return context.SaveChanges();
        }
        public int Update(T entity)
        {
            _objectSet.AddOrUpdate(entity);
            return context.SaveChanges();
        }
        public int Delete(int id)
        {
            _objectSet.Remove(this.Get(id));
            return context.SaveChanges();
        }
    }
}
