using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.converters
{
    public static class Product_To_ListConverter
    {

        public static Product_To_List Map(Product_To_ListDTO product_To_ListDTO)
        {
            return new Product_To_List
            {
               Id= product_To_ListDTO.Id,
               constantListID= product_To_ListDTO.constantListID,
               productID= product_To_ListDTO.productID,
               quantity= product_To_ListDTO.quantity
            };

        }
        public static Product_To_ListDTO Map(Product_To_List product_To_List)
        {
            return new Product_To_ListDTO
            {
                Id = product_To_List.Id,
                constantListID = product_To_List.constantListID,
                productID = product_To_List.productID,
                quantity = product_To_List.quantity
            };

        }

        public static IEnumerable<Product_To_ListDTO> Map(IEnumerable<Product_To_List> product_To_List)
        {
            foreach (var item in product_To_List)
            {
                yield return Map(item);
            }

        }
        public static IEnumerable<Product_To_List> Map(IEnumerable<Product_To_ListDTO> product_To_List)
        {
            foreach (var item in product_To_List)
            {
                yield return Map(item);
            }

        }


    }
}