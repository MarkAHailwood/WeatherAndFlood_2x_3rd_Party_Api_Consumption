using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace weatherfetcher.Models
{
    public class OpenWeatherResponse
    {
        [JsonPropertyName("list")]
        public List<Forecast> Forecasts { get; set; }
    }
    public class Forecast
    {
        [JsonPropertyName("dt")]
        public int Dt { get; set; }
        [JsonPropertyName("main")]
        public Temps Temps { get; set; }
    }
    public class Temps
    {
        [JsonPropertyName("temp")]
        public decimal Temp { get; set; }
        [JsonPropertyName("feels_like")]
        public decimal FeelsLike { get; set; }
        [JsonPropertyName("temp_min")]
        public decimal TempMin { get; set; }
        [JsonPropertyName("temp_max")]
        public decimal TempMax { get; set; }
    }
}
