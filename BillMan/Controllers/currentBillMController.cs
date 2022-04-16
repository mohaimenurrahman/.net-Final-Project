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
    public class currentBillMController:ApiController
    {
        [Route("api/currentBillM/status/{string}")]
        [HttpGet]
        public List<string> GetNames()
        {
            return buildingService.GetName();
        }

        [Route("api/currentBillM/All")]
        [HttpGet]
        public List<currentBillModel> GetAll()
        {
            return currentBillMService.Get();
        }


        [Route("api/currentBillM/Create")]
        [HttpPost]
        public HttpResponseMessage Add(currentBillModel b)
        {
           currentBillMService.Add(b);
            return Request.CreateResponse(HttpStatusCode.OK, "Added");
        }

        [Route("api/currentBillM/Edit")]
        [HttpPost]

        public HttpResponseMessage Edit(currentBillModel e)
        {
            currentBillMService.Edit(e);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/currentBillM/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            buildingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }


    }
}