namespace WeatherStation
{
    public abstract class BotManager
    {
        private enum AvailableBots
        {
            RainBot,
            SunBot,
            SnowBot
        }

        private static Dictionary<AvailableBots, string> BotsNames = new Dictionary<AvailableBots, string>()
        {
            {AvailableBots.RainBot, "RainBot" },
            {AvailableBots.SunBot, "SunBot" },
            {AvailableBots.SnowBot, "SnowBot" }
        };

        private static Dictionary<AvailableBots, Bot> BotsObjects = new Dictionary<AvailableBots, Bot>()
        {
            { AvailableBots.RainBot, new RainBot() },
            { AvailableBots.SunBot, new SunBot()},
            { AvailableBots.SnowBot, new SnowBot()}
        };

        public static async Task<List<Bot>?> GetAllBots()
        {
            Dictionary<string, BotConfigeration>? botsConfigerations = await ConfigerationManager.GetConfigerationData();

            if(botsConfigerations == null)
            {
                return await Task.FromResult<List<Bot>?>(null);
            }

            List<Bot> weatherBots = new List<Bot>();

            var availableBots = Enum.GetValues(typeof(AvailableBots)).Cast<AvailableBots>();

            foreach (var bot in availableBots)
            {
                BotsObjects[bot].ConfiguerBot(BotsNames[bot], botsConfigerations[BotsNames[bot]]);
                weatherBots.Add(BotsObjects[bot]);
            }

            return weatherBots;  
        }
    }
}
