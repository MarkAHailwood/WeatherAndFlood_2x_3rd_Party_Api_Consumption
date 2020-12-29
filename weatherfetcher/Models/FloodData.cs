using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace weatherfetcher.Models
{
    public class FloodData
    {
        [JsonProperty("@context")]
        public string Context { get; set; }
        public Meta meta { get; set; }
        public List<Item> items { get; set; }
    }
    public class Meta
    {
        public string publisher { get; set; }
        public string licence { get; set; }
        public string documentation { get; set; }
        public string version { get; set; }
        public string comment { get; set; }
        public List<string> hasFormat { get; set; }
    }

    public class FloodArea
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string county { get; set; }
        public string notation { get; set; }
        public string polygon { get; set; }
        public string riverOrSea { get; set; }
    }

    public class Item
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string description { get; set; }
        public string eaAreaName { get; set; }
        public string eaRegionName { get; set; }
        public FloodArea floodArea { get; set; }
        public string floodAreaID { get; set; }
        public bool isTidal { get; set; }
        public string message { get; set; }
        public string severity { get; set; }
        public int severityLevel { get; set; }
        public DateTime timeMessageChanged { get; set; }
        public DateTime timeRaised { get; set; }
        public DateTime timeSeverityChanged { get; set; }
    }
}

//public class FloodData
//{
//    [JsonPropertyName("@context")]
//    public string Context { get; set; }
//    [JsonPropertyName("meta")]
//    public List<Meta> Meta { get; set; }
//    [JsonPropertyName("items")]
//    public List<Items> Items { get; set; }
//}
//public class Meta
//{
//    [JsonPropertyName("publisher")]
//    public string publisher { get; set; }
//    [JsonPropertyName("licence")]
//    public string licence { get; set; }
//    [JsonPropertyName("documentation")]
//    public string documentation { get; set; }
//    [JsonPropertyName("version")]
//    public string version { get; set; }
//    [JsonPropertyName("comment")]
//    public string comment { get; set; }
//    [JsonPropertyName("hasFormat")]
//    public List<string> hasFormat { get; set; }
//}
//public class Items
//{
//    [JsonPropertyName("@id")]
//    public string Id { get; set; }
//    [JsonPropertyName("description")]
//    public string description { get; set; }
//    [JsonPropertyName("eaAreaName")]
//    public string eaAreaName { get; set; }
//    [JsonPropertyName("eaRegionName")]
//    public string eaRegionName { get; set; }
//    [JsonPropertyName("floodArea")]
//    public List<FloodArea> floodArea { get; set; }
//    [JsonPropertyName("floodAreaID")]
//    public string floodAreaID { get; set; }
//    [JsonPropertyName("isTidal")]
//    public string isTidal { get; set; }
//    [JsonPropertyName("message")]
//    public string message { get; set; }
//    [JsonPropertyName("severity")]
//    public string severity { get; set; }
//    [JsonPropertyName("severityLevel")]
//    public int severityLevel { get; set; }
//    [JsonPropertyName("timeMessageChanged")]
//    public string timeMessageChanged { get; set; }
//    [JsonPropertyName("timeRaised")]
//    public string timeRaised { get; set; }
//    [JsonPropertyName("timeSeverityChanged")]
//    public string timeSeverityChanged { get; set; }
//}
//public class FloodArea
//{
//    [JsonPropertyName("@id")]
//    public string @id { get; set; }
//    [JsonPropertyName("county")]
//    public string county { get; set; }
//    [JsonPropertyName("notation")]
//    public string notation { get; set; }
//    [JsonPropertyName("polygon")]
//    public string polygon { get; set; }
//    [JsonPropertyName("riverOrSea")]
//    public string riverOrSea { get; set; }

//}