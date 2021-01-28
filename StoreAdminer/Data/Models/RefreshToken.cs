using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models {
    public class RefreshToken {

        [JsonProperty("token")]
        public string Token { get; set; }
        
        [JsonProperty("exp")]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("createdByIp")]
        public string CreatedByIp { get; set; }

    }
}
