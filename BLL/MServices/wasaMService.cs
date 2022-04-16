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
   public class wasaMService
    {
        public static List<wasaBillModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<wasaBill, wasaBillModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<wasaBillModel>>(DayaAccessFactoryM.wasaDataAccess().Get());
            return data;
        }

        public static List<string> GetName()
        {
            var data = DayaAccessFactoryM.wasaDataAccess().Get().Select(e => e.status).ToList();
            return data;
        }
        public static void Add(wasaBillModel b)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<wasaBillModel, wasaBill>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<wasaBill>(b);
            DayaAccessFactoryM.wasaDataAccess().Add(data);
        }

        public static void Edit(wasaBillModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<wasaBillModel, wasaBill>())).Map<wasaBill>(s);
            DayaAccessFactoryM.wasaDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DayaAccessFactoryM.wasaDataAccess().Delete(id);
        }

    }
}
