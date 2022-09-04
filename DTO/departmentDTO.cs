using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class departmentDTO
    {
        public int Id { get; set; }
        public int branchID { get; set; }
        public string departmentName { get; set; }
        public string departmentNumber { get; set; }

        public virtual branchDTO Branch { get; set; }
    }
}