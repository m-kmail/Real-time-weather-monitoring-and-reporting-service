namespace WeatherStation
{
    public class SunBot : Bot
    {
        public SunBot() { }

        protected override bool IsTriggered(WeatherData weatherData)
        {
            if (!Activated) return false;

            if (weatherData.Temperature == null)
            {
                Console.WriteLine(StandardMessages.MissingField("Temperature"));
                return false;
            }

            return weatherData.Temperature > TemperatureThreshold;
        }
    }
}
