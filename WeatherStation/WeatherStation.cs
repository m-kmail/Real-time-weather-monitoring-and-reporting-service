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
            throw new NotImplementedException();
        }
        public void Remove(Iobserver bot)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void ReadWeatherData(string weatherdata)
        {
            IInputHandler? inputHandler = InputManager.GetInputHandler(weatherdata);
        }

    }
}
