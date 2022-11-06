using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDAL
    {
        public void AddUser(user u)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.users.Add(u);
                DB.SaveChanges();
            }
        }

        public List<user> GetAllUsers()
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.users.ToList();
            }
        }
    }
}
