using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WeatherStation
{
    public class XmlHandler : IInputHandler
    {
        public async Task<WeatherData?> HandleInput(string weatherInputString)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(WeatherData));
            StringReader rdr = new StringReader(weatherInputString);

            try
            {
                WeatherData? CurrentWeatherData = await Task.Run(() => (WeatherData?)serializer.Deserialize(rdr));
                return CurrentWeatherData;
            }
            catch (Exception)
            {
                return await InputException();
            }
        }

        public async Task<WeatherData?> InputException()
        {
            Console.WriteLine(StandardMessages.InvalidInput());
            return await Task.FromResult<WeatherData?>(null);
        }
    }
}
