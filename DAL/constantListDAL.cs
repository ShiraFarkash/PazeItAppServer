﻿using System;
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

        public IEnumerable<Constant_List> GatContantList(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.Constant_List.Where(c=> c.userID==userId).ToList();
            }
        }

        public void DeleteContantList(Constant_List constant_List)
        {
            using(PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.Constant_List.Remove(constant_List);
                DB.SaveChanges();
                IEnumerable<Product_To_List> enumerable = DB.Product_To_List.Where(p => p.constantListID == constant_List.Id).ToList();
                DB.Product_To_List.RemoveRange(enumerable);
            }
        }
    }
}
