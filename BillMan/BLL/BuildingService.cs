using AutoMapper;
using BLL.BEnt;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BuildingService
    {
        public static List<BuildingModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<colony, ColonyModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BuildingModel>>(buildingRepo.Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = buildingRepo.Get().Select(e => e.buildingName).ToList();
            return data;
        }

        public static void Add(BuildingModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BuildingModel, building>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<building>(s);
            buildingRepo.Add(data);
        }
    }
}
