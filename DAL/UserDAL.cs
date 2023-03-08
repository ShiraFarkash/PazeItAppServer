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

        public int isUserExist(string email)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                try
                {
                    user user = DB.users.Where(u => u.email == email).First();
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

        public void EditUserDetails(user user)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.users.Find(user.Id).userName=user.userName;
                DB.users.Find(user.Id).userLastName = user.userLastName;
                DB.users.Find(user.Id).email = user.email;
                DB.users.Find(user.Id).password = user.password;
                DB.SaveChanges();
            }
        }

        public user GetUserById(int userId)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                return DB.users.Find(userId);
            }
        }


    }
}
