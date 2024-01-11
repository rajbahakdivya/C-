using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class WeatherService
    {
        public double GetCurrentTemperature(Location location) => new Random().Next(10, 50);
    }

    public class ConverterService
    {
        public double ConvertFToC(double f) => (f - 32) * 5 / 9;
    }
}
