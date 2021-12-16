using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CowryWiseIntegrate.DTOs.Account
{
    public class AddressUpdateInputModel
    {
        public string AccountID { get; set; } = String.Empty;
        public string Street { get; set; } = String.Empty;
        public string Lga { get; set; } = String.Empty;
        public string AreaCode { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
    }

    public class AccountNextOfKinInputModel
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; } = String.Empty;
        [JsonPropertyName("last_name")]
        public string LastName { get; set; } = String.Empty;
        [JsonPropertyName("gender")]
        public string Email { get; set; } = String.Empty;
        [JsonPropertyName("gender")]
        public string Gender { get; set; } = String.Empty;
        [JsonPropertyName("relationship")]
        public string Relationship { get; set; } = String.Empty;
        [JsonPropertyName("phonenumber")]
        public string PhoneNumber { get; set; } = String.Empty;
        [JsonPropertyName("accountId")]
        public string AccountID { get; set; } = String.Empty;
    }

    public class UpdateProfileInputModel
    {
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; } = String.Empty;

        [JsonPropertyName("lastname")]
        public string LastName { get; set; } = String.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = String.Empty;

        [JsonPropertyName("gender")]
        public string Gender { get; set; } = String.Empty;

        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; } = String.Empty;

        [JsonPropertyName("accountId")]
        public string AccountID { get; set; } = String.Empty;

        [JsonPropertyName("date_of_birth")]
        public string DateOfBirth { get; set; } = String.Empty;
    }

    public class UpdateIdentityInputModel
    {
        [JsonPropertyName("identity_type")]
        public string IdentityType { get; set; } = String.Empty;

        [JsonPropertyName("identity_value")]
        public string IdentityValue { get; set; } = String.Empty;

        [JsonPropertyName("accountId")]
        public string AccountID { get; set; } = String.Empty;
    }

    public class IdentityUpdatePayload
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = String.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = String.Empty;

        [JsonPropertyName("value")]
        public string Value { get; set; } = String.Empty;

        [JsonPropertyName("verification_status")]
        public string VerificationStatus { get; set; } = String.Empty;
    }

    public class AccountIdentityResponse : DtoBase
    {
        [JsonPropertyName("data")]
        public IdentityUpdatePayload Data { get; set; }
    }

    public class AddBankInputModel
    {
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; } = String.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = String.Empty;

        [JsonPropertyName("accountId")]
        public string AccountID { get; set; } = String.Empty;
    }

    public class AccountBankUpdatePayload
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = String.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = String.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = String.Empty;

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; } = String.Empty;

        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; } = String.Empty;
    }

    public class AccountBankUpdateResponse : DtoBase
    {
        [JsonPropertyName("data")]
        public AccountBankUpdatePayload Data { get; set; }
    }

    public class CreateAccountInputModel
    {
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;
    }

    public class GetById
    {
        public string Id { get; set; } = String.Empty;
    }

    public class Address
    {
        public string Street { get; set; } = String.Empty;

        public string Lga { get; set; } = String.Empty;

        public string AreaCode { get; set; } = String.Empty;

        public string City { get; set; } = String.Empty;

        public string State { get; set; } = String.Empty;

        public string Country { get; set; } = String.Empty;
    }

    public class NextOfKin
    {
        public string FirstName { get; set; } = String.Empty;

        public string LastName { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string PhoneNumber { get; set; } = String.Empty;

        public string Relationship { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;
    }

    public class AccountCreationPayload
    {
        [JsonPropertyName("account_id")] public string AccountId { get; set; } = String.Empty;

        [JsonPropertyName("account_number")] public int AccountNumber { get; set; }

        [JsonPropertyName("first_name")] public string FirstName { get; set; } = String.Empty;

        [JsonPropertyName("last_name")] public string LastName { get; set; } = String.Empty;

        [JsonPropertyName("email")] public string Email { get; set; } = String.Empty;

        [JsonPropertyName("risk_appetite")] public int RiskAppetite { get; set; }

        [JsonPropertyName("is_proprietary")] public bool IsProprietary { get; set; }

        [JsonPropertyName("account_status")] public string AccountStatus { get; set; } = String.Empty;

        [JsonPropertyName("verification_status")] public string VerificationStatus { get; set; } = String.Empty;

        [JsonPropertyName("is_verified")] public bool IsVerified { get; set; }

        [JsonPropertyName("account_type")] public string AccountType { get; set; } = String.Empty;

        [JsonPropertyName("phone_number")] public object PhoneNumber { get; set; } = String.Empty;

        [JsonPropertyName("date_of_birth")] public object DateOfBirth { get; set; }

        [JsonPropertyName("gender")] public object Gender { get; set; } = String.Empty;

        [JsonPropertyName("identifications")] public List<object> Identifications { get; set; }

        [JsonPropertyName("banks")] public List<object> Banks { get; set; }

        [JsonPropertyName("address")] public Address Address { get; set; }

        [JsonPropertyName("next_of_kin")] public NextOfKin NextOfKin { get; set; }

        [JsonPropertyName("date_joined")] public DateTime DateJoined { get; set; }
    }

    public class Balance
    {
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = String.Empty;

        [JsonPropertyName("value")]
        public string Value { get; set; } = String.Empty;

        [JsonPropertyName("portfolio_returns")]
        public string PortfolioReturns { get; set; } = String.Empty;
    }

    public class AccountWallet
    {
        [JsonPropertyName("wallet_id")]
        public string WalletId { get; set; } = String.Empty;

        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = String.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = String.Empty;

        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; } = String.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; set; } = String.Empty;

        [JsonPropertyName("principal")]
        public string Principal { get; set; } = String.Empty;

        [JsonPropertyName("returns")]
        public string Returns { get; set; } = String.Empty;

        [JsonPropertyName("lifetime_returns")]
        public string LifetimeReturns { get; set; } = String.Empty;

        [JsonPropertyName("balance")]
        public string Balance { get; set; } = String.Empty;

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; } = String.Empty;

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; } = String.Empty;

        [JsonPropertyName("bank_name")]
        public string BankName { get; set; } = String.Empty;

        [JsonPropertyName("created_on")]
        public DateTime CreatedOn { get; set; }
    }

    public class AccountAssets
    {
        [JsonPropertyName("wallets")]
        public List<AccountWallet> Wallets { get; set; }

        [JsonPropertyName("savings")]
        public List<object> Savings { get; set; }

        [JsonPropertyName("indexes")]
        public List<object> Indexes { get; set; }

        [JsonPropertyName("mutual_funds")]
        public List<object> MutualFunds { get; set; }

        [JsonPropertyName("treasury_bills")]
        public List<object> TreasuryBills { get; set; }

        [JsonPropertyName("stocks")]
        public List<object> Stocks { get; set; }
    }

    public class AccountPortfolioPayload
    {
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; } = String.Empty;

        [JsonPropertyName("balance")]
        public List<Balance> Balance { get; set; }

        [JsonPropertyName("assets")]
        public AccountAssets Assets { get; set; }
    }

    public class AccountPortfolioResponse : DtoBase
    {
        [JsonPropertyName("data")]
        public AccountPortfolioPayload Data { get; set; }
    }



    public class AccountCreationResponse : DtoBase
    {
        [JsonPropertyName("data")] public AccountCreationPayload Data { get; set; }
    }
}
