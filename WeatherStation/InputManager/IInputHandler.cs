using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IInputHandler
    {
        public Task<WeatherData?>? HandleInput(string weatherInputString);
    }
}
