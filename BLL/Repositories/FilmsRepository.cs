// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL.Abstract;

using DAL;

namespace BLL.Repositories
{
    public class FilmsRepository : IGenericRepository<Filmler>
    {
        FilmProjesiEntities db = new FilmProjesiEntities();
        public void Delete(object id)
        {
            try
            {
                db.Filmler.Remove(GetById(id));
            }
            catch
            {

                throw new NotImplementedException();
            }
        }

        public IEnumerable<Filmler> GetAll()
        {
            return db.Filmler.ToList();
        }

        public Filmler GetById(object id)
        {
            Filmler _film = db.Filmler.Find(id);
            return _film;
        }

        public void Insert(Filmler obj)
        {
            db.Filmler.Add(obj);
            db.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Filmler obj)
        {

            db.Entry(obj).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }
        public List<Filmler> GetMyList(int KullaniciId)
        {
            var query = from f in db.Filmler
                        from kfd in db.KullaniciFilmDetay
                        orderby kfd.FilmId descending
                        where f.FilmId == kfd.FilmId && kfd.KullaniciId == KullaniciId
                        select f;
            return query.ToList();

        }
        public List<Filmler> GetLastWatchList(int KullaniciId)
        {
            var query = (from f in db.Filmler
                        from kfd in db.KullaniciFilmDetay
                        orderby kfd.FilmId descending
                        where f.FilmId == kfd.FilmId && kfd.KullaniciId == KullaniciId
                        select f).Take(5); ;
            return query.ToList();

        }
    }
}
