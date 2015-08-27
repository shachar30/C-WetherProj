using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetherapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            WeatherInfo singleton = WeatherInfo.GetInstance(factory.getWeatherData(factory.platform));

            Console.Write(singleton);
        }
    }
}
