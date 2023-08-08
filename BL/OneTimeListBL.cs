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

        public int AddOneTimeList(int userId)
        {
            return OneTimeListDAL.AddOneTimeList(userId);
        }

        public int GetOneTimeList(int userId)
        {
            return OneTimeListDAL.GetOneTimeList(userId);
        }

        public bool IncreaseOrDecreaseProductQuantity(Product_To_OneTimeListDTO p)
        {
           return OneTimeListDAL.IncreaseOrDecreaseProductQuantity(converters.Product_To_OneTimeListConverter.Map(p));
        }

        public IEnumerable<Product_To_OneTimeListDTO> GetListOf_ProductToOneTimeList(int listId)
        {
            return converters.Product_To_OneTimeListConverter.Map(OneTimeListDAL.GetListOf_ProductToOneTimeList(listId));
        }

        public IEnumerable<productDTO> GetTheProductOfOneTimeList(IEnumerable<Product_To_OneTimeListDTO> p)
        {
            return converters.productConverter.Map(
                OneTimeListDAL.GetTheProductOfOneTimeList(converters.Product_To_OneTimeListConverter.Map(p)));
        }

        public bool AddProductsTo_ProductToOneTimeList(IEnumerable<Product_To_OneTimeListDTO> list,int listId)
        {
            return OneTimeListDAL.AddProductsTo_ProductToOneTimeList(converters.Product_To_OneTimeListConverter.Map(list),listId);

           
        }

        public bool ChangeIsTaken(Product_To_OneTimeListDTO product_To_OneTimeListDTO)
        {
            return OneTimeListDAL.ChangeIsTaken(converters.Product_To_OneTimeListConverter.Map(product_To_OneTimeListDTO));
        }

        public void WhenListIsDone(int listId)
        {
            OneTimeListDAL.WhenListIsDone(listId);
        }

        public void SherListWithUser(int listId, int userId)
        {
            OneTimeListDAL.SherListWithUser(listId, userId);
        }
    }
}
