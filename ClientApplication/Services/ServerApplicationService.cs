using System;
using System.Net.Http;
using ClientApplication.ExternalServices.ServerApplicationClient;

namespace ClientApplication.Services
{
    public interface IServerApplicationService
    {
        ServerApplicationClient Client { get; }
    }

    public class ServerApplicationService : IServerApplicationService
    {
        private static readonly Uri _baseUri = new Uri("http://localhost:49172");

        public ServerApplicationService()
        {
            Client = new ServerApplicationClient(new HttpClient { BaseAddress = _baseUri })
            {
                BaseUri = _baseUri
            };
        }

        public ServerApplicationClient Client { get; private set; }
    }
}