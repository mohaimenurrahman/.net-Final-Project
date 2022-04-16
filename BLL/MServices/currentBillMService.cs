using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.MRepo;
using BEL;
using AutoMapper;

namespace BLL.MServices
{
    public class currentBillMService
    {
        public static List<currentBillModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<currentBill, currentBillModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<currentBillModel>>(DayaAccessFactoryM.currentBillDataAccess().Get());
            return data;
        }

        public static List<string> GetName()
        {
            var data = DayaAccessFactoryM.currentBillDataAccess().Get().Select(e => e.status).ToList();
            return data;
        }
        public static void Add(currentBillModel b)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<currentBillModel, currentBill>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<currentBill>(b);
            DayaAccessFactoryM.currentBillDataAccess().Add(data);
        }

        public static void Edit(currentBillModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<currentBillModel, currentBill>())).Map<currentBill>(s);
            DayaAccessFactoryM.currentBillDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DayaAccessFactoryM.currentBillDataAccess().Delete(id);
        }
    }
}

