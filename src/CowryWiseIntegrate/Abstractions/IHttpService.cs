using RestSharp;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Abstractions
{
    public interface IHttpService
    {
        Task<IRestClient> InitializeClient();
    }
}
