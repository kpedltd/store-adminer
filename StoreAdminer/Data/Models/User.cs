using Newtonsoft.Json;
using System;

namespace StoreAdminer.Data.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("lastLogin")]
        public DateTime? LastLoginAt { get; set; }

        [JsonProperty("lastLoginIp")]
        public string LastLoginIp { get; set; }
    }
}