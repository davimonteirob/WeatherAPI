using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    internal class WeatherResponse
    {
        public MainInfo Main { get; set; }
        public Weather[] Weather { get; set; }
    }
}
