using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace R6Tracker.Models
{
    public class ResultModel
    {
        [JsonProperty("p_name")]
        public string P_name { get; set; }
        [JsonProperty("p_level")]
        public int P_level { get; set; }
        [JsonProperty("p_platform")]
        public string P_platform { get; set; }
        [JsonProperty("p_currentmmr")]
        public int P_currentmmr { get; set; }
        [JsonProperty("p_currentrank")]
        public int P_currentrank { get; set; }
        [JsonProperty("kd")]
        public int Kd { get; set; }
    }
}