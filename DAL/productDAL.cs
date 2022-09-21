using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class productDAL
    {
        public List<product> GatMainProduct()
        {
            using(PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.products.Where(p => p.productID == null).ToList();
            }
        }
    }
}
