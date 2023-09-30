using System.Text.Json;

namespace WeatherStation
{
    public abstract class ConfigerationManager
    {
        private static string FilePath = "BotsConfigeration.json";

        public static async Task<Dictionary<string, BotConfigeration>?> GetConfigerationData()
        {
            Dictionary<string, BotConfigeration>? botsConfigerations = await ReadConfigerationFile();

            return botsConfigerations;
        }
        private static async Task<Dictionary<string, BotConfigeration>?> ReadConfigerationFile()
        {
            try
            {
                string json = File.ReadAllText(FilePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                Dictionary<string, BotConfigeration>? botsConfigerations =
                         await Task.Run(() => JsonSerializer.Deserialize<Dictionary<string, BotConfigeration>>(json,options));

                return botsConfigerations;
            }
            catch (Exception)
            {
                Console.WriteLine(StandardMessages.ConfigerationFileError());
                throw new FileLoadException();
            }

        }
    }
}
