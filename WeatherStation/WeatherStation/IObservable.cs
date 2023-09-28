using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IObservable
    {
        public void Add(IObserver bot);
        public void Remove(IObserver bot);
    }
}
