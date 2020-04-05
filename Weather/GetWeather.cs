using Newtonsoft.Json;

namespace Weather
{
    class GetWeather
    {
        public WeatherStatus[] weather { get; set; }

        [JsonProperty("base")]
        public string base1 { get; set; }
        public main main { get; set; }
        public Wind wind { get; set; }
    }

    class main
    {
        public double temp { get; set; }
        public double pressure { get; set; }
        public double feels_like { get; set; }
        public double humidity { get; set; }
    }

    class WeatherStatus
    {
        public string description { get; set; }
    }

    class Wind
    {
        public double speed { get; set; }
    }
}
