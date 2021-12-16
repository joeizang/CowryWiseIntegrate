using CowryWiseIntegrate.DTOs.Asset;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Abstractions
{
    public interface IAssetsService
    {
        Task<AssetsPaginatedResponse> GetAllAssets(AssetsPaginatedResponseInput inputModel);
        Task<SingleAssetRoot> GetSingleAsset(string id);
    }
}
