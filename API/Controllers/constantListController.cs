using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using BL;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/constantList")]
    public class ConstantListController : ApiController
    {
        constantListBL constantListBL = new constantListBL();
        [Route("GatContantList")]
        [HttpGet]
        public IEnumerable<DTO.Constant_ListDTO> GatContantList(int userId)
        {
            return constantListBL.GatContantList(userId);
        }
        [Route("addContantList")]
        [HttpPost]
        public int addContantList(DTO.Constant_ListDTO constantList)
        {
            return constantListBL.addContantList(constantList);
        }

        [Route("DeleteContantList")]
        [HttpPost]
        public bool DeleteContantList(DTO.Constant_ListDTO constantList)
        {
            return constantListBL.DeleteContantList(constantList);
        }


    }
}
