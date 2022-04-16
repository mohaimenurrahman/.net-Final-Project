using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MRepo
{
    public class buildingMRepo : IRepositoryM<building, int>
    {
        BManEntities db;
        public buildingMRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(building e)
        {
            db.buildings.Add(e);
            db.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var e = db.buildings.FirstOrDefault(en => en.id == id);
            db.buildings.Remove(e);
            db.SaveChanges();
                   
        }

        public void Edit(building e)
        {
            var d = db.buildings.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<building> Get()
        {
            return db.buildings.ToList();
        }

        public building Get(int id)
        {
            return db.buildings.FirstOrDefault(en => en.id == id);

        }

        public void Search(int id)
        {
            throw new NotImplementedException();
        }
    }
}
