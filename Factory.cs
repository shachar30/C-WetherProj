using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Wetherapp
{
    public class Factory : IWeatherDataService
    {

        public string platform = "OPEN_WEATHER_MAP";
        public Location location { get; set; }

        public Factory()
        {
            double lat = 52.5243700, lng = 13.4105300;
            location = new Location(lat, lng);
        }

        public WeatherInfo getWeatherData(string api)
        {
            var json = "";

            if ("OPEN_WEATHER_MAP".Equals(api))
            {
                WebClient w = new WebClient();
                try
                {

                    json = w.DownloadString("http://api.openweathermap.org/data/2.5/weather?lat=" + location.lat.ToString() + "&lon=" + location.lng.ToString());
                    if (!string.IsNullOrEmpty(json))
                    {
                        return JsonConvert.DeserializeObject<WeatherInfo>(json);
                    }
                    else
                    {
                        return WeatherInfo.GetInstance(null);
                    }

                }
                catch (WeatherDataServiceException e)
                {
                    Console.WriteLine(e.StackTrace);
                }

            }

            return null;
        }

    }
}
