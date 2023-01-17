using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public class categoryConverter
    {
        public static category Map(categoryDTO categoryDTO)
        {
            return new category
            {
                Id = categoryDTO.Id,
                categoryName = categoryDTO.categoryName,
               
            };

        }

        public static categoryDTO Map(category category)
        {
            return new categoryDTO
            {
                Id = category.Id,
                categoryName = category.categoryName,

            };

        }


        public static IEnumerable<categoryDTO> Map(IEnumerable<category> category)
        {
            foreach (var item in category)
            {
                yield return Map(item);
            }

        }


        public static IEnumerable<category> Map(IEnumerable<categoryDTO> categoryDTO)
        {
            foreach (var item in categoryDTO)
            {
                yield return Map(item);
            }

        }
    }
}
