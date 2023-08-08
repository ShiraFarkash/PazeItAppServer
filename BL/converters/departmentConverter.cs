using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public class departmentConverter
    {
       


        public static departmentDTO Map(department department)
        {
            return new departmentDTO
            {
                Id = department.Id,
                branchID = department.branchID,
                departmentName = department.departmentName,
                departmentNumber = department.departmentNumber

            };

        }
        public static department Map(departmentDTO department)
        {
            return new department
            {
                Id = department.Id,
                branchID = department.branchID,
                departmentName = department.departmentName,
                departmentNumber = department.departmentNumber

            };

        }
        public static IEnumerable<department> Map(IEnumerable<departmentDTO> department)
        {
            foreach (var item in department)
            {
                yield return Map(item);
            }

        }

        public static IEnumerable<departmentDTO> Map(IEnumerable<department> department)
        {
            foreach (var item in department)
            {
                yield return Map(item);
            }

        }
    }
}
