namespace WeatherStation
{
    public class BotConfigeration
    {
        public bool Enabled { get; set; }
        public double HumidityThreshold { get; set; }
        public double TemperatureThreshold { get; set; }
        public string Message { get; set; }
    }
}
