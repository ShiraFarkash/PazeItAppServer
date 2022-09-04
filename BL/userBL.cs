using DAL;
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

         
        public static void AddUser(userDTO user)
        {
             
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.users.Add(BL.converters.userConverter.Map(user));
                DB.SaveChanges();
            }
        }

        //by ADO -- 
        public static List<DTO.userDTO> GetAllUsers()
        {
            List<DTO.userDTO> listOfUsers = new List<DTO.userDTO>();

            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["PITdataBaseEntities"].ConnectionString;
            
            SqlCommand command = new SqlCommand();
            SqlConnection con = new SqlConnection(constr);
            command.Connection = con;
            command.CommandText = string.Format("SELECT * from users");
            try
            {
                con.Open();
                using (SqlDataReader reader =command.ExecuteReader())
                {
                    while (reader.Read()) {
                        userDTO u = new userDTO();
                        u.userName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                        u.userLastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        u.email = reader.IsDBNull(1) ? "" : reader.GetString(3);
                        u.password = reader.IsDBNull(1) ? "" : reader.GetString(4);
                        listOfUsers.Add(u);
                    }
                }
              
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
            return listOfUsers;
        }





    }
}
