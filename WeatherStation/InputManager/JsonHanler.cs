using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class JsonHandler : IInputHandler
    {
        public async Task<WeatherData?> HandleInput(string weatherInputString)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            WeatherData? CurrentWeatherData = await Task.Run(() => JsonSerializer.Deserialize<WeatherData?>(weatherInputString,options));
            return CurrentWeatherData;
        }
    }
}
