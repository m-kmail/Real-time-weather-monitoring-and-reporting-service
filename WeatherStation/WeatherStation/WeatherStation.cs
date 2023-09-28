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
        private List<Iobserver> WeatherBots = new();
        public void Add(Iobserver bot)
        {
            bool existed = WeatherBots.Any(weatherBot => weatherBot.Name == bot.Name);

            if (!existed)
            {
                WeatherBots.Add(bot);
            }
        }
        public void Remove(Iobserver bot)
        {
            WeatherBots.Remove(bot);
        }

        private void Notify()
        {
            foreach (Iobserver bot in WeatherBots)
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
