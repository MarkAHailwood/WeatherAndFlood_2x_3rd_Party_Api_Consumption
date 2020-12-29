using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Controllers
{
    public interface IOpenWeatherService
    {
        Task<List<WeatherForecast>> GetFiveDayForecast(string location, Unit unit = Unit.Metric);
    }
}
