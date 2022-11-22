using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDAL
    {
        public int AddUser(user u)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.users.Add(u);
                DB.SaveChanges();          
                return u.Id;
            }
            
        }

        public List<user> GetAllUsers()
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.users.ToList();
            }
        }

        public int isUserExist(string email, string pass)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                try
                {
                    user user = DB.users.Where(u => u.email == email && u.password == pass).FirstOrDefault();
                    if (user != null)
                        return user.Id;
                }
                catch (Exception)
                {
                    return -1;
                }
                return -1;

            }
        }
    }
}
