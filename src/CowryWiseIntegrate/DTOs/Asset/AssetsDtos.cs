using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate.DTOs.Asset
{
    public class AssetsPayload
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("is_indexable")]
        public bool IsIndexable { get; set; }

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("meta")]
        public AssetsMeta Meta { get; set; }
    }

    public class Price
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("buy_price")]
        public double BuyPrice { get; set; }

        [JsonPropertyName("sell_price")]
        public double SellPrice { get; set; }

        [JsonPropertyName("ytd")]
        public double Ytd { get; set; }
    }

    public class AssetsMeta
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("fund_manager")]
        public string FundManager { get; set; } = string.Empty;

        [JsonPropertyName("is_eurobond")]
        public bool IsEurobond { get; set; }

        [JsonPropertyName("is_bond")]
        public bool IsBond { get; set; }

        [JsonPropertyName("is_money_market_fund")]
        public bool IsMoneyMarketFund { get; set; }

        [JsonPropertyName("is_equity_fund")]
        public bool IsEquityFund { get; set; }

        [JsonPropertyName("price")]
        public Price Price { get; set; }
    }

    public class AssetsPaginatedResponseDto : DtoBase
    {
        [JsonPropertyName("pagination")]
        public ModelPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<AssetsPayload> Data { get; set; }

    }

    public class AssetsPaginatedResponseInput : GetPaginatedResponseInputModel
    {
        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;
    }

    public class SingleAssetsResponse : DtoBase
    {
        [JsonPropertyName("data")]
        public AssetsPayload Data { get; set; }

    }

    public class AssetPrice
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("buy_price")]
        public double BuyPrice { get; set; }

        [JsonPropertyName("sell_price")]
        public double SellPrice { get; set; }

        [JsonPropertyName("annual_returns")]
        public double AnnualReturns { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("fund_manager")]
        public string FundManager { get; set; } = string.Empty;

        [JsonPropertyName("is_eurobond")]
        public bool IsEurobond { get; set; }

        [JsonPropertyName("is_bond")]
        public bool IsBond { get; set; }

        [JsonPropertyName("is_money_market_fund")]
        public bool IsMoneyMarketFund { get; set; }

        [JsonPropertyName("is_equity_fund")]
        public bool IsEquityFund { get; set; }

        [JsonPropertyName("risk_class")]
        public string RiskClass { get; set; } = string.Empty;

        [JsonPropertyName("price")]
        public AssetPrice Price { get; set; }
    }

    public class SingleAssetData
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("is_indexable")]
        public bool IsIndexable { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class SingleAssetRoot
    {
        [JsonPropertyName("data")]
        public SingleAssetData Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class AssetsPaginatedDto : DtoBase
    {
        [JsonPropertyName("pagination")]
        public ModelPagination Pagination { get; set; }

        [JsonPropertyName("data")] public List<SingleAssetData> Data { get; set; }
    }

    public class AssetsTestPagination
    {
        [JsonPropertyName("next")]
        public string Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public object Previous { get; set; } = string.Empty;

        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class AssetsMetaDatumPrice
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("buy_price")]
        public double BuyPrice { get; set; }

        [JsonPropertyName("sell_price")]
        public double SellPrice { get; set; }

        [JsonPropertyName("annual_returns")]
        public double AnnualReturns { get; set; }

        [JsonPropertyName("ytd")]
        public double? Ytd { get; set; }
    }

    public class AssetsDatumMeta
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("fund_manager")]
        public string FundManager { get; set; } = string.Empty;

        [JsonPropertyName("is_eurobond")]
        public bool IsEurobond { get; set; }

        [JsonPropertyName("is_bond")]
        public bool IsBond { get; set; }

        [JsonPropertyName("is_money_market_fund")]
        public bool IsMoneyMarketFund { get; set; }

        [JsonPropertyName("is_equity_fund")]
        public bool IsEquityFund { get; set; }

        [JsonPropertyName("risk_class")]
        public string RiskClass { get; set; } = string.Empty;

        [JsonPropertyName("price")]
        public AssetsMetaDatumPrice Price { get; set; }
    }

    public class AssetsDatum
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("is_indexable")]
        public bool IsIndexable { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("asset_class")]
        public string AssetClass { get; set; } = string.Empty;

        [JsonPropertyName("meta")]
        public AssetsDatumMeta Meta { get; set; }
    }

    public class AssetsPaginatedResponse
    {
        [JsonPropertyName("pagination")]
        public AssetsTestPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<AssetsDatum> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}
