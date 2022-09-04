using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class One_time_ListDTO
    {
        public int Id { get; set; }
        public int userID { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public bool status { get; set; }
        public int branchID { get; set; }

        //public virtual branchDTO Branch { get; set; }
        //public virtual userDTO user { get; set; }
    }
}