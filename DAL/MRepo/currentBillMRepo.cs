using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MRepo
{
    public class currentBillMRepo : IRepositoryM<currentBill, int>
    {
        BManEntities db;
        public currentBillMRepo(BManEntities db)
        {
            this.db = db;
        }
        public void Add(currentBill e)
        {
            db.currentBills.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.currentBills.FirstOrDefault(en => en.id == id);
            db.currentBills.Remove(e);
            db.SaveChanges();
        }

        public void Edit(currentBill e)
        {
            var d = db.currentBills.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<currentBill> Get()
        {
            return db.currentBills.ToList();
        }

        public currentBill Get(int id)
        {
            return db.currentBills.FirstOrDefault(en => en.id == id);
        }

        public void Search(int id)
        {
            throw new NotImplementedException();
        }
    }
}
