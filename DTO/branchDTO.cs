using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class branchDTO
    {
        public int Id { get; set; }
        public int supermarketID { get; set; }
        public string address { get; set; }
        public string branchName { get; set; }
        public virtual supermarketDTO supermarket { get; set; }
    }
}
