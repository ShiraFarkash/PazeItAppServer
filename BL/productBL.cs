using DAL;
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
    }
}
