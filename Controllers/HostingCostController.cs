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
        /// <summary>
        /// This method receives a number of days and returns the cost of hosting per fortnight
        /// </summary>
        /// <param name="id">this an integer to represent days </param>
        /// <returns> a string message</returns>
        // GET api/hostingcost/5
        public string Get(int id)
        {
            //variable declaration
            const double cost_of_fortnight = 5.50;
            const double hst = 0.13;
            double calculate_cost_of_fortnight;
            double calculate_hst;
            double total;

            // determine the number of fortnights from the days  sent on the api
            double calculate_fortnights = id / 14 + 1;
            
            // calculate the cost of each fortnight.
            calculate_cost_of_fortnight = cost_of_fortnight * calculate_fortnights;
            // calculate the hst for the cost of the fortnight(s)
            calculate_hst = Math.Round((calculate_cost_of_fortnight * hst),2);
            // add the calculate_cost_of_fortnight to calculate_hst
            total = Math.Round(calculate_cost_of_fortnight + calculate_hst, 2);
            return calculate_fortnights +" fortnights at $5.50/FN = " + calculate_cost_of_fortnight + " CAD \n" +
                    " HST 13% = " + calculate_hst + " CAD Total = " + total + " CAD";
            
        }
    }
}
