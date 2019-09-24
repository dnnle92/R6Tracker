using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace R6Tracker.Models
{
    public class ResultModel
    {
        [JsonProperty]
        public string P_name { get; set; }
        [JsonProperty]
        public int P_level { get; set; }
        [JsonProperty]
        public string P_platform { get; set; }
        [JsonProperty]
        public int P_currentmmr { get; set; }
        [JsonProperty]
        public int P_currentrank { get; set; }
        [JsonProperty]
        public int Kd { get; set; }
    }
}