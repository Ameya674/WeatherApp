using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class WeatherInformation
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather 
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }

        public class main
        {
            public float temp { get; set; }
            public float temp_min { get; set; }
            public float temp_max { get; set; }
            public float pressure { get; set; }
            public float humidity { get; set; }
            public float sea_level { get; set; }
            public float grnd_level { get; set; }

        }

        public class wind
        {
            public float speed { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }
            public List <weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }

        }

    }
}
