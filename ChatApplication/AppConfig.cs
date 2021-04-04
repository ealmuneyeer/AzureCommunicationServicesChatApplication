using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplication
{
    [JsonObject("appConfig")]
    public class AppConfig
    {
        [JsonProperty("Endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("ConnectionString")]
        public string ConnectionString { get; set; }
    }
}
