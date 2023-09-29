namespace WeatherStation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           List<Bot>? bots = await BotManager.GetAllBots();

            WeatherStation station = new WeatherStation();

            bots.ForEach(bot=>station.Add(bot));

            while(true)
            {
                Console.WriteLine(StandardMessages.AskForInput());

                string? inputWeather = Console.ReadLine();

                while(string.IsNullOrWhiteSpace(inputWeather))
                {
                    Console.WriteLine(StandardMessages.AskForInput());

                    inputWeather = Console.ReadLine();
                }

                await station.ReadWeatherData(inputWeather);
            }
        }
    }
}