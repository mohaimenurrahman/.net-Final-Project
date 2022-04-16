using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MRepo
{
    public class flatMRepo : IRepositoryM<flat, int>
    {
        BManEntities db;
        public flatMRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(flat e)
        {
            db.flats.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.flats.FirstOrDefault(en => en.id == id);
            db.flats.Remove(e);
            db.SaveChanges();
        }

        public void Edit(flat e)
        {
            var d = db.flats.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<flat> Get()
        {
            return db.flats.ToList();
        }

        public flat Get(int id)
        {
            return db.flats.FirstOrDefault(en => en.id == id);
        }

        public void Search(int id)
        {
            throw new NotImplementedException();
        }
    }

}