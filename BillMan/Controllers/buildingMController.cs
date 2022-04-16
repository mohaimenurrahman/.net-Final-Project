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
    public class buildingMController : ApiController
    {
        [Route("api/buildingM/buildingNames")]
        [HttpGet]
        public List<string>GetNames()
        {
            return buildingService.GetName();
        }

        [Route("api/buildingM/All")]
        [HttpGet]
        public List<buildingModel> GetAll()
        {
            return buildingService.Get();
        }

        [Route("api/buildingM/get/{id}")]
        [HttpGet]
        public HttpResponseMessage GetbyId(int id)
        {
            var st = buildingService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);

        }

        [Route("api/buildingM/Create")]
        [HttpPost]
        public HttpResponseMessage Add(buildingModel b)
        {
            buildingService.Add(b);
            return Request.CreateResponse(HttpStatusCode.OK, "Added");
        }

        [Route("api/buildingM/Edit")]
        [HttpPost]

        public HttpResponseMessage Edit(buildingModel e)
        {
          buildingService.Edit(e);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/buildingM/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            buildingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }

       
    }
}
