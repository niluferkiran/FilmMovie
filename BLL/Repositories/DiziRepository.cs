using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class DiziRepository : IRepository<Diziler>
    {
    FilmProjesiEntities fr = new FilmProjesiEntities();

        public void Insert(Diziler item)
        {
            fr.Diziler.Add(item);
            fr.SaveChanges();
        }

        public List<Diziler> GetAll()
        {
            return fr.Diziler.ToList();
        }

        public Diziler GetById(int id)
        {
            return fr.Diziler.Find(id);
        }

        public void Update(Diziler item)
        {
            Diziler guncellenecek = fr.Diziler.Find(item.DiziId);
            fr.Entry(guncellenecek).CurrentValues.SetValues(item);
            fr.SaveChanges();
        }

        public void Delete(int itemId)
        {
            Diziler silinecek = fr.Diziler.Find(itemId);
            fr.Filmler.Find(itemId).isDeleted = true;
            fr.SaveChanges();
        }
    }
}
