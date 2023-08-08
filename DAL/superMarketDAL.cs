//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL
//{
//    public class superMarketDAL
//    {
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class supetMarketDAL
    {
        public IEnumerable<supermarket> GetSuperMarketList()
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
               
                return  DB.supermarkets.Where(su => su.Id!= 1).ToList();
            }
        }

        public IEnumerable<Branch> GetBranchesBySupetId(int superMarketId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {

                return DB.Branches.Where(br => br.supermarketID == superMarketId).ToList(); ;
            }
        }

        public IEnumerable<department> GetDepartmentsByBranchIdAndProducts(int branchId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                List<department> departments = new List<department>();
                departments = DB.departments.Where(dep => dep.branchID == branchId).ToList();
                return departments;
            }

        }
        public IEnumerable<product> GetProductBydepartmentId(int departmentId, IEnumerable<product> list)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                List<product> products = new List<product>();
                foreach (var item in list)
                {

                    bool exist = false;
                    List<Branch_To_Product> bList = DB.Branch_To_Product.ToList();
                    foreach (var i in bList)
                    {
                        if (i.productID == item.Id && i.DepartmentID == departmentId)
                            exist = true;
                    }
                    //DB.Branch_To_Product.Where(p =>( p.productID == item.productID && p.DepartmentID == departmentId)).ToList();
                    if (exist == true)
                    {
                        products.Add(item);
                        exist = false;
                    }




                }


                return products;
            }

        }

        public IEnumerable<Product_To_OneTimeList> GetProductTOListBydepartmentId(int departmentId, IEnumerable<Product_To_OneTimeList> list)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                List<Product_To_OneTimeList> products = new List<Product_To_OneTimeList>();
                foreach (var item in list)
                {
                    bool exist = false;
                    List<Branch_To_Product> bList = DB.Branch_To_Product.ToList();
                    foreach (var i in bList)
                    {
                        if (i.productID == item.productID && i.DepartmentID == departmentId)
                            exist = true;
                    }
                    if (exist == true)
                    {
                        products.Add(item);
                        exist = false;
                    }

                }


                return products;
            }

        }


    }
}

