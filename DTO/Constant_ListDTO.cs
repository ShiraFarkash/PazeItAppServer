using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Constant_ListDTO
    {
        public int Id { get; set; }
        public int userID { get; set; }
        public string name { get; set; }

        public virtual userDTO user { get; set; }
    }
}
