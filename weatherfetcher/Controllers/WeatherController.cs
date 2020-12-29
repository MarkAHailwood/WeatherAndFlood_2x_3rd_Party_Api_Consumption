using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using weatherfetcher.Controllers;
using weatherfetcher.Models;

namespace weatherfecther.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IOpenWeatherService _openWeatherService;

        public WeatherController(IHttpClientFactory clientFactory, IOpenWeatherService openWeatherService)
        {
            _clientFactory = clientFactory;
            _openWeatherService = openWeatherService;
        }

        public async Task<ActionResult<List<WeatherForecast>>> Index(WeatherForecast forecastLocation)
        {
            var forecast =  await _openWeatherService.GetFiveDayForecast(forecastLocation.Location);

            ViewBag.returnUrl = "https://localhost:44336/Weather/Blank";

            return View(forecast);
        }

        public IActionResult Blank()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}