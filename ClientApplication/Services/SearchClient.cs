using ClientApplication.ExternalServices.ServerApplicationClient;

namespace ClientApplication.Services
{
    public interface ISearchClient
    {
        Search Client { get; }
    }

    public class SearchClient : ISearchClient
    {
        private readonly IServerApplicationService _serverApplicationService;

        public SearchClient(IServerApplicationService serverApplicationService)
        {
            _serverApplicationService = serverApplicationService;
            Client = new Search(_serverApplicationService.Client);
        }

        public Search Client { get; private set; }
    }
}