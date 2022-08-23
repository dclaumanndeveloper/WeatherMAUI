using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTwentyOne.Models
{
    internal class OpenWeatherApiResponse
    {
            public string Name { get; set; }

            public IEnumerable<WeatherDescription> Weather { get; set; }

            public Main Main { get; set; }
        }

        public class WeatherDescription
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }

        public class Main
        {
            public string Temp { get; set; }
            public string Temp_max { get; set; }
            public string Temp_min { get; set; }
        }
    
}
