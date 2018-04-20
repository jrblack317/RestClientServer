using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using SeverApplication.Models;
using SeverApplication.Services;
using Swashbuckle.Swagger.Annotations;

namespace SeverApplication.Controllers
{
    [RoutePrefix("api")]
    public class SearchController : ApiController
    {
        private readonly BestExSearchService _bestExSearchService;
        public SearchController()
        {
            _bestExSearchService = new BestExSearchService();
        }

        [Route("searches/bestex")]
        [HttpPost]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<SearchResult>))]
        public async Task<IHttpActionResult> PerformBestExSearch([FromBody] SearchCriteria criteria)
        {
            var result = await _bestExSearchService.PerformSearch();
            return Ok(result);
        }
    }
}
