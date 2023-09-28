using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class StandardMessages
    {
        private static string? allowedFormats = InputManager.GetAllowedInputFormats();

        public static string InvalidInput() => @$"An error has occured while parsing the input, 
                       Please make sure you're following one of the allowed formats Which are: {allowedFormats}";

        public static string UnknownFormat() => 
            $"Unknown Format, Please make sure you're using one of the allowed formats Which are: {allowedFormats}";
    }
}
