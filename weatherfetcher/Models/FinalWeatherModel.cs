using System;

namespace weatherfetcher.Models
{
    public class FinalWeatherModel
    {
        public DateTime Date { get; set; }
        public decimal Temp { get; set; }
        public decimal FeelsLike { get; set; }
        public decimal TempMin { get; set; }
        public decimal TempMax { get; set; }
    }
}