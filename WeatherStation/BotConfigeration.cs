using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class BotConfigeration
    {
        public bool Enabled { get; set; }
        public double HumidityThreshold { get; set; }
        public double TemperatureThreshold { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"enabled => {Enabled}, humidityThreshold => {HumidityThreshold}, temperatureThreshold => {TemperatureThreshold}, message => {Message}";
        }
    }
}
