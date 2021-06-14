using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatherForecast.Models;

namespace WatherForecast.BL
{
    public interface ISetForecast
    {
        public void SetForecastData(int addDays);
        public void SetForecastList(int count);
        public IEnumerable<WeatherData> GetWeatherForecastList();
    }
}
