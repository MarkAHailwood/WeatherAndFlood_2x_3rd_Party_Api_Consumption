using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherfetcher.Models;

namespace weatherfetcher.Models
{
    public class WeatherViewModel
    {
        public FinalWeatherModel[] Weathers { get; set; }
    }
}
