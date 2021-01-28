using Newtonsoft.Json;

namespace StoreAdminer.Data.Models {
    class Order {

        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("user.id")]
        public int UserId { get; set; }

        [JsonProperty("user.login")]
        public string UserLogin { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
