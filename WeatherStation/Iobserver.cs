using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface Iobserver
    {
        public void Ubdate(WeatherData weatherData);
        public string Name { get; }
    }
}
