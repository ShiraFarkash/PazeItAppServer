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
  

        //public int addListOf_ProductToContantList()
        //{
        //    return productBL.addContantList();
        //}

        //public IHttpActionResult addProductToBasicList()

        [Route("addProductToContantList")]
        [HttpPost]
        public IHttpActionResult addProductToContantList( List<DTO.Product_To_ListDTO> product_To_ListDTO)
        {
            return Ok(productBL.addProductToContantList(product_To_ListDTO));
        }


        [Route("GatCategory")]
        [HttpGet]
        public IEnumerable<DTO.categoryDTO> GatCategory()
        {
            return productBL.GatCategory();
        }


        [Route("GatCategoryProductByCategoryId")]
        [HttpGet]
        public IEnumerable<DTO.productDTO> GatCategoryProductByCategoryId(int categoryID)
        {
            return productBL.GatCategoryProductByCategoryId(categoryID);
        }

    }
}