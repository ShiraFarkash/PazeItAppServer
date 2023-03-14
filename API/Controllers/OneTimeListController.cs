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

        [Route("AddOneTimeList"), HttpPost]
        public int AddOneTimeList(int userId)
        {
            return OneTimeListBL.AddOneTimeList(userId);
        }

        [Route("GetOneTimeList"), HttpGet]
        public int GetOneTimeList(int userId)
        {
            return OneTimeListBL.GetOneTimeList(userId);
        }

        [Route("IncreaseOrDecreaseProductQuantity"), HttpPost]
        public bool IncreaseOrDecreaseProductQuantity(DTO.Product_To_OneTimeListDTO p)
        {
            return OneTimeListBL.IncreaseOrDecreaseProductQuantity(p);
        }
        [Route("GetListOf_ProductToOneTimeList"), HttpGet]
        public IEnumerable<DTO.Product_To_OneTimeListDTO> GetListOf_ProductToOneTimeList(int listId)
        {
            return OneTimeListBL.GetListOf_ProductToOneTimeList(listId);
        }
    }
}