using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmRepository : IRepository<Filmler>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();

        public List<Filmler> GetAll()
        {
            return fr.Filmler.ToList();
        }
        public Filmler GetById(int id)
        {
            return fr.Filmler.Find(id);
        }
        public void Insert(Filmler item)
        {
            fr.Filmler.Add(item);
            fr.SaveChanges();
        }
        public void Update(Filmler item)
        {
            Filmler guncellenecek = fr.Filmler.Find(item.FilmId); 
            fr.Entry(guncellenecek).CurrentValues.SetValues(item); 
            fr.SaveChanges();
        }
        public void Delete(int itemId)
        {
            Filmler silinecek = fr.Filmler.Find(itemId);
            fr.Filmler.Find(itemId).isDeleted = true;
            fr.SaveChanges();
        }
               
    }
}
