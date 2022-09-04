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
        public static void AddSupermarket(supermarketDTO supermarket) 
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.supermarkets.Add(converters.supermarketCoverters.Map(supermarket));
                DB.SaveChanges();

            }
        }


        public static List<DTO.supermarketDTO> GetAllSupermarket()
        {

            List<supermarket> lst = new List<supermarket>();
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
              lst=  DB.supermarkets.ToList();
                
            }
           List<DTO.supermarketDTO> listOfSupermarket = new List<DTO.supermarketDTO>();
            foreach (var item in lst)
            {
                listOfSupermarket.Add(converters.supermarketCoverters.Map(item));
            }
            return listOfSupermarket;
            

        }

        public static int IsExist(string name)
        {
            bool IsExist=false ;  
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                

            }

            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["PITdataBaseEntities"].ConnectionString;
                SqlCommand command = new SqlCommand();
                SqlConnection con = new SqlConnection(constr);
                command.Connection = con;
                command.CommandText = string.Format("SELECT Id FROM  supermarket WHERE  Name='{{supermarketName}}'");
                object s=new supermarket();
                con.Open();
                s = command.ExecuteScalar();
                con.Close();
            if (s != null)
                return ((DAL.supermarket)s).Id;
            else
                return -1;

        }


    }

}
