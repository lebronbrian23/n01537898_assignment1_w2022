using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method receives an int and adds 10 to it
        /// </summary>
        /// <param name="id">number</param>
        /// <returns>number</returns>
        // GET api/addten/5
        public int Get(int id)
        {
            return id + 10;
        }
     
    }
}
