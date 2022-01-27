using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class GreetingController : ApiController
    {
        // POST api/greeting
        // This method returns a string when invoked
        public string Post()
        {
            return "Hello World!";
        }

        // GET api/greeting/4
        // This method returns a string Greetings to the number of people sent to the endpoint
        public string Get(int id)
        {
            return "Greetings to " +id+" people";
        }

    }
}