using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class BotConfigeration
    {
        public bool? enabled { get; set; }
        public double? humidityThreshold { get; set; }
        public double? temperatureThreshold { get; set; }
        public string? message { get; set; }

        public override string ToString()
        {
            return $"enabled => {enabled}, humidityThreshold => {humidityThreshold}, temperatureThreshold => {temperatureThreshold}, message => {message}";
        }
    }
}
