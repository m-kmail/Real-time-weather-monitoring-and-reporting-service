using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class WeatherDataManager
    {
        public static async Task<WeatherData?> ProccessWeatherData(string rowWeatherData)
        {
            IInputHandler? inputHandler = GetAppropriateHandler(rowWeatherData);

            if (inputHandler == null)
                return await Task.FromResult<WeatherData?>(null);

            try
            {
                WeatherData? weatherData = await inputHandler.HandleInput(rowWeatherData);
                return weatherData;
            }
            catch (Exception)
            {
                Console.WriteLine(StandardMessages.InvalidInput());
                return await Task.FromResult<WeatherData?>(null);
            }
        }

        private static IInputHandler?  GetAppropriateHandler(string rowWeatherData)
        {
            IInputHandler? inputHandler = InputManager.GetInputHandler(rowWeatherData);

            if(inputHandler == null)
            {
                Console.WriteLine(StandardMessages.UnknownFormat());
            }

            return inputHandler;
        }
    }
}
