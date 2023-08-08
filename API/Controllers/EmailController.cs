using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using BL;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/email")]
    public class EmailController : ApiController
    {
        EmailService EmailService = new EmailService();

        [Route("sendEmail"), HttpGet]
        public bool sendEmail(string e, string c)
        {
            string Email =e;
            string code =c;
            ApiBody apibody = new ApiBody();
            apibody.sender = new Sender();
            apibody.sender.email= "shirafarkash8@gmail.com";
            apibody.sender.name = "PazeIt";
            apibody.to = new List<To>();
            apibody.to.Add(new To { email =Email , name = "jana" });
            apibody.subject = "Verification code";
            apibody.htmlContent = "<html><head></head><body><p>Hello,</p>yours Verification is " + code+"</p></body></html>";

            return EmailService.SendEmail(apibody);
           
        }

       
    }
}
