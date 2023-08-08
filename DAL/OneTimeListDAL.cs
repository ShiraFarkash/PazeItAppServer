using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OneTimeListDAL
    {
        public IEnumerable<One_time_List> GetHistoryList(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.One_time_List.Where(l => l.userID == userId && l.status == true).ToList();
            }
        }

        public int AddOneTimeList(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                One_time_List o = new One_time_List
                {
                    userID = userId,
                    status = false,
                    branchID = 1,
                    ProductionDate = DateTime.Now,
                    endDate = null
                };
                DB.One_time_List.Add(o);
                DB.SaveChanges();

                return o.Id;
            }
        }

        public bool IncreaseOrDecreaseProductQuantity(Product_To_OneTimeList product_To_OneTimeList)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                try
                {
                    if (product_To_OneTimeList.quantity == 0)
                    {
                        DB.Product_To_OneTimeList.Remove(DB.Product_To_OneTimeList.First(p =>
                        p.productID == product_To_OneTimeList.productID &&
                        p.OneTimeListID == product_To_OneTimeList.OneTimeListID));
                    }
                    else
                    {
                        DB.Product_To_OneTimeList.First(p =>
                        p.productID == product_To_OneTimeList.productID
                        && p.OneTimeListID == product_To_OneTimeList.OneTimeListID).quantity = product_To_OneTimeList.quantity;
                    }
                }
                catch
                {
                    DB.Product_To_OneTimeList.Add(product_To_OneTimeList);
                }
                finally
                {
                    DB.SaveChanges();
                }
                return true;
            }
        }

        public void SherListWithUser(int listId, int userId)
        {
            using(PITdataBaseEntities DB= new PITdataBaseEntities())
            {
                User_to_Lists u = new User_to_Lists();
                u.userID = userId;
                u.OneTimeListID = listId;
                DB.User_to_Lists.Add(u);
                DB.SaveChanges();
            }
        }

        public void WhenListIsDone(int listId)
        {
           using(PITdataBaseEntities DB=new PITdataBaseEntities())
            {
                DB.One_time_List.First(list => list.Id == listId).status=true;
                DB.SaveChanges();
            }
        }

        public bool ChangeIsTaken(Product_To_OneTimeList product_To_OneTimeList)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.Product_To_OneTimeList.First(p=> p==product_To_OneTimeList).isTaken =
                    ! DB.Product_To_OneTimeList.First(p => p == product_To_OneTimeList).isTaken;
                return DB.Product_To_OneTimeList.First(p => p == product_To_OneTimeList).isTaken;
            }
        }

        public bool AddProductsTo_ProductToOneTimeList(IEnumerable<Product_To_OneTimeList> enumerable, int listId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<product> GetTheProductOfOneTimeList(IEnumerable<Product_To_OneTimeList> enumerable)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product_To_OneTimeList> GetListOf_ProductToOneTimeList(int listId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.Product_To_OneTimeList.Where(p => p.OneTimeListID == listId).ToList();

            }
        }

        public int GetOneTimeList(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.One_time_List.First(o => o.userID == userId && o.status == false).Id;
            }
        }
    }
}
