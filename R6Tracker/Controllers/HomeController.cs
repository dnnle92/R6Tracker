using R6Tracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace R6Tracker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index(string platform, string search)
        {

            var R6Stats = new R6Controller().GetStats(platform, search);

            return View(await R6Stats);
        }
    }
}
