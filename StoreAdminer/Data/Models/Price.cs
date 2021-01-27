using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models
{
    public class Price
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("price")]
        public string Amount { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}