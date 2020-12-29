using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Controllers
{
    public enum Unit
    {
        Kelvin,
        Metric,
        Imperial
    }
    public class WeatherService : IOpenWeatherService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public WeatherService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public DateTime FromUnixTime(long unixTime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(unixTime);
            return dtDateTime;
        }
        public async Task<List<WeatherForecast>> GetFiveDayForecast(string location, Unit unit = Unit.Metric)
        {
            var ApiKey = "c4a6c9f7e0cbd69ee7330e1a380a9cd0";
            var url = $"https://api.openweathermap.org/data/2.5/forecast" +
                      $"?q={location}" +
                      $"&appid={ApiKey}" +
                      $"&units=metric";

            var forecasts = new List<WeatherForecast>();

            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            var openWeatherResponse = JsonSerializer.Deserialize<OpenWeatherResponse>(json);
            foreach (var forecast in openWeatherResponse.Forecasts)
            {
                forecasts.Add(new WeatherForecast
                {
                    Location = location,
                    Date = FromUnixTime(forecast.Dt),
                    Temp = forecast.Temps.Temp,
                    FeelsLike = forecast.Temps.FeelsLike,
                    TempMin = forecast.Temps.TempMin,
                    TempMax = forecast.Temps.TempMax
                });
            }
            return forecasts;
        }
    }
}
