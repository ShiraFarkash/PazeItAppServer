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

   
        public bool addProductToContantList(IEnumerable<Product_To_List> product_To_Lists)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                foreach (var item in product_To_Lists)
                {

                    //object o = DB.Product_To_List.Find<(p => item.constantListID == p.constantListID &&
                    //    item.productID == p.productID);
                    //if (o == null)
                    //    DB.Product_To_List.Add(item);
                    //else {
                    try { 
                        DB.Product_To_List.First(p => item.constantListID == p.constantListID &&
                        item.productID == p.productID).quantity = item.quantity;
                        }
                    catch
                    {
                        DB.Product_To_List.Add(item);
                    }
                    finally { 
                     DB.SaveChanges();
                    }
                }
                

                return true;

            }
        }

        public IEnumerable<product> GetProductsByName(string productName)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                List<product> products = new List<product>();
                try
                {
                    return DB.products.Where(p => p.productName.Contains(productName) &&p.productID!=null).ToList();
                }
                catch
                {
                    return products;
                }
            }
        }

        public product GetProductById(int productId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.products.First(p => p.Id == productId);
            }

        }

        public IEnumerable<product> GatCategoryProductByCategoryId(int categoryID)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.products.Where(p => p.categoryID == categoryID && p.productID!=null).ToList();
            }

           }




        public IEnumerable<category> GatCategory()
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.categories.ToList();
            }
        }
    }
}
