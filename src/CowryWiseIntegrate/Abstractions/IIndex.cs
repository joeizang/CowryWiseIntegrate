using CowryWiseIntegrate.DTOs.Index;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Abstractions
{
    public interface IIndex
    {
        Task<IndexPaginatedResponse> GetIndexes(GetPaginatedResponseInputModel inputModel);

        Task<IndexAssetsResponse> GetIndexAssets(string indexId);

        Task<SingleIndexResponse> GetSingleIndex(string indexId);

        Task<CustomIndexResponse> CreateCustomIndex(CustomIndexInputModel inputModel);

        Task<UpdateCustomIndexResponse> UpdateCustomIndex(UpdateCustomIndexInputModel inputModel);
    }
}
