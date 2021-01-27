using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models {
    public class JwtToken {

        [JsonProperty("accessToken")]
        public string Token { get; set; }

        [JsonProperty("exp")]
        public long Expires { get; set; }

        public bool IsExpired() {
            return Expires < DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

    }
}
