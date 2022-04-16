using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using AutoMapper;
using DAL;
using DAL.MRepo;

namespace BLL.MServices
{
    public class buildingService
    {

        public static List<buildingModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<building, buildingModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<buildingModel>>(DayaAccessFactoryM.buildingDataAccess().Get());
            return data;
        }

        public static List<string> GetName()
        {
            var data = DayaAccessFactoryM.buildingDataAccess().Get().Select(e => e.buildingName).ToList();
            return data;
        }
        public static void Add(buildingModel b)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<buildingModel, building>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<building>(b);
            DayaAccessFactoryM.buildingDataAccess().Add(data);
        }

        public static void Edit(buildingModel s)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<buildingModel, building>())).Map<building>(s);
            DayaAccessFactoryM.buildingDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DayaAccessFactoryM.buildingDataAccess().Delete(id);
        }

        public static void getid(int id)
        {
            DayaAccessFactoryM.buildingDataAccess().Get(id);
        }
        public static buildingModel Get(int id)
        {
            var d = DayaAccessFactoryM.buildingDataAccess().Get(id);
            var c = new buildingModel()
            {
                id = d.id,
                buildingCode = d.buildingCode,
                buildingName = d.buildingName,
                totalFloors = d.totalFloors,
                totalFlats = d.totalFlats,
                ownerName=d.ownerName,
                colonyCode=d.colonyCode,
                username=d.username,
            };
            return c;
        }
    }
    
}
