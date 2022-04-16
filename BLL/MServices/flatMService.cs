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
    public class flatMService
    {
        public static List<flatModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<flat, flatModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<flatModel>>(DayaAccessFactoryM.flatDataAccess().Get());
            return data;
        }

        public static List<string> GetName()
        {
            var data = DayaAccessFactoryM.flatDataAccess().Get().Select(e => e.buildingName).ToList();
            return data;
        }
        public static void Add(flatModel b)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<flatModel, flat>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<flat>(b);
            DayaAccessFactoryM.flatDataAccess().Add(data);
        }

        public static void Edit(flatModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<flatModel, flat>())).Map<flat>(s);
            DayaAccessFactoryM.flatDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DayaAccessFactoryM.flatDataAccess().Delete(id);
        }

    }
}
