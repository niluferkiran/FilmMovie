using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class KategoriRepository : IRepository<Kategoriler>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();

        public void Insert(Kategoriler item)
        {
            fr.Kategoriler.Add(item);
            fr.SaveChanges();
        }

        public List<Kategoriler>GetAll()
        {
            return fr.Kategoriler.ToList();
        }

        public Kategoriler GetById(int id)
        {
            return fr.Kategoriler.Find(id);
        }

        public void Update(Kategoriler item)
        {
            Kategoriler guncellenecek = fr.Kategoriler.Find(item.KategoriId); 
            fr.Entry(guncellenecek).CurrentValues.SetValues(item); 
            fr.SaveChanges();
        }

        public void Delete(int itemId)
        {
            
        }
    }
}
