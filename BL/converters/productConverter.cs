using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public static class productConverter
    {
        public static product Map(productDTO product)
        {
            return new product
            {
                Id = product.Id,
                productName = product.productName,
                productID = product.productID,
                categoryID = product.categoryID,
                barcode = product.barcode

            };

        }
        public static productDTO Map(product product)
        {
            return new productDTO
            {
                Id=product.Id,
                productName = product.productName,
                productID = product.productID,
                categoryID = product.categoryID,
                barcode = product.barcode

            };

        }

        public static IEnumerable<productDTO> Map(IEnumerable<product> products)
        {
            foreach (var item in products)
            {
                yield return Map(item);
            }

        }


    }
}
