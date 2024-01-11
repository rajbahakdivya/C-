using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class WeatherServiceFacade : IWeatherServiceFacade
    {
        private readonly GeoLookupService _geoLookupService;
        private readonly WeatherService _weatherService;
        private readonly ConverterService _converterService;

        public WeatherServiceFacade()
        {
            _geoLookupService = new GeoLookupService();
            _weatherService = new WeatherService();
            _converterService = new ConverterService();
        }
        public double GetCurrentTemperatureByCity(string city)
        {

            var location = _geoLookupService.GetLocationByCity(city);
            var temperature = _weatherService.GetCurrentTemperature(location);
            return _converterService.ConvertFToC(temperature);
        }
    }

}
