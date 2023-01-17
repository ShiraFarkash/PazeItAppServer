using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class constantListBL
    {
        constantListDAL constantListDAL = new constantListDAL();
        public int addContantList(Constant_ListDTO constantList)
        {

            return constantListDAL.addContantList(converters.ConstantListConverter.Map(constantList));
        }

        public IEnumerable<Constant_ListDTO> GatContantList(int userId)
        {
            return converters.ConstantListConverter.Map(constantListDAL.GatContantList(userId));
        }

        public bool DeleteContantList(Constant_ListDTO constantList)
        {
            return constantListDAL.DeleteContantList(converters.ConstantListConverter.Map(constantList));
        }
    }
}
