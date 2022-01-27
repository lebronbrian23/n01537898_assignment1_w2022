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
        // GET api/numbermachine/4
        // This method takes an int and applies 4 mathematical operations to it
        public int Get(int id)
        {
           
            return id/id*id+id-id;
           
        }
    }
}
