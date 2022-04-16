using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MRepo
{
    public class wasaMRepo : IRepositoryM<wasaBill, int>
    {
        BManEntities db;
        public wasaMRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(wasaBill e)
        {
            db.wasaBills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.wasaBills.FirstOrDefault(en => en.id == id);
            db.wasaBills.Remove(e);
            db.SaveChanges();
        }

        public void Edit(wasaBill e)
        {
            var d = db.wasaBills.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<wasaBill> Get()
        {
            return db.wasaBills.ToList();

        }

        public wasaBill Get(int id)
        {
            return db.wasaBills.FirstOrDefault(en => en.id == id);

        }

        public void Search(int id)
        {
            throw new NotImplementedException();
        }
    }
}
