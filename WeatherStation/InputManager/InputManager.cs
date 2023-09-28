using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class InputManager
    {
        private enum AllowedFormats
        {
            JSON,
            XML
        }

        private static Dictionary<AllowedFormats, string> FormatIdentifier = new Dictionary<AllowedFormats, string>()
        {
            {AllowedFormats.JSON, "{" },
            {AllowedFormats.XML, "<" }
        };


        private static Dictionary<AllowedFormats, IInputHandler> _inputHandlers = new Dictionary<AllowedFormats, IInputHandler>()
        {
            { AllowedFormats.XML, new XmlHandler() },
            { AllowedFormats.JSON, new JsonHandler()}
        };

        public static IInputHandler? GetInputHandler(string InputWeatherData)
        {
            foreach (var handler in _inputHandlers.Keys)
            {
                if (InputWeatherData.StartsWith(FormatIdentifier[handler]))
                    return _inputHandlers[handler];
            }

            return null;
        }

        
        public static string GetAllowedInputFormats()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var Allowed = Enum.GetValues(typeof(AllowedFormats)).Cast<AllowedFormats>();

            foreach (var Format in Allowed)
            {
                stringBuilder.Append($"{Format}, ");
            }
            stringBuilder = stringBuilder.Remove(stringBuilder.Length - 2, 2);

            return stringBuilder.ToString();
        }
        
    }
}
