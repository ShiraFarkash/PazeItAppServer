using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public class branchConverter
    {
        public static Branch Map(branchDTO branchDTO)
        {
            return new Branch
            {
                Id=branchDTO.Id,
                supermarketID = branchDTO.supermarketID,
                 address = branchDTO.address,
                 branchName= branchDTO.branchName
            };

        }
  
        public static branchDTO Map(Branch branch)
        {
            return new branchDTO
            {
                Id = branch.Id,
                supermarketID = branch.supermarketID,
                address = branch.address,
                branchName = branch.branchName

            };

        }

        public static IEnumerable<branchDTO> Map(IEnumerable<Branch> branch)
        {
            foreach (var item in branch)
            {
                yield return Map(item);
            }

        }

        public static IEnumerable<Branch> Map(IEnumerable<branchDTO> branch)
        {
            foreach (var item in branch)
            {
                yield return Map(item);
            }

        }
    }
}
