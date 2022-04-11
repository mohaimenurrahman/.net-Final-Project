using BLL;
using BEL;
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
        [Route("api/Flat/Names")]
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

        [Route("api/Flat/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            FlatService.Delete(id);
        }

        [Route("api/Flat/edit")]
        [HttpPost]

        public void Edit(FlatModel e)
        {
            FlatService.Edit(e);
        }
    }
}
