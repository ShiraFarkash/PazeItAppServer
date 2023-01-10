using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product_To_ListDTO
    {
        public int Id { get; set; }
        public int constantListID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
    }
}
