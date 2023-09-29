namespace WeatherStation
{
    public class SnowBot : Bot
    {
        public SnowBot() { }
       
        protected override bool IsTriggered(WeatherData weatherData)
        {
            if (!Activated) return false;

            if (weatherData.Temperature == null)
            {
                Console.WriteLine(StandardMessages.MissingField("Temperature"));
                return false;
            }

            return weatherData.Temperature < TemperatureThreshold;
        }
    }
}
