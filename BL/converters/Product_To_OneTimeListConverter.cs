using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.converters
{
    public static class Product_To_OneTimeListConverter
    {
        public static Product_To_OneTimeList Map(Product_To_OneTimeListDTO p)
        {
            return new Product_To_OneTimeList
            {
              Id=p.Id,
              OneTimeListID=p.OneTimeListID,
              productID=p.productID,
              isTaken=p.isTaken,
              quantity=p.quantity

            };
        }


        public static Product_To_OneTimeListDTO  Map(Product_To_OneTimeList p)
        {
            return new Product_To_OneTimeListDTO
            {
                Id = p.Id,
                OneTimeListID = p.OneTimeListID,
                productID = p.productID,
                isTaken = p.isTaken,
                quantity = p.quantity

            };
        }
        public static IEnumerable<Product_To_OneTimeListDTO> Map(IEnumerable<Product_To_OneTimeList> p)
        {
            foreach (var item in p)
            {
                yield return Map(item);
            }

        }

        public static IEnumerable<Product_To_OneTimeList> Map(IEnumerable<Product_To_OneTimeListDTO> p)
        {
            foreach (var item in p)
            {
                yield return Map(item);
            }

        }

    }
}