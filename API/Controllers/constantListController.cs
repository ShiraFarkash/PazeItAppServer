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
        [Route("GatOneContantList")]
        [HttpGet]
        public IEnumerable<DTO.Product_To_ListDTO> GatOneContantList(int constantListID)
        {
            return constantListBL.GatOneContantList(constantListID);
        }
        [Route("GatAllproductFromOneContantList")]
        [HttpPost]
        public IEnumerable<DTO.productDTO> GatAllproductFromOneContantList(IEnumerable<Product_To_ListDTO> list)
        {
            return constantListBL.GatAllproductFromOneContantList(list);
        }
        [Route("AddConstantListProductsTo_ProductToOneTimeList"), HttpPost]
        public bool AddConstantListProductsTo_ProductToOneTimeList(IEnumerable<DTO.Product_To_ListDTO> list, int listId)
        {
            return constantListBL.AddConstantListProductsTo_ProductToOneTimeList(list, listId);
        }
    }
}
