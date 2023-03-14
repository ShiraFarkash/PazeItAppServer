using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Product_To_OneTimeListDTO
    {
        public int Id { get; set; }
        public int OneTimeListID { get; set; }
        public int productID { get; set; }
        public bool isTaken { get; set; }
        public int quantity { get; set; }
        public virtual One_time_ListDTO One_time_List { get; set; }
    }
}
