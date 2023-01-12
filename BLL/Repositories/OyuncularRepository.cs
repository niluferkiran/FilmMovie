using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class OyuncularRepository: IRepository<Oyuncular>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();

        public void Insert(Oyuncular item)
        {
            fr.Oyuncular.Add(item);
            fr.SaveChanges();
        }

        public List<Oyuncular> GetAll()
        {
            return fr.Oyuncular.ToList();
        }

        public Oyuncular GetById(int id)
        {
            return fr.Oyuncular.Find(id);
        }

        public void Update(Oyuncular item)
        {
            Oyuncular guncellenecek = fr.Oyuncular.Find(item.OyuncuId);
            fr.Entry(guncellenecek).CurrentValues.SetValues(item);
            fr.SaveChanges();
        }

        public void Delete(int itemId)
        {
            Oyuncular silinecek = fr.Oyuncular.Find(itemId);
            fr.Filmler.Find(itemId).isDeleted = true;
            fr.SaveChanges();
        }
    }
}
