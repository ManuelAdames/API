using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace API.Models
{
    public class Tag
    {

        [JsonProperty("known")]
        public int Known { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("products")]
        public int Products { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sameAs")]
        public IList<string> SameAs { get; set; }
    }
} 
