using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
//using System.Web.Mvc;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        productBL productBL = new productBL();

        [Route("gatMainProduct"), HttpGet]
        public IEnumerable<DTO.productDTO> gatMainProduct()
        {
            return productBL.GatMainProduct();
        }


        //[Route("GatProductsByMainProduct")]
        //[HttpPost]
        //public IEnumerable<DTO.productDTO> GatProductsByMainProduct(int id)
        //{
        //    //return id;
        //
        //    return productBL.GatProductsByMainProduct(id);
        //}

        [Route("GatProductsByMainProduct")]
        [HttpPost]
        public IEnumerable<DTO.productDTO> GatProductsByMainProduct(DTO.productDTO p)
        {
           // return p.Id;

            return productBL.GatProductsByMainProduct(p);
        }
        [Route("addContantList")]
        [HttpPost]
        public int addContantList(DTO.Constant_ListDTO constantList)
        {
            return productBL.addContantList(constantList); 
        }
        
        //public IHttpActionResult addProductToBasicList()



    }
}