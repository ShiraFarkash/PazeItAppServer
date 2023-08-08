using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class constantListDAL
    {

        public int addContantList(Constant_List c)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.Constant_List.Add(c);
                DB.SaveChanges();
                return c.Id;


            }


        }
        //הוספת רשימה חדשה של מוצרי חובה
        public IEnumerable<Constant_List> GatContantList(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.Constant_List.Where(c=> c.userID==userId).ToList();
            }
        }
      
        public bool DeleteContantList(Constant_List constant_List)
        {
            using(PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                IEnumerable<Product_To_List> enumerable = DB.Product_To_List.Where(p => p.constantListID == constant_List.Id).ToList();
                DB.Product_To_List.RemoveRange(enumerable);

                var Constant_List = DB.Constant_List.Single(c => c.Id == constant_List.Id);
                DB.Constant_List.Remove(Constant_List);
                DB.SaveChanges();
                return true;
            }
        }

   
        public List<product> GatAllproductFromOneContantList(IEnumerable<Product_To_List>list)
        {
            List<product> p = new List<product>();
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                foreach (var item in list)
                {
                    product i = DB.products.Find(item.productID);
                    if(i!=null)
                     p.Add(i);
                }
            }
            return p;
        }

        public bool AddConstantListProductsTo_ProductToOneTimeList(IEnumerable<Product_To_List> list, int listId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                foreach (var item in list)
                {
                    try
                    {
                        Product_To_OneTimeList first = DB.Product_To_OneTimeList.First
                            (pro => pro.OneTimeListID == listId && pro.productID == item.productID);
                    }
                    catch
                    {
                        Product_To_OneTimeList p = new Product_To_OneTimeList();
                        p.productID = item.productID;
                        p.quantity = item.quantity;
                        p.OneTimeListID = listId;
                        p.isTaken = false;
                        DB.Product_To_OneTimeList.Add(p);
                        DB.SaveChanges();
                    }


                }
            }
            return true;
        }

        //חזרת רשימת המוצרים הקשורים לרשימה
        public IEnumerable<Product_To_List> GatOneContantList(int constantListID)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                IEnumerable<Product_To_List> productsToList = DB.Product_To_List.Where(p => p.constantListID == constantListID).ToList();
                return productsToList;
            }
        }
            
    }
}
