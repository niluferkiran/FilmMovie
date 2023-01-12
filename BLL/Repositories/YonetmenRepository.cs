using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class YonetmenRepository:IRepository<Yonetmenler>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();

        public void Insert(Yonetmenler item)
        {
            fr.Yonetmenler.Add(item);
            fr.SaveChanges();
        }

        public List<Yonetmenler> GetAll()
        {
            return fr.Yonetmenler.ToList();
        }

        public Yonetmenler GetById(int id)
        {
            return fr.Yonetmenler.Find(id);
        }

        public void Update(Yonetmenler item)
        {
            Yonetmenler guncellenecek = fr.Yonetmenler.Find(item.YonetmenId);
            fr.Entry(guncellenecek).CurrentValues.SetValues(item);
            fr.SaveChanges();
        }

        public void Delete(int itemId)
        {
            Yonetmenler silinecek = fr.Yonetmenler.Find(itemId);
            fr.Filmler.Find(itemId).isDeleted = true;
            fr.SaveChanges();
        }
    }
}
