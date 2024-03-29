﻿using Newtonsoft.Json;

namespace FundAmerica.Objects
{
    public class BaseObjectType
    {
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}