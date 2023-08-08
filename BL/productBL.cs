using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
   public class productBL
    {
        productDAL productDAL = new productDAL();

        public IEnumerable<DTO.productDTO> GatMainProduct()
        {
            return converters.productConverter.Map(productDAL.GatMainProduct());
        }

        public IEnumerable<DTO.productDTO> GatProductsByMainProduct(DTO.productDTO p)

        {
            return converters.productConverter.Map(
                productDAL.GatProductsByMainProduct(converters.productConverter.Map(p)) );
        }

       

        public  bool addProductToContantList(IEnumerable<Product_To_ListDTO> product_To_ListDTO)
        {
            return productDAL.addProductToContantList(converters.productConverter.Map(product_To_ListDTO));
        }

        public IEnumerable<categoryDTO> GatCategory()
        {
            return converters.categoryConverter.Map( productDAL.GatCategory());
        }

        public IEnumerable<productDTO> GatCategoryProductByCategoryId(int categoryID)
        {
            return converters.productConverter.Map(productDAL.GatCategoryProductByCategoryId(categoryID));

        }

        public productDTO GetProductById(int productId)
        {
            return converters.productConverter.Map(productDAL.GetProductById(productId));
        }

        public IEnumerable<productDTO> GetProductsByName(string productName)
        {
            return converters.productConverter.Map(productDAL.GetProductsByName(productName));
        }
    }
}
