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
                supermarketID = branchDTO.supermarketID,
                 address = branchDTO.address,
                 branchName= branchDTO.branchName
            };

        }
  
        public static branchDTO Map(Branch branch)
        {
            return new branchDTO
            {
                supermarketID = branch.supermarketID,
                address = branch.address,
                branchName = branch.branchName

            };

        }
    }
}
