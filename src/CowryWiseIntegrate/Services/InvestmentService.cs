using CowryWiseIntegrate.Abstractions;
using CowryWiseIntegrate.DTOs.Investment;
using CowryWiseIntegrate.DTOs.Wallet;
using RestSharp;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Services
{
    public class InvestmentService : IInvestmentService
    {
        private readonly IHttpService _service;

        public InvestmentService(IHttpService service)
        {
            _service = service;
        }

        public async Task<SingleInvestmentResponseDto> CreateInvestment(CreateInvestmentInputModel inputModel)
        {
            var request = new RestRequest("/api/v1/investments", Method.POST);
            request.AddParameter("account_id", inputModel.AccountId, ParameterType.GetOrPost);
            request.AddParameter("asset_code", inputModel.AssetCode, ParameterType.GetOrPost);
            var client = await _service.InitializeClient().ConfigureAwait(false);
            var result = await client
                .ExecuteAsync<SingleInvestmentResponseDto>(request)
                .ConfigureAwait(false);

            return result.Data;
        }

        public async Task<InvestmentPaginatedDtoResponse> GetAllInvestments(InvestmentPaginatedResponseInput inputModel)
        {
            var request = new RestRequest("/api/v1/investments", Method.GET);
            if (inputModel != null && string.IsNullOrEmpty(inputModel.Page) && string.IsNullOrEmpty(inputModel.PageSize)
                && string.IsNullOrEmpty(inputModel.AssetType))
            {
                var clientHttp = await _service.InitializeClient().ConfigureAwait(false);
                var resultPayload = await clientHttp
                    .ExecuteAsync<InvestmentPaginatedDtoResponse>(request)
                    .ConfigureAwait(false);
                return resultPayload.Data;
            }
            //request.AddParameter("asset_type", inputModel.AssetType, ParameterType.GetOrPost);
            //request.AddParameter("page", inputModel.Page, ParameterType.GetOrPost);
            request.AddParameter("page_size", inputModel.PageSize, ParameterType.GetOrPost);
            var client = await _service.InitializeClient().ConfigureAwait(false);
            var result = await client
                .ExecuteAsync<InvestmentPaginatedDtoResponse>(request)
                .ConfigureAwait(false);
            return result.Data;
        }

        public async Task<TransferFromWalletResponseDto> FundInvestment(WalletTransferInputModel inputModel)
        {
            var request = new RestRequest($"/api/v1/investments/{inputModel.AccountId}/transfer", Method.POST);
            request.AddParameter("product_code", inputModel.ProductCode, ParameterType.GetOrPost);
            request.AddParameter("amount", inputModel.Amount, ParameterType.GetOrPost);
            var client = await _service.InitializeClient().ConfigureAwait(false);
            var result = await client
                .ExecuteAsync<TransferFromWalletResponseDto>(request)
                .ConfigureAwait(false);

            return result.Data;
        }

        public async Task<InvestmentLiquidatedDto> LiquidateInvestment(string units, string investmentId, string accountId, string customerId)
        {
            var request = new RestRequest($"/api/v1/investments/{investmentId}/liquidate", Method.POST);
            request.AddParameter("units", units, ParameterType.GetOrPost);
            var client = await _service.InitializeClient().ConfigureAwait(false);
            var result = await client
                .ExecuteAsync<InvestmentLiquidatedDto>(request)
                .ConfigureAwait(false);

            return result.Data;
        }

        public async Task<SingleInvestmentResponseDto> GetSingleInvestment(string investmentId)
        {
            var request = new RestRequest($"/api/v1/investments/{investmentId}", Method.GET);
            var client = await _service.InitializeClient().ConfigureAwait(false);
            var result = await client
                .ExecuteAsync<SingleInvestmentResponseDto>(request)
                .ConfigureAwait(false);
            return result.Data;
        }
    }
}
