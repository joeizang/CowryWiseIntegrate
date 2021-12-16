using CowryWiseIntegrate.Abstractions;
using CowryWiseIntegrate.DTOs.Asset;
using RestSharp;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Services
{
    public class AssetsService : IAssetsService
    {
        private readonly IHttpService _assetService;

        public AssetsService(IHttpService assetService)
        {
            _assetService = assetService;
        }
        public async Task<AssetsPaginatedResponse> GetAllAssets(AssetsPaginatedResponseInput inputModel)
        {
            IRestRequest request;

            request = new RestRequest($"/api/v1/assets", Method.GET);
            if (inputModel != null && string.IsNullOrEmpty(inputModel.Page) && string.IsNullOrEmpty(inputModel.PageSize)
                && string.IsNullOrEmpty(inputModel.Country) && string.IsNullOrEmpty(inputModel.AssetType))
            {
                var httpClient = await _assetService.InitializeClient().ConfigureAwait(false);
                var assetResult = await httpClient.ExecuteAsync<AssetsPaginatedResponse>(request)
                    .ConfigureAwait(false);
                return assetResult.Data;
            }
            if (inputModel != null && !string.IsNullOrEmpty(inputModel.Page) && string.IsNullOrEmpty(inputModel.PageSize)
                && string.IsNullOrEmpty(inputModel.Country) && string.IsNullOrEmpty(inputModel.AssetType))
            {
                request.AddParameter("page", inputModel.Page, ParameterType.GetOrPost);
            }
            var client = await _assetService.InitializeClient().ConfigureAwait(false);
            var result = await client.ExecuteAsync<AssetsPaginatedResponse>(request)
                .ConfigureAwait(false);
            return result.Data;
        }

        public async Task<SingleAssetRoot> GetSingleAsset(string id)
        {
            IRestRequest request = new RestRequest($"/api/v1/assets{id}", Method.GET);
            var client = await _assetService.InitializeClient().ConfigureAwait(false);
            var result = await client.ExecuteAsync<SingleAssetRoot>(request).ConfigureAwait(false);
            return result.Data;
        }

    }
}
