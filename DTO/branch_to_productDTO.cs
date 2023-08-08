using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class branch_to_productDTO
    {
        public int Id { get; set; }
        public int productID { get; set; }
        public int DepartmentID { get; set; }
        public Nullable< decimal> productPrice { get; set; }

        public virtual departmentDTO department { get; set; }
        public virtual productDTO product { get; set; }
    }
}
