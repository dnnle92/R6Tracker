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
        public async Task<ActionResult> Index(string platform, string search)
        {
            List<ResultModel> Results = new List<ResultModel>();
            //RootObject Results = new RootObject();
            ApiHelper.InitializeClient();
            var uriBuilder = new UriBuilder("https://localhost:44314/api/r6");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["platform"] = platform;
            query["search"] = search;
            uriBuilder.Query = query.ToString();
            string url = uriBuilder.ToString();
            System.Diagnostics.Debug.WriteLine(url);
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var R6response = await response.Content.ReadAsStringAsync();
                    Results = JsonConvert.DeserializeObject<List<ResultModel>>(R6response);

                }
            }

            return View(Results);
        }
    }
}
