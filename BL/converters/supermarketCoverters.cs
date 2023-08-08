using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
   public class supermarketCoverters
    {
        public static supermarket Map(supermarketDTO supermarket)
        {
            return new supermarket
            {
                Id= supermarket.Id,
                Name= supermarket.Name,
                src= supermarket.src

            };

        }

        public static supermarketDTO Map(supermarket supermarket)
        {
            return new supermarketDTO
            {
                Id = supermarket.Id,
                Name = supermarket.Name,
                src = supermarket.src

            };

        }

        public static IEnumerable<supermarketDTO> Map(IEnumerable<supermarket> supermarket)
        {
            foreach (var item in supermarket)
            {
                yield return Map(item);
            }

        }
        public static IEnumerable<supermarket> Map(IEnumerable<supermarketDTO> supermarket)
        {
            foreach (var item in supermarket)
            {
                yield return Map(item);
            }

        }




    }
}
