using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
   
    public class HostingCostController : ApiController
    {

        // GET api/hostingcost/5
        // This method receives a number of days and returns the cost of hosting per fortnight
        public string Get(int id)
        {
            const double cost_of_fortnight = 5.50;
            const double hst = 0.13;
            double calculate_cost_of_fortnight;
            double calculate_hst;
            double total;
            double calculate_fortnights = id / 14 + 1;
            
            calculate_cost_of_fortnight = cost_of_fortnight * calculate_fortnights;
            calculate_hst = Math.Round((calculate_cost_of_fortnight * hst),2);
            total = Math.Round(calculate_cost_of_fortnight + calculate_hst, 2);
            return calculate_fortnights +" fortnights at $5.50/FN = " + calculate_cost_of_fortnight + " CAD \n" +
                    " HST 13% = " + calculate_hst + " CAD Total = " + total + " CAD";
            
        }
    }
}
