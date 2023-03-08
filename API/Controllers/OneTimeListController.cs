using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using BL;
using System.Web.Http.Cors;
using DTO;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/OneTimeList")]
    public class OneTimeListController : ApiController
    {
        OneTimeListBL OneTimeListBL = new OneTimeListBL();
        [Route("GatContantList"), HttpGet]
        public IEnumerable<DTO.One_time_ListDTO> GetHistoryList(int userId)
        {
            return OneTimeListBL.GetHistoryList(userId);
        }

    }
}