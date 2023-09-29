using System.Text.Json.Serialization;

namespace Models
{
    public class Account
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("balance")]
        public double Balance { get; set; }

        [JsonPropertyName("pin")]
        public int Pin { get; set; }

        [JsonPropertyName("accountNumber")]
        public string? AccountNumber { get; set; }
    }
};