using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL.MServices;


namespace BillMan.Controllers
{
    public class wasaMController:ApiController
    {
        [Route("api/wasaM/getName")]
        [HttpGet]
        public List<string> GetNames()
        {
            return wasaMService.GetName();
        }

        [Route("api/wasaM/All")]
        [HttpGet]
        public List<wasaBillModel> GetAll()
        {
            return wasaMService.Get();
        }


        [Route("api/wasaM/Create")]
        [HttpPost]
        public HttpResponseMessage Add(wasaBillModel b)
        {
            wasaMService.Add(b);
            return Request.CreateResponse(HttpStatusCode.OK, "Added");
        }

        [Route("api/wasaM/Edit")]
        [HttpPost]

        public HttpResponseMessage Edit(wasaBillModel e)
        {
            wasaMService.Edit(e);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/wasaM/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            wasaMService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }

    }
}