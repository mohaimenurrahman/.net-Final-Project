using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BillMan.Controllers
{
    public class BuildingController : ApiController
    {
        [Route("api/Building/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return BuildingService.GetNames();
        }
        [Route("api/Building/All")]
        [HttpGet]
        public List<BuildingModel> GetAll()
        {
            return BuildingService.Get();
        }
        [Route("api/Building/Create")]
        [HttpPost]
        public void Add(BuildingModel s)
        {
            BuildingService.Add(s);
        }
    }
}
