using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate.DTOs.Wallet
{
    public class WalletDto
    {
        [JsonPropertyName("wallet_id")]
        public string WalletId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("principal")]
        public string Principal { get; set; } = string.Empty;

        [JsonPropertyName("returns")]
        public string Returns { get; set; } = string.Empty;

        [JsonPropertyName("lifetime_returns")]
        public string LifetimeReturns { get; set; } = string.Empty;

        [JsonPropertyName("balance")]
        public string Balance { get; set; } = string.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }
    }

    public class WalletPaginatedResponseDto
    {
        [JsonPropertyName("pagination")]
        public ModelPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<WalletDto> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class SingleWalletResponse
    {
        [JsonPropertyName("data")]
        public WalletDto Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class CreateWalletInputModel
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; } = string.Empty;

        [JsonPropertyName("customer_Id")]
        public string CustomerId { get; set; } = string.Empty;
    }

    public class CreateWalletResponseDto
    {
        [JsonPropertyName("data")]
        public WalletDto Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class Amount
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public class Fee
    {
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; } = string.Empty;
    }

    public class SourceAsset
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        [JsonPropertyName("account_email")]
        public string AccountEmail { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;
    }

    public class DestinationAsset
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        [JsonPropertyName("account_email")]
        public string AccountEmail { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; } = string.Empty;
    }

    public class WalletPayloadData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        [JsonPropertyName("fee")]
        public Fee Fee { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("source_asset")]
        public SourceAsset SourceAsset { get; set; }

        [JsonPropertyName("destination_asset")]
        public DestinationAsset DestinationAsset { get; set; }

        [JsonPropertyName("transfer_type")]
        public string TransferType { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("transaction_date")]
        public DateTime TransactionDate { get; set; }
    }

    public class TransferFromWalletResponseDto
    {
        [JsonPropertyName("data")]
        public WalletPayloadData Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class TransferFromWalletDto
    {
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        public string Amount { get; set; } = string.Empty;
    }

    public class WalletRightPagination
    {
        [JsonPropertyName("next")]
        public object Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public string Previous { get; set; } = string.Empty;

        [JsonPropertyName("current_page")]
        public string CurrentPage { get; set; } = string.Empty;

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class WalletDatum
    {
        [JsonPropertyName("wallet_id")]
        public string WalletId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("principal")]
        public string Principal { get; set; } = string.Empty;

        [JsonPropertyName("returns")]
        public string Returns { get; set; } = string.Empty;

        [JsonPropertyName("lifetime_returns")]
        public string LifetimeReturns { get; set; } = string.Empty;

        [JsonPropertyName("balance")]
        public string Balance { get; set; } = string.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }
    }

    public class WalletDtoRoot
    {
        [JsonPropertyName("pagination")]
        public ModelPagination Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<WalletDatum> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class WalletPaginationMetadata
    {
        [JsonPropertyName("next")]
        public string Next { get; set; } = string.Empty;

        [JsonPropertyName("previous")]
        public string Previous { get; set; } = string.Empty;

        [JsonPropertyName("current_page")]
        public string CurrentPage { get; set; } = string.Empty;

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }

    public class WalletDataPayload
    {
        [JsonPropertyName("wallet_id")]
        public string WalletId { get; set; } = string.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = string.Empty;

        [JsonPropertyName("principal")]
        public string Principal { get; set; } = string.Empty;

        [JsonPropertyName("returns")]
        public string Returns { get; set; } = string.Empty;

        [JsonPropertyName("lifetime_returns")]
        public string LifetimeReturns { get; set; } = string.Empty;

        [JsonPropertyName("balance")]
        public string Balance { get; set; } = string.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = string.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; } = string.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }
    }

    public class WalletPaginatedDtoRoot
    {
        [JsonPropertyName("pagination")]
        public WalletPaginationMetadata Pagination { get; set; }

        [JsonPropertyName("data")]
        public List<WalletDataPayload> Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class WalletTransferPayload
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        public Amount Amount { get; set; }

        [JsonPropertyName("fee")]
        public Fee Fee { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("source_asset")]
        public SourceAsset SourceAsset { get; set; }

        [JsonPropertyName("destination_asset")]
        public DestinationAsset DestinationAsset { get; set; }

        [JsonPropertyName("transfer_type")]
        public string TransferType { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        [JsonPropertyName("transaction_date")]
        public DateTime TransactionDate { get; set; }
    }

    public class WalletTransferDtoRoot
    {
        [JsonPropertyName("data")]
        public WalletTransferPayload Data { get; set; }

        [JsonPropertyName("errors")]
        public object Errors { get; set; } = string.Empty;

        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }

    public class WalletTransferInputModel
    {
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = string.Empty;

        [JsonPropertyName("amount")]
        public string Amount { get; set; } = string.Empty;

        [JsonPropertyName("accountId")] public string AccountId { get; set; } = string.Empty;

        public string CustomerId { get; set; } = string.Empty;

        public string ProductType { get; set; } = string.Empty;
    }
}
