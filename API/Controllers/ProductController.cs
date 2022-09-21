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
    }
    //public class ProductController : Controller
    //{
    //    // GET: Product
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}