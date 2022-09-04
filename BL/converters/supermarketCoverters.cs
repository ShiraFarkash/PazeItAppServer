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
        public static supermarket Map(supermarketDTO supermarketDTO)
        {
            return new supermarket
            {
                Name=supermarketDTO.Name
            };

        }

        public static supermarketDTO Map(supermarket supermarket)
        {
            return new supermarketDTO
            {
                Name = supermarket.Name

            };

        }



    }
}
