using System.Net.Http;

namespace ClientApplication.ExternalServices.ServerApplicationClient
{
    public partial class ServerApplicationClient
    {
        // Create our own custom constructor so we can inject our own HttpClient into
        // ServiceClient.
        public ServerApplicationClient(HttpClient client)
        {
            this.HttpClient = client;
        }
    }
}