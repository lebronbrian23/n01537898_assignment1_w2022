using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method receives an int and multiplies it by itself
        /// </summary>
        /// <param name="id">this is an integer</param>
        /// <returns>number</returns>
        // GET api/square/5

        public int Get(int id)
        {
            return id * id;
        }
    }
}