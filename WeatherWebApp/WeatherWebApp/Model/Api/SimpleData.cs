using Newtonsoft.Json;

namespace WeatherWebApp.Model.Api
{
    public class SimpleData
    {
        [JsonProperty("name")]
        public string Name { get; set;}
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
