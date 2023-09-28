using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class InputManager
    {
        private Dictionary<string, IInputHandler> _inputHandlers = new Dictionary<string, IInputHandler>()
        {
            { "<", new XmlHandler() },
            { "{", new JsonHandler()}
        };
        public IInputHandler? GetInputHandler(string InputWeatherData)
        {
            foreach (var handler in _inputHandlers.Keys)
            {
                if (InputWeatherData.StartsWith(handler))
                    return _inputHandlers[handler];
            }

            return null;
        }
    }
}
