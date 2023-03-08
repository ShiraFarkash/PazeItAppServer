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
                return DB.One_time_List.Where(l => l.userID == userId && l.status==true).ToList();
            }
         }
    }
}
