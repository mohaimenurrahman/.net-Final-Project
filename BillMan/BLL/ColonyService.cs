using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.BEnt;
using DAL;

namespace BLL
{
    public class ColonyService
    {
        public static List<ColonyModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<colony, ColonyModel>();
                c.CreateMap<building, BuildingModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ColonyModel>>(colonyRepo.Get());
            return data;
      
        }

        public static List<string> GetNames()
        {
            var data = colonyRepo.Get().Select(e => e.colonyName).ToList();
            return data;
        }

        public static void Add(ColonyModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ColonyModel, colony>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<colony>(s);
            colonyRepo.Add(data);
        }

    }
}
