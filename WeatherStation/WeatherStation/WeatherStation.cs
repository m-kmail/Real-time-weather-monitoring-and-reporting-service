using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherStation : IObservable
    {
        private WeatherData? weatherData;
        private List<IObserver> WeatherBots = new();
        public void Add(IObserver bot)
        {
            bool existed = WeatherBots.Any(weatherBot => weatherBot.Name == bot.Name);

            if (!existed)
            {
                WeatherBots.Add(bot);
            }
        }
        public void Remove(IObserver bot)
        {
            WeatherBots.Remove(bot);
        }

        private void Notify()
        {
            foreach (IObserver bot in WeatherBots)
                bot.Ubdate(weatherData!);
        }

        public async Task ReadWeatherData(string rowWeatherdata)
        {

            WeatherData? currentWeatherData = await WeatherDataManager.ProccessWeatherData(rowWeatherdata);

            if (currentWeatherData != null)
            {
                weatherData = currentWeatherData;
                Notify();
            }
        }

    }
}
