//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_to_Lists
    {
        public int userID { get; set; }
        public int OneTimeListID { get; set; }
        public bool isApproved { get; set; }
    
        public virtual One_time_List One_time_List { get; set; }
        public virtual user user { get; set; }
    }
}