namespace WeatherStation
{
    public abstract class Bot : IBot
    {
        public bool Activated { get; private set; }
        public double HumidityThreshold { get; private set; }
        public double TemperatureThreshold { get; private set; }
        public string Message { get; private set; }
        public string Name { get; private set; }
        public Bot() { }
        public void ConfiguerBot(string name, BotConfigeration configeration)
        {
            Name = name;
            HumidityThreshold = configeration.HumidityThreshold;
            TemperatureThreshold = configeration.TemperatureThreshold;
            Activated = configeration.Enabled;
            Message = configeration.Message;
        }
        public void Ubdate(WeatherData weatherData)
        {
            if (IsTriggered(weatherData))
            {
                Console.WriteLine(StandardMessages.BotActivationMessage(Name, Message!));
            }
        }
        protected abstract bool IsTriggered(WeatherData weatherData);
       
    }
}
