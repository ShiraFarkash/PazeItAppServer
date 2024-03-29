﻿using BL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;


namespace API.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        
        [Route("GetNumOfUsers")]
        [HttpGet]
        public IHttpActionResult GetNumOfUsers()
        {
            return Ok(1);
        }

        [Route("GetNumOfproduct/{numOfP}")]
        [HttpGet]
        public int GetNumOfproduct(int numOfP)
        {
            return numOfP;
        }

        [Route("AddUser"), HttpPost]
        public int AddUser(userDTO user)
        {
           return userBL.AddUser(user);
          
        }
        //[Route("AddUser"), HttpPost]
        //public IHttpActionResult AddUser(userDTO user)
        //{
        //    userBL.AddUser(user);
        //    return Ok(true);
        //}
        userBL userBL = new userBL();
        [Route("getAllUsers"), HttpGet]
        public IEnumerable<DTO.userDTO> getAllUsers()
        {
           return userBL.GetAllUsers();
        }

        [Route("isUserExist"), HttpGet]
        public int isUserExist(string email)
        {
            return userBL.isUserExist( email);
        }

        [Route("GetUserById"), HttpGet]
        public userDTO GetUserById(int userId)
        {
            return userBL.GetUserById(userId);
        }

        [Route("EditUserDetails"), HttpPost]
        public void EditUserDetails(userDTO user)
        {
             userBL.EditUserDetails(user);
        }

        [Route("GetUserEmail"), HttpGet]
        public userDTO GetUserEmail(string email)
        {
            return userBL.GetUserEmail(email);
        }

        //[Route("AddBranch/{superName}/{addres}/{Bname}"), HttpPost]
        //public IHttpActionResult AddBranch(string superName, string addres, string Bname)
        //{
        //    BL.branchBL.AddBranch(superName, addres, Bname);
        //    return Ok(1);

        //}


    }
}
