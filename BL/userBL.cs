﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BL
{

    public  class userBL
    {
        UserDAL userDAL = new UserDAL();
         
        public  int AddUser(userDTO user)
        {
           return  userDAL.AddUser(converters.userConverter.Map(user));
        }

       
        public  IEnumerable<DTO.userDTO> GetAllUsers()
        {
            return converters.userConverter.Map(userDAL.GetAllUsers());
        }


    }
}
