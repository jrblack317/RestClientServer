using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using SeverApplication.Models;

namespace SeverApplication.Services
{
    public class BestExSearchService
    {
        private readonly IFixture _fixture;

        public BestExSearchService()
        {
            _fixture = new Fixture();
        }

        public async Task<IEnumerable<SearchResult>> PerformSearch()
        {
            await Task.Delay(500);

            var searchResults = new List<SearchResult>
            {
                _fixture.Build<SearchResult>()
                    .With(s => s.ExportType, null)
                    .With(s => s.Export, null)
                    .With(s => s.YearsActive, null)
                    .Create(),


            };
            searchResults.AddRange(_fixture.CreateMany<SearchResult>(9));

            return searchResults;
        }
    }
}