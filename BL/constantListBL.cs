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

        public IEnumerable<Product_To_ListDTO> GatOneContantList(int constantListID)
        {
            return converters.Product_To_ListConverter.Map(constantListDAL.GatOneContantList(constantListID));
        }

        public IEnumerable<productDTO> GatAllproductFromOneContantList(IEnumerable<Product_To_ListDTO> list)
        {

            return converters.productConverter.Map(constantListDAL.GatAllproductFromOneContantList(
                converters.Product_To_ListConverter.Map(list)));
        }

        public bool AddConstantListProductsTo_ProductToOneTimeList(IEnumerable<Product_To_ListDTO> list, int listId)
        {
            return constantListDAL.AddConstantListProductsTo_ProductToOneTimeList(converters.Product_To_ListConverter.Map(list), listId);
        }
    }
}
