using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models {
    public class Category {

        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("amount")]
        public int Amount { get; set; }

        public bool IsValid() {
            return Name != null;
        }

    }
}
