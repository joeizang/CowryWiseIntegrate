using System;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate
{
    public class DtoBase
    {
        [JsonPropertyName("errors")]
        public string Errors { get; set; } = String.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = String.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = String.Empty;
    }
}
