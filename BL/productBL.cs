using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class productBL
    {
        productDAL productDAL = new productDAL();

        public IEnumerable<DTO.productDTO> GatMainProduct()
        {
            return converters.productConverter.Map(productDAL.GatMainProduct());
        }

        public IEnumerable<DTO.productDTO> GatProductsByMainProduct(DTO.productDTO p)

        {
            return converters.productConverter.Map(
                productDAL.GatProductsByMainProduct(converters.productConverter.Map(p)) );
        }

        public void addContantList(Constant_ListDTO constantList)
        {
            
             productDAL.addContantList(converters.ConstantListConverter.Map(constantList));
        }
    }
}
