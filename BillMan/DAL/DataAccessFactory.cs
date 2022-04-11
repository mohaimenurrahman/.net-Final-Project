using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static BManEntities db;
        static DataAccessFactory()
        {
            db = new BManEntities();
        }
        public static IRepository<colony, int> colonyDataAcees()
        {
            return new colonyRepo(db);
        }
        public static IRepository<building, int> buildingDataAccess()
        {
            return new buildingRepo(db);
        }

        public static IRepository<flat, int> flatDataAccess()
        {
            return new flatRepo(db);
        }
    }
}
