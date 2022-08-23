using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.Services
{
    public static class Communication
    {
        public static async Task<Weather> GetCity()
        {
            String city = "Maringá";
            Weather weatherResponse = new Weather();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org");
            var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid=3fb5d81f3bb184d558a14daa629db53a&units=metric");
            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();
            var rawWeather = JsonConvert.DeserializeObject<OpenWeatherApiResponse>(stringResult);
            weatherResponse.Max = rawWeather.Main.Temp_max;
            weatherResponse.Min = rawWeather.Main.Temp_min;
            weatherResponse.Actually = rawWeather.Main.Temp;
            weatherResponse.DateCache = DateTime.Now;
            weatherResponse.City = city;
            return weatherResponse;
        }
    }
}
