using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class YonetimRepository : IRepository<Kullanicilar>
    {
        FilmProjesiEntities fr = new FilmProjesiEntities();
        public void Insert(Kullanicilar item)
        {
            fr.Kullanicilar.Add(item);
            fr.SaveChanges();
        }

        public List<Kullanicilar> GetAll()
        {
            return fr.Kullanicilar.ToList();
        }

        public Kullanicilar GetById(int id)
        {
            return fr.Kullanicilar.Find(id);
        }

        public void Update(Kullanicilar item)
        {
            Kullanicilar guncellenecek = fr.Kullanicilar.Find(item.KullaniciId); //güncellenecek FilmId'yi buluyorum.
            fr.Entry(guncellenecek).CurrentValues.SetValues(item); // entry ile gelenlerin current valuelarını güncelliyorum
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
