using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using RestSharp;

namespace BLL
{
    public class BWeatherMap
    {
        

        public WeatherMap RestSharp()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("http://api.openweathermap.org/data/2.5/");
            RestRequest req = new RestRequest("weather?q=London,uk&appid=44db6a862fba0b067b1930da0d769e98");
            IRestResponse<WeatherMap> res = client.Get<WeatherMap>(req);

            var content = res.Content;
            WeatherMap wm = new WeatherMap();
            wm = res.Data;

            return wm;
        }
        
    }
}
