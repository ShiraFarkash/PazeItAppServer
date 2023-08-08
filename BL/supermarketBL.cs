using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class supermarketBL
    {
        //public static void AddSupermarket(supermarketDTO supermarket) 
        //{
        //    using (PITdataBaseEntities DB = new PITdataBaseEntities())
        //    {
        //        DB.supermarket.Add(converters.supermarketCoverters.Map(supermarket));
        //        DB.SaveChanges();

        //    }
        //}


        //public static List<DTO.supermarketDTO> GetAllSupermarket()
        //{

        //    List<supermarket> lst = new List<supermarket>();
        //    using (PITdataBaseEntities DB = new PITdataBaseEntities())
        //    {
        //      lst=  DB.supermarket.ToList();

        //    }
        //   List<DTO.supermarketDTO> listOfSupermarket = new List<DTO.supermarketDTO>();
        //    foreach (var item in lst)
        //    {
        //        listOfSupermarket.Add(converters.supermarketCoverters.Map(item));
        //    }
        //    return listOfSupermarket;

        //}

        //public static int IsExist(string name)
        //{
        //    bool IsExist=false ;  
        //    using (PITdataBaseEntities DB = new PITdataBaseEntities())
        //    {


        //    }

        //    string constr = System.Configuration.ConfigurationManager.ConnectionStrings["PITdataBaseEntities"].ConnectionString;
        //        SqlCommand command = new SqlCommand();
        //        SqlConnection con = new SqlConnection(constr);
        //        command.Connection = con;
        //        command.CommandText = string.Format("SELECT Id FROM  supermarket WHERE  Name='{{supermarketName}}'");
        //        object s=new supermarket();
        //        con.Open();
        //        s = command.ExecuteScalar();
        //        con.Close();
        //    if (s != null)
        //        return ((DAL.supermarket)s).Id;
        //    else
        //        return -1;

        //}
        DAL.supetMarketDAL supetMarketDAL = new supetMarketDAL();

        public IEnumerable<branchDTO> GetBranchesBySupetId(int superMarketId)
        {
            return converters.branchConverter.Map(supetMarketDAL.GetBranchesBySupetId(superMarketId));
        }

        public IEnumerable<departmentDTO> GetDepartmentsByBranchIdAndProducts(int branchId)
        {
            return converters.departmentConverter.Map(
               supetMarketDAL.GetDepartmentsByBranchIdAndProducts(branchId) );
        }

        public IEnumerable<productDTO> GetProductBydepartmentId(int departmentId, IEnumerable<productDTO> list)
        {
            return converters.productConverter.Map(
                supetMarketDAL.GetProductBydepartmentId(departmentId,
                converters.productConverter.Map(list)
                )
                );
        }

        public IEnumerable<Product_To_OneTimeListDTO> GetProductTOListBydepartmentId(int departmentId, IEnumerable<Product_To_OneTimeListDTO> list)
        {
            return converters.Product_To_OneTimeListConverter.Map(
                supetMarketDAL.GetProductTOListBydepartmentId(departmentId,
                converters.Product_To_OneTimeListConverter.Map(list)
                )
                );
        }

        public IEnumerable<supermarketDTO> GetSuperMarketList()
        {
            return converters.supermarketCoverters.Map(supetMarketDAL.GetSuperMarketList());
        }
    }

}
