using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetherapp
{
    public class WeatherInfo
    {

        private static WeatherInfo instance;
        private WeatherInfo()
        {

        }

        private WeatherInfo(WeatherInfo wi)
        {
            this.clouds = wi.clouds;
            this.cod = wi.cod;
            this.coord = wi.coord;
            this.dt = wi.dt;
            this.id = wi.id;
            this.main = wi.main;
            this.name = wi.name;
            this.rain = wi.rain;
            this.sys = wi.sys;
            this.weather = wi.weather;
            this.wind = wi.wind;
        }

        public override string ToString()
        {
            return "Tempature : " + this.main.temp + " Fahrenheit, In " + this.name;
        }

        public static WeatherInfo GetInstance(WeatherInfo wi)
        {

            if (instance == null)
            {
                if(wi == null){
                   instance = new WeatherInfo();
                } 

                if(wi != null){
                    instance = new WeatherInfo(wi);
                } 
            }
            return instance;
        }        

        public Coord coord { get; set; }
        public Sys sys { get; set; }
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }

        public class Coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class Sys
        {
            public string country { get; set; }
            public double sunrise { get; set; }
            public double sunset { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public double humidity { get; set; }
            public double pressure { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
            public double deg { get; set; }
        }

        public class Rain
        {
            public double _3h { get; set; }
        }

        public class Clouds
        {
            public double all { get; set; }
        }

        public class Weather
        {
            public double id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }


    }
}
