namespace WeatherStation
{
    public interface IObserver
    {
        public void Ubdate(WeatherData weatherData);
        public string Name { get; }
    }
}
