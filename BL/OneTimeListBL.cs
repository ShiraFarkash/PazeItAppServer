using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OneTimeListBL
    {
        OneTimeListDAL OneTimeListDAL = new OneTimeListDAL();
        public IEnumerable<One_time_ListDTO> GetHistoryList(int userId)
        {
            return converters.OneTimeListConverter.Map(OneTimeListDAL.GetHistoryList(userId));
        }
    }
}
