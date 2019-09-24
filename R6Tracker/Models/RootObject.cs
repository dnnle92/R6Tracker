using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace R6Tracker.Models
{
    public class RootObject
    {
        [JsonProperty]
        public ResultModel[] Results { get; set; }
        [JsonProperty]
        public int TotalResults { get; set; }
    }
}

