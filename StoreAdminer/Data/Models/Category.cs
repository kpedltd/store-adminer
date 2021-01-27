using Newtonsoft.Json;

namespace StoreAdminer.Data.Models
{
    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public bool IsValid()
        {
            return Name != null;
        }
    }
}