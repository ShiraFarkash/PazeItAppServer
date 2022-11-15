using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public static class ConstantListConverter
    {
        public static Constant_List Map(Constant_ListDTO constant_List)
        {
            return new Constant_List
            {
               Id=constant_List.Id,
               userID=constant_List.userID,
               name=constant_List.name

            };

        }
        public static Constant_ListDTO Map(Constant_List constant_List)
        {
            return new Constant_ListDTO
            {
                Id = constant_List.Id,
                userID = constant_List.userID,
                name = constant_List.name

            };

        }

        public static IEnumerable<Constant_ListDTO> Map(IEnumerable<Constant_List> constant_Lists)
        {
            foreach (var item in constant_Lists)
            {
                yield return Map(item);
            }

        }
        public static IEnumerable<Constant_List> Map(IEnumerable<Constant_ListDTO> constant_Lists)
        {
            foreach (var item in constant_Lists)
            {
                yield return Map(item);
            }

        }




    }
}
