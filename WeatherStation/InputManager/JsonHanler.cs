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

            try
            {
                WeatherData? CurrentWeatherData = await Task.Run(() => JsonSerializer.Deserialize<WeatherData?>(weatherInputString, options));
                return CurrentWeatherData;
            }
            catch (Exception)
            {
                return await InputException();
            }
        }

        public async Task<WeatherData?> InputException()
        {
            Console.WriteLine(StandardMessages.InvalidInput());
            return await Task.FromResult<WeatherData?>(null);
        }
    }
}
