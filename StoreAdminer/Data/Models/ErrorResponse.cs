using Newtonsoft.Json;

namespace StoreAdminer.Data.Models {
    public class ErrorResponse {

        [JsonProperty("msg")]
        public string Message { get; set; }

    }
}
