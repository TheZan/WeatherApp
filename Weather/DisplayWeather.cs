using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Weather
{
    class DisplayWeather
    {
        public DisplayWeather(string city)
        {
            cityName = city;
        }
        string cityName { get; set; }
        WebClient client = new WebClient();
        GetWeather getWeather;
        public List<MainWeather> Get()
        {
            string api = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid=YOUR_API_KEY&lang=ru";

            var weatherData = client.DownloadString(api);
            getWeather = JsonConvert.DeserializeObject<GetWeather>(weatherData);
            List<MainWeather> mainWeathers = new List<MainWeather>();
            mainWeathers.Add(new MainWeather()
            {
                description = getWeather.weather[0].description,
                pressure = getWeather.main.pressure,
                speed = getWeather.wind.speed,
                temp = getWeather.main.temp,
                feels_like = getWeather.main.feels_like,
                humidity = getWeather.main.humidity
            });
            return mainWeathers;
        }
    }
    public class MainWeather
    {
        public string description { get; set; }
        public double pressure { get; set; }
        public double speed { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double humidity { get; set; }
    }
}
