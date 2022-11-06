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
        public bool sendEmail()
        {
            ApiBody apibody = new ApiBody();
            apibody.sender = new Sender();
            apibody.sender.email= "shirafarkash8@gmail.com";
            apibody.sender.name = "PazeIt";
            apibody.to = new List<To>();
            apibody.to.Add(new To { email = "shirafarkash8@gmail.com" , name = "jana" });
            apibody.subject = "Verification code";
            apibody.htmlContent = "<html><head></head><body><p>Hello,</p>yours Verification code is 11111</p></body></html>";

            return EmailService.SendEmail(apibody);
           
        }
       
    }
}
