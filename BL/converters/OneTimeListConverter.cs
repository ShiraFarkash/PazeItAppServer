using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL.converters
{
    public class OneTimeListConverter
    {

        public static DAL.One_time_List Map(DTO.One_time_ListDTO One_time_List)
        {
            return new One_time_List
            {
               Id= One_time_List.Id,
               userID= One_time_List.userID,
               ProductionDate= One_time_List.ProductionDate,
               endDate= One_time_List.endDate,
               status= One_time_List.status,
               branchID= One_time_List.branchID
            };

        }
        public static One_time_ListDTO Map(One_time_List One_time_List)
        {
            return new One_time_ListDTO
            {
                Id = One_time_List.Id,
                userID = One_time_List.userID,
                ProductionDate = One_time_List.ProductionDate,
                endDate = One_time_List.endDate,
                status = One_time_List.status,
                branchID = (int)One_time_List.branchID
            };

        }

        public static IEnumerable<One_time_ListDTO> Map(IEnumerable<One_time_List> One_time_List)
        {
            foreach (var item in One_time_List)
            {
                yield return Map(item);
            }

        }
        public static IEnumerable<One_time_List> Map(IEnumerable<One_time_ListDTO> One_time_List)
        {
            foreach (var item in One_time_List)
            {
                yield return Map(item);
            }

        }


    }
}
