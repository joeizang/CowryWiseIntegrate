using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate.DTOs.Investment
{
    public class InvestmentActionPayload
    {
        [JsonPropertyName("investment_id")]
        public string InvestmentId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_in_index")]
        public bool AssetInIndex { get; set; }

        [JsonPropertyName("index_id")]
        public object IndexId { get; set; } = string.Empty;

        [JsonPropertyName("current_units")]
        public string CurrentUnits { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("current_value")]
        public string CurrentValue { get; set; } = string.Empty;

        [JsonPropertyName("investment_returns")]
        public string InvestmentReturns { get; set; } = string.Empty;

        [JsonPropertyName("change_today")]
        public string ChangeToday { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("pending_deposits")]
        public List<PendingDeposit> PendingDeposits { get; set; }

        [JsonPropertyName("pending_sales")]
        public List<PendingSale> PendingSales { get; set; }
    }

    public class InvestmentPaginatedResponseInput : GetPaginatedResponseInputModel
    {
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }
    }

    public class InvestmentPaginatedResponse
    {
        public ModelPagination Pagination { get; set; }

        public List<InvestmentActionPayload> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class SingleInvestmentResponseDto : DtoBase
    {
        public InvestmentActionPayload Data { get; set; }
    }

    public class CreateInvestmentInputModel
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("asset_code")]
        public string AssetCode { get; set; } = string.Empty;

        [JsonPropertyName("customer_Id")]
        public string CustomerId { get; set; } = string.Empty;

        [JsonPropertyName("sla_product_type")]
        public int ProductType { get; set; }
    }

    public class PendingDeposit
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        public string Amount { get; set; } = string.Empty;

        [JsonPropertyName("reference")]
        public string Reference { get; set; } = string.Empty;

        [JsonPropertyName("transaction_date")]
        public DateTime TransactionDate { get; set; }
    }

    public class PendingSale
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("units")]
        public double Units { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }
    }

    public class InvestmentLiquidatedPayload
    {
        [JsonPropertyName("investment_id")]
        public string InvestmentId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_in_index")]
        public bool AssetInIndex { get; set; }

        [JsonPropertyName("index_id")]
        public object IndexId { get; set; } = string.Empty;

        [JsonPropertyName("current_units")]
        public string CurrentUnits { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("current_value")]
        public string CurrentValue { get; set; } = string.Empty;

        [JsonPropertyName("investment_returns")]
        public string InvestmentReturns { get; set; } = string.Empty;

        [JsonPropertyName("change_today")]
        public string ChangeToday { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("pending_deposits")]
        public List<PendingDeposit> PendingDeposits { get; set; }

        [JsonPropertyName("pending_sales")]
        public List<PendingSale> PendingSales { get; set; }
    }

    public class InvestmentLiquidatedDto : DtoBase
    {
        [JsonPropertyName("data")]
        public InvestmentLiquidatedPayload Data { get; set; }
    }

    public class InvestmentPagination
    {
        [JsonPropertyName("next")]
        public object Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public object Previous { get; set; } = string.Empty;

        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class InvestmentDatumPayload
    {
        [JsonPropertyName("investment_id")]
        public string InvestmentId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;

        [JsonPropertyName("asset_in_index")]
        public bool AssetInIndex { get; set; }

        [JsonPropertyName("index_id")]
        public object IndexId { get; set; } = string.Empty;

        [JsonPropertyName("current_units")]
        public string CurrentUnits { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("current_value")]
        public string CurrentValue { get; set; } = string.Empty;

        [JsonPropertyName("investment_returns")]
        public string InvestmentReturns { get; set; } = string.Empty;

        [JsonPropertyName("change_today")]
        public string ChangeToday { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("pending_deposits")]
        public List<object> PendingDeposits { get; set; }

        [JsonPropertyName("pending_sales")]
        public List<object> PendingSales { get; set; }
    }

    public class InvestmentPaginatedDtoResponse
    {
        [JsonPropertyName("pagination")]
        public InvestmentPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<InvestmentDatumPayload> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}
