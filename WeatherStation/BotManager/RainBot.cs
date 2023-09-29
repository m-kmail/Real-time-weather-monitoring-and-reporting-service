namespace WeatherStation
{
    public class RainBot : Bot
    {
        public RainBot() { }
       
        protected override bool IsTriggered(WeatherData weatherData)
        {
            if(!Activated) return false;

            if (weatherData.Humidity == null)
            {
                Console.WriteLine(StandardMessages.MissingField("Humidity"));
                return false;
            }

            return weatherData.Humidity > HumidityThreshold;
        }
    }
}
