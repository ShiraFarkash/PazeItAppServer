using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/SuperMarket")]
    public class SuperMarketController : ApiController
    {
        supermarketBL supermarketBL = new supermarketBL();

        [Route("GetSuperMarketList"), HttpGet]    
        public IEnumerable<DTO.supermarketDTO> GetSuperMarketList()
        {
            return supermarketBL.GetSuperMarketList();
        }

        [Route("GetBranchesBySupetId"), HttpGet]
        public IEnumerable<DTO.branchDTO> GetBranchesBySupetId(int superMarketId)
        {
            return supermarketBL.GetBranchesBySupetId(superMarketId);
        }
        [Route("GetDepartmentsByBranchIdAndProducts"), HttpGet]
        public IEnumerable<DTO.departmentDTO> GetDepartmentsByBranchIdAndProducts(int branchId)
        {
            return supermarketBL.GetDepartmentsByBranchIdAndProducts(branchId) ;
        }
        [Route("GetProductBydepartmentId"), HttpPost]
        public IEnumerable<DTO.productDTO> GetProductBydepartmentId(int departmentId, IEnumerable<DTO.productDTO> list)
        {
            return supermarketBL.GetProductBydepartmentId(departmentId, list);
        }

        [Route("GetProductTOListBydepartmentId"), HttpPost]
        public IEnumerable<DTO.Product_To_OneTimeListDTO> GetProductTOListBydepartmentId(int departmentId, IEnumerable<DTO.Product_To_OneTimeListDTO> list)
        {
            return supermarketBL.GetProductTOListBydepartmentId(departmentId, list);
        }


        }
}