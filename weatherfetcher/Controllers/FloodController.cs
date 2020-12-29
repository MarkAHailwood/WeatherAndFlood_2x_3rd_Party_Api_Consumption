using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Controllers
{
    public class FloodController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IFloodService floodService;

        public FloodController(IHttpClientFactory httpClientFactory, IFloodService floodService)
        {
            this.httpClientFactory = httpClientFactory;
            this.floodService = floodService;
        }

        public IActionResult Blank()
        {
            return View();
        }
        public async Task<ActionResult<List<FloodSummary>>> Index(string County)
        {
            ViewBag.county = County;
            var floodResultSummary = await floodService.GetFloodForecast(County);

            return View(floodResultSummary);
        }
    }
}
