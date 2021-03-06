using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method takes a numbert and applies 4 mathematical operations to it
        /// </summary>
        /// <param name="id"> this an integer</param>
        /// <returns> a number</returns>
        // GET api/numbermachine/4
        public int Get(int id)
        {
           
            return id/id*id+id-id;
           
        }
    }
}
