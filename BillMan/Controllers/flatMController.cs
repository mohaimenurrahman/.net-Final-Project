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
    public class flatMController:ApiController
    {
        [Route("api/flatM/buildingname/{string}")]
        [HttpGet]
        public List<string> GetNames()
        {
            return flatMService.GetName();
        }

        [Route("api/flatM/All")]
        [HttpGet]
        public List<flatModel> GetAll()
        {
            return flatMService.Get();
        }


        [Route("api/flatM/Create")]
        [HttpPost]
        public HttpResponseMessage Add(flatModel b)
        {
            flatMService.Add(b);
            return Request.CreateResponse(HttpStatusCode.OK, "Added");
        }

        [Route("api/flatM/Edit")]
        [HttpPost]

        public HttpResponseMessage Edit(flatModel e)
        {
            flatMService.Edit(e);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/flatM/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            flatMService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }

    }
}