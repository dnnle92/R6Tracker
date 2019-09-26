using Newtonsoft.Json;
using R6Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace R6Tracker
{
    public class GetR6Stats
    {
        public async Task<RootObject> GetStats(string platform, string search)
        {
            ApiHelper.InitializeClient();
            var uriBuilder = new UriBuilder("https://r6tab.com/api/search.php");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["platform"] = platform;
            query["search"] = search;
            uriBuilder.Query = query.ToString();
            string url = uriBuilder.ToString();

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var R6res = JsonConvert.DeserializeObject<RootObject>(result);

                    return R6res;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}