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

        // GET api/square/5
        // This method receives an int and multiplies it by itself
        public int Get(int id)
        {
            return id * id;
        }
    }
}