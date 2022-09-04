using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class productDTO
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public Nullable<int> productID { get; set; }
        public int categoryID { get; set; }
        public string barcode { get; set; }

        public virtual categoryDTO category { get; set; }
    }
}