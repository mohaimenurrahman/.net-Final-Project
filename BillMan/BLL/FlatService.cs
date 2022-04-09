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
    public class FlatService
    {
        public static List<FlatModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<building, BuildingModel>();
                c.CreateMap<flat, FlatModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<FlatModel>>(flatRepo.Get());
            return data;

        }

        public static List<string> GetNames()
        {
            var data = flatRepo.Get().Select(e => e.flatRenterName).ToList();
            return data;
        }

        public static void Add(FlatModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<FlatModel, flat>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<flat>(s);
            flatRepo.Add(data);
        }
    }
}
