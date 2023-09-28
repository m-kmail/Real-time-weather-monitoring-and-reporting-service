using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IBot : Iobserver
    {
        public bool Activated { get; }
        public double? HumidityThreshold { get; }
        public double? TemperatureThreshold { get; }
        public string message { get; }
    }
}
