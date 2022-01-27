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
        /// <summary>
        /// This method returns a string when invoked
        /// </summary>
        /// <returns>Hello world!</returns>
        // POST api/greeting
        public string Post()
        {
            return "Hello World!";
        }

        /// <summary>
        /// This method returns a string Greetings to the number of people sent to the endpoint
        /// </summary>
        /// <param name="id"></param>
        /// <returns> a string</returns>
        // GET api/greeting/4

        public string Get(int id)
        {
            return "Greetings to " +id+" people";
        }

    }
}