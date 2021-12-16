using CowryWiseIntegrate.Configuration;
using System.Threading.Tasks;

namespace CowryWiseIntegrate.Abstractions
{
    public interface IAuthenticationService
    {
        Task<IAuthenticationService> GetApiToken();

        Task RefreshToken();

        ApiToken ApiToken { get; }
    }
}
