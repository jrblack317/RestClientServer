using System;
using System.Threading.Tasks;

namespace ClientApplication.Services
{
    public interface ITokenManager
    {
        Task<string> RetrieveBearerToken(string resource);
    }

    public class TokenManager : ITokenManager
    {
        // Token caching class, used to pass to methods in Rest Client
        public async Task<string> RetrieveBearerToken(string resource)
        {
            await Task.Delay(500);
            return Guid.NewGuid().ToString();
        }
    }
}