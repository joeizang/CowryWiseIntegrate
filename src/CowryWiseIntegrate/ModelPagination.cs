using System.Text.Json.Serialization;

namespace CowryWiseIntegrate
{
    public class ModelPagination
    {
        [JsonPropertyName("next")]
        public string Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public string Previous { get; set; } = string.Empty;

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("current_page")]
        public string CurrentPage { get; set; } = string.Empty;

        [JsonPropertyName("total_pages")]
        public string TotalPages { get; set; } = string.Empty;
    }
}
