using R6Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace R6Tracker.Controllers
{
    public class R6Controller : ApiController
    {
        [HttpGet]
        // GET: api/R6
        public async Task<RootObject> GetStats(string platform, string search)
        {
            var stats = new GetR6Stats();

            return await stats.GetStats(platform, search);

        }
    }
}
