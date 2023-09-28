using System;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeatherStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string json = File.ReadAllText(@"D:\_Foothil\Real-time-weather-monitoring-and-reporting-service\WeatherStation\WeatherStation\BotsConfigeration.json");
            var bots = JsonSerializer.Deserialize<Dictionary<string, BotConfigeration>>(json);

            foreach(var x in bots!.Keys)
            {
                Console.WriteLine(x);
                Console.WriteLine(bots[x]);
            }
        }
    }
}