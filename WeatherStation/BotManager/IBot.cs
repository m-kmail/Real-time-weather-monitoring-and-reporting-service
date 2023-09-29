

namespace WeatherStation
{
    public interface IBot : IObserver
    {
        public bool Activated { get; }
        public double HumidityThreshold { get; }
        public double TemperatureThreshold { get; }
        public string Message { get; }
    }
}
