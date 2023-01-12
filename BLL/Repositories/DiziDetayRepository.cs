using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class DiziDetayRepository: IRepository<DiziDetay>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();

        public void Insert(DiziDetay item)
        {
            fr.DiziDetay.Add(item);
            fr.SaveChanges();
        }

        public List<DiziDetay> GetAll()
        {
            return fr.DiziDetay.ToList();
        }

        public DiziDetay GetById(int id)
        {
            return fr.DiziDetay.Find(id);
        }

        public void Update(DiziDetay item)
        {
            DiziDetay guncellenecek = fr.DiziDetay.Find(item.DiziDetayId);
            fr.Entry(guncellenecek).CurrentValues.SetValues(item);
            fr.SaveChanges();
        }

        public void Delete(int itemId)
        {
            DiziDetay silinecek = fr.DiziDetay.Find(itemId);
            fr.Filmler.Find(itemId).isDeleted = true;
            fr.SaveChanges();
        }
    }
}
