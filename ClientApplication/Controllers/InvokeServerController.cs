using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using AutoFixture;
using ClientApplication.ExternalServices.ServerApplicationClient.Models;
using ClientApplication.Services;
using Swashbuckle.Swagger.Annotations;

namespace ClientApplication.Controllers
{
    [RoutePrefix("api")]
    public class InvokeServerController : ApiController
    {

        private readonly IFixture _fixture = new Fixture();
        private readonly ISearchClient _searchClient;
        private readonly ITokenManager _tokenManager;

        public InvokeServerController(ISearchClient searchClient, ITokenManager tokenManager)
        {
            _tokenManager = tokenManager;
            _searchClient = searchClient;
        }

        [Route("invokeserver")]
        [HttpGet]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<SearchResult>))]
        public async Task<IHttpActionResult> InvokeServerClient()
        {
            var searchCriteria = _fixture.Create<SearchCriteria>();
            var results = await _searchClient.Client.PerformBestExSearchWithHttpMessagesAsync(searchCriteria,
                new Dictionary<string, List<string>>
                {
                    { "Authorization", new List<string> { $"Bearer { await _tokenManager.RetrieveBearerToken(string.Empty)}"} }
                });
            return Ok(results);
        }
    }
}
