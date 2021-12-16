using System.Text.Json.Serialization;

namespace CowryWiseIntegrate
{
    public class GetPaginatedResponseInputModel
    {
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; } = 10.ToString();

        [JsonPropertyName("page")]
        public string Page { get; set; } = 1.ToString();
    }
}
