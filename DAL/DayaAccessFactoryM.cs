using DAL.MRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DayaAccessFactoryM
    {
        static BManEntities db;
        static DayaAccessFactoryM()
        {
            db = new BManEntities();
        }
        public static IRepositoryM<building, int> buildingDataAccess()
        {
            return new buildingMRepo(db);
        }

        public static IRepositoryM<currentBill, int> currentBillDataAccess()
        {
            return new currentBillMRepo(db);
        }

        public static IRepositoryM<flat, int> flatDataAccess()
        {
            return new flatMRepo(db);
        }

        public static IRepositoryM<wasaBill, int> wasaDataAccess()
        {
            return new wasaMRepo(db);
        }
    }
}
