using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IObservable
    {
        public void Add(Iobserver bot);
        public void Remove(Iobserver bot);
        public void Notify();
    }
}
