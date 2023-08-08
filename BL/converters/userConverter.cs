using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.converters
{
    public static class userConverter
    {
        public static  user Map(userDTO user)
        {
            return new user
            {
                userName = user.userName,
                userLastName = user.userLastName,
                email = user.email,
                password = user.password,
                Id = user.Id
            };

        }
        public static userDTO Map(user user)
        {
            return new userDTO
            {
                userName = user.userName,
                userLastName = user.userLastName,
                email = user.email,
                password = user.password,
                Id=user.Id
                

            };

        }

        public static IEnumerable<userDTO> Map(IEnumerable<user> users)
        {
            foreach (var item in users)
            {
                yield return Map(item);
            }

        }


    }
}
