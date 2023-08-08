using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using BL;
using System.Web.Http.Cors;
using DTO;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/OneTimeList")]
    public class OneTimeListController : ApiController
    {
        OneTimeListBL OneTimeListBL = new OneTimeListBL();
        [Route("GatContantList"), HttpGet]
        public IEnumerable<DTO.One_time_ListDTO> GetHistoryList(int userId)
        {
            return OneTimeListBL.GetHistoryList(userId);
        }

        [Route("AddOneTimeList"), HttpPost]
        public int AddOneTimeList(int userId)
        {
            return OneTimeListBL.AddOneTimeList(userId);
        }

        [Route("GetOneTimeList"), HttpGet]
        public int GetOneTimeList(int userId)
        {
            return OneTimeListBL.GetOneTimeList(userId);
        }

        [Route("IncreaseOrDecreaseProductQuantity"), HttpPost]
        public bool IncreaseOrDecreaseProductQuantity(DTO.Product_To_OneTimeListDTO p)
        {
            return OneTimeListBL.IncreaseOrDecreaseProductQuantity(p);
        }
        [Route("GetListOf_ProductToOneTimeList"), HttpGet]
        public IEnumerable<DTO.Product_To_OneTimeListDTO> GetListOf_ProductToOneTimeList(int listId)
        {
            return OneTimeListBL.GetListOf_ProductToOneTimeList(listId);
        }
        [Route("GetTheProductOfOneTimeList"), HttpPost]
        public IEnumerable<DTO.productDTO> GetTheProductOfOneTimeList(IEnumerable<DTO.Product_To_OneTimeListDTO> list)
        {
            return OneTimeListBL.GetTheProductOfOneTimeList(list);
        }

        [Route("GetTheProductByOneTimeListId"), HttpGet]
        public IEnumerable<DTO.productDTO> GetTheProductByOneTimeListId(int listId)
        {

            return OneTimeListBL.GetTheProductOfOneTimeList(OneTimeListBL.GetListOf_ProductToOneTimeList(listId));
        }

        //ע"מ להעתיק רשימה כמו היסטוריה או מוצרי חובה לתוך סל הקניות שלי
        [Route("AddProductsTo_ProductToOneTimeList"), HttpPost]
        public bool AddProductsTo_ProductToOneTimeList(IEnumerable<DTO.Product_To_OneTimeListDTO> list,int listId)
        {
            return OneTimeListBL.AddProductsTo_ProductToOneTimeList(list, listId);
        }


        //שינוי האם מוצר נלקח או לא
        [Route("ChangeIsTaken"), HttpPost]
        public bool ChangeIsTaken(DTO.Product_To_OneTimeListDTO Product_To_OneTimeListDTO)
        {
            return OneTimeListBL.ChangeIsTaken(Product_To_OneTimeListDTO);
        }

        //הפיכת הרשימה הנוכחית להיסטוריה ע"י שינוי הסטטוס
        //וכן יצירת רשימה חדשה למשתמש והחזרת ערך המפתח שלו
        [Route("WhenListIsDone"), HttpGet]
        public int WhenListIsDone(int listId, int userId)
        {
            OneTimeListBL.WhenListIsDone(listId);
            return AddOneTimeList( userId);
        }

        //שיתוף רשימה עם משתמש נוסף
        [Route("SherListWithUser"), HttpPost]
        public void SherListWithUser(int listId, int userId)
        {
            OneTimeListBL.SherListWithUser(listId, userId);
        }
    }
}