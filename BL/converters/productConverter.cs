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



        public static Product_To_List Map(Product_To_ListDTO Product_To_ListDTO)
        {
            return new Product_To_List
            {
              
              constantListID = Product_To_ListDTO.constantListID,
              productID= Product_To_ListDTO.productID,
              quantity= Product_To_ListDTO.quantity

            };

        }

        public static Product_To_ListDTO Map(Product_To_List Product_To_List)
        {
            return new Product_To_ListDTO
            {
                Id = Product_To_List.Id,
                constantListID = Product_To_List.constantListID,
                productID = Product_To_List.productID,
                quantity = Product_To_List.quantity

            };

        }

        public static IEnumerable<Product_To_List> Map(IEnumerable<Product_To_ListDTO> Product_To_ListDTO)
        {
            foreach (var item in Product_To_ListDTO)
            {
                yield return Map(item);
            }

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
        public static product Map(productDTO productDTO)
        {
            return new product
            {
                Id = productDTO.Id,
                productName = productDTO.productName,
                productID = productDTO.productID,
                categoryID = productDTO.categoryID,
                barcode = productDTO.barcode

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
