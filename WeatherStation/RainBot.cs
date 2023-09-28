using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class RainBot : IBot
    {
        public bool Activated { get; private set; }

        public double HumidityThreshold { get; private set; }

        public double TemperatureThreshold { get; private set; }

        public string Message { get; private set; }

        public string Name { get; private set; }

        public RainBot(string name, BotConfigeration configeration)
        {
            Name = name;
            HumidityThreshold = configeration.HumidityThreshold;
            TemperatureThreshold = configeration.TemperatureThreshold;
            Activated = configeration.Enabled;
            Message = configeration.Message;
        }
        public void Ubdate(WeatherData weatherData)
        {
            if(IsTriggered(weatherData))
            {
                Console.WriteLine(StandardMessages.BotActivationMessage(Name, Message!));
            }
        }

        private bool IsTriggered(WeatherData weatherData)
        {
            if(!Activated) return false;

            if (weatherData.Humidity == null)
            {
                Console.WriteLine(StandardMessages.MissingField("Humidity"));
                return false;
            }

            return HumidityThreshold > weatherData.Humidity;
        }
    }
}
