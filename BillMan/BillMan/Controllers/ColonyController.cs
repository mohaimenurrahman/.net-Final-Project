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
    public class ColonyController : ApiController
    {
        [Route("api/Colony/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ColonyService.GetNames();
        }
        [Route("api/Colony/All")]
        [HttpGet]
        public List<ColonyModel> GetAll()
        {
            return ColonyService.Get();
        }
        [Route("api/Colony/Create")]
        [HttpPost]
        public void Add(ColonyModel s)
        {
            ColonyService.Add(s);
        }
    }
}
