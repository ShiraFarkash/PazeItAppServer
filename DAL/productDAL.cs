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

        public List<product> GatProductsByMainProduct(DAL.product p)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
              
                return DB.products.Where(b => (b.productID == p.Id)).ToList();
            }
        }

        public int addContantList(Constant_List c)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.Constant_List.Add(c);
                DB.SaveChanges();
                return c.Id;
               
              
            }


        }
    }
}
