using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTwentyOne.Models
{
    public class Weather
    {
        private Task<Weather> task;

        public Weather(Task<Weather> task)
        {
            this.task = task;
        }

        public int ID { get; set; }
        public string City { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Actually { get; set; }
        public DateTime DateCache { get; set; }
    }
}
