using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StoreAdminer.Data.Models {
    public class Order {

        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("userLogin")]
        public string UserLogin { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty("goods")]
        public List<Good> Goods { get; set; }

    }
}
