using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate.DTOs.Index
{
    public class IndexPagination
    {
        [JsonPropertyName("next")]
        public object Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class IndexAllocation
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_name")]
        public string AssetName { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("weight")]
        public double Weight { get; set; }
    }

    public class IndexResponsePayload
    {
        [JsonPropertyName("index_id")]
        public string IndexId { get; set; } = string.Empty;

        [JsonPropertyName("is_user_created")]
        public bool IsUserCreated { get; set; }

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("allocations")]
        public List<IndexAllocation> Allocations { get; set; } = new List<IndexAllocation>();
    }

    public class IndexPaginatedResponse : DtoBase
    {
        [JsonPropertyName("pagination")]
        public ModelPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<IndexResponsePayload> Data { get; set; }

    }

    public class IndexAssetResponsePayload
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_name")]
        public string AssetName { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("weight")]
        public double Weight { get; set; }
    }

    public class IndexAssetsResponse : DtoBase
    {
        [JsonPropertyName("data")]
        public List<IndexAssetResponsePayload> Data { get; set; } = new List<IndexAssetResponsePayload>();

    }

    public class SingleIndexResponsePayload
    {
        [JsonPropertyName("index_id")]
        public string IndexId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public object AccountId { get; set; } = string.Empty;

        [JsonPropertyName("is_user_created")]
        public bool IsUserCreated { get; set; }

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("allocations")]
        public List<object> Allocations { get; set; } = new List<object>();

        [JsonPropertyName("index_type")]
        public string IndexType { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
    }

    public class SingleIndexResponse
    {
        [JsonPropertyName("data")]
        public SingleIndexResponsePayload Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class CustomIndexResponsePayload
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("buy_price")]
        public double BuyPrice { get; set; }

        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; } = string.Empty;

        [JsonPropertyName("current_price")]
        public double CurrentPrice { get; set; }

        [JsonPropertyName("current_yield")]
        public double CurrentYield { get; set; }

        [JsonPropertyName("price_at")]
        public string PriceAt { get; set; } = string.Empty;

        [JsonPropertyName("maturity_date")]
        public string MaturityDate { get; set; } = string.Empty;
    }

    public class CustomIndexResponse
    {
        [JsonPropertyName("data")]
        public CustomIndexResponsePayload Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class UpdateCustomIndexAllocation
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_name")]
        public string AssetName { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("weight")]
        public double Weight { get; set; }
    }

    public class UpdateCustomIndexResponsePayload
    {
        [JsonPropertyName("index_id")]
        public string IndexId { get; set; } = string.Empty;

        [JsonPropertyName("is_user_created")]
        public bool IsUserCreated { get; set; }

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("allocations")]
        public List<UpdateCustomIndexAllocation> Allocations { get; set; } = new List<UpdateCustomIndexAllocation>();
    }

    public class UpdateCustomIndexResponse
    {
        [JsonPropertyName("data")]
        public UpdateCustomIndexResponsePayload Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class CustomIndexInputModel
    {
        [JsonPropertyName("allocations")]
        public List<UpdateIndexAllocation> Allocations { get; set; } = new List<UpdateIndexAllocation>();

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }

    public class UpdateIndexAllocation
    {
        public string AssetCode { get; set; } = string.Empty;

        public double Weight { get; set; }
    }

    public class UpdateCustomIndexInputModel
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("allocations")]
        public UpdateIndexAllocation Allocations { get; set; }
    }
}
