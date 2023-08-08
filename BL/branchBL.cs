using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class branchBL
    {

        //public static void AddBranch(string supermarketName ,string address, string branchName)
        //{
        //    int i = BL.supermarketBL.IsExist(supermarketName);
        //    if (i >= 0) {
        //        DTO.branchDTO b = new DTO.branchDTO();
        //        b.branchName = branchName;
        //        b.address = address;
        //        b.supermarketID = i;
        //        using (PITdataBaseEntities DB = new PITdataBaseEntities())
        //        {
        //            DB.Branch.Add(converters.branchConverter.Map(b));
        //            DB.SaveChanges();
        //        }
        //    }
        //    else
        //    {
        //        DTO.supermarketDTO s= new DTO.supermarketDTO();
        //        s.Name= supermarketName;
        //        BL.supermarketBL.AddSupermarket(s);
        //        //to get the last id
        //        int Sid = (BL.supermarketBL.GetAllSupermarket()[BL.supermarketBL.GetAllSupermarket().Count-1]).Id;
        //        DTO.branchDTO b= new DTO.branchDTO();
        //        b.branchName = branchName;
        //        b.address = address;
        //        b.supermarketID = Sid;
        //        using (PITdataBaseEntities DB = new PITdataBaseEntities())
        //        {
        //            DB.Branch.Add(converters.branchConverter.Map(b));
        //            DB.SaveChanges();
        //        }
        //    }
            


        //}


    }
}

