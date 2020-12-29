using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Controllers
{
    public class FloodService : IFloodService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public FloodService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }
        public async Task<List<FloodSummary>> GetFloodForecast(string location)
        {
            var forecasts = new List<FloodSummary>();
            try
            {
                var url = $"http://environment.data.gov.uk/flood-monitoring/id/floods?county={location}";

                var client = httpClientFactory.CreateClient();
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
                var floodResponse = JsonSerializer.Deserialize<FloodData>(json);
                if(floodResponse.items.Count < 1)
                {
                    forecasts.Add(new FloodSummary
                    {
                        Description = "",
                        AreaName = "",
                        Message = "No flood data for this county",
                        SeverityLevel = 0
                    });
                }
                else
                {
                    foreach (var singleItem in floodResponse.items)
                    {
                        forecasts.Add(new FloodSummary
                        {
                            Description = singleItem.description,
                            AreaName = singleItem.eaAreaName,
                            Message = singleItem.message,
                            SeverityLevel = singleItem.severityLevel
                        });
                    }
                }                
            }
            catch (Exception)
            {
                throw new Exception("Failed and caught");
            }

            return forecasts;
        }
    }
}
