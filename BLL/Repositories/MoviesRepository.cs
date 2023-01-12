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
    public class MoviesRepository : IGenericRepository<Diziler>
    {
        FilmProjesiEntities db = new FilmProjesiEntities();
        public void Delete(object id)
        {
            try
            {
                db.Diziler.Remove(GetById(id));
            }
            catch
            {

                throw new NotImplementedException();
            }
        }

        public IEnumerable<Diziler> GetAll()
        {
            return db.Diziler.ToList();
        }

        public Diziler GetById(object id)
        {
            Diziler _dizi = db.Diziler.Find(id);
            return _dizi;
        }

        public void Insert(Diziler obj)
        {
            db.Diziler.Add(obj);
            db.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Diziler obj)
        {
            throw new NotImplementedException();
        }
        public List<Diziler> GetMyList(int KullaniciId)
        {
            var query = from d in db.Diziler
                        from kdd in db.KullaniciDiziDetay
                        orderby kdd.DiziId descending
                        where d.DiziId == kdd.DiziId && kdd.KullaniciId == KullaniciId
                        select d;
            return query.ToList();

        }
        public List<Diziler> GetLastWatchList(int KullaniciId)
        {
            var query = (from d in db.Diziler
                        from kdd in db.KullaniciDiziDetay
                        orderby kdd.DiziId descending
                        where d.DiziId == kdd.DiziId && kdd.KullaniciId == KullaniciId
                        select d).Take(5);
            return query.ToList();

        }
    }
}
