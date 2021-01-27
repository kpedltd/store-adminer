using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models
{
    public class Good
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partNumber")]
        public int PartNumber { get; set; } = -1;

        [JsonProperty("price")]
        public decimal Price { get; set; } = -1;

        [JsonProperty("manufacturedAt")]
        public DateTime ManufacturedAt { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; } = -1;

        [JsonProperty("description")]
        public string Description { get; set; }

        public bool IsValid()
        {
            return (Name != null && PartNumber != -1 && ManufacturedAt != null & CategoryId != -1 && Price != -1);
        }
    }
}