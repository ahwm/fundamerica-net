using Newtonsoft.Json;
using System.Collections.Generic;

namespace FundAmerica.Objects
{
    public class ResponseType<T>
    {
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "total_resources")]
        public int TotalResources { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        [JsonProperty(PropertyName = "per")]
        public int Per { get; set; }

        [JsonProperty(PropertyName = "more")]
        public bool More { get; set; }

        [JsonProperty(PropertyName = "resources")]
        public List<T> Resources { get; set; }
    }
}