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
    public class FlatController : ApiController
    {
        [Route("api/Flat/FlatRenterNames")]
        [HttpGet]
        public List<string> GetNames()
        {
            return FlatService.GetNames();
        }
        [Route("api/Flat/All")]
        [HttpGet]
        public List<FlatModel> GetAll()
        {
            return FlatService.Get();
        }
        [Route("api/Flat/Create")]
        [HttpPost]
        public void Add(FlatModel s)
        {
            FlatService.Add(s);
        }
    }
}
