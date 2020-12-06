using StokTakip.DAL;
using StokTakip.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryDal
    {
        public List<Kategori> GetAll()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return context.Kategoriler.ToList();
            }
        }
    }
}
