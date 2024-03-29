﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EmailService
    {
        //public bool SendEmail(string to, string header, string messageBody)
        public bool SendEmail(ApiBody apiBody)
        {
            var client = new RestClient("https://api.sendinblue.com/v3/smtp/email");

            var request = new RestRequest("", Method.Post);
            request.AddHeader("api-key", "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");

            request.AddHeader("Content-Type", "application/json");
      
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody( apiBody);
            RestResponse response = client.Execute(request);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }

    public class ApiBody
    {
       
            public Sender sender { get; set; }
            public List<To> to { get; set; }
            public string subject { get; set; }
            public string htmlContent { get; set; }
        }

        public class Sender
        {
            public string name { get; set;}
            public string email { get; set; }
        }

        public class To
        {
            public string email { get; set; }
            public string name { get; set; }
        }

    
}
