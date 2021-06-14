using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatherForecast.Models;

namespace WatherForecast.BL
{
    public abstract class SetForecast: ISetForecast
    {
        protected ICollection<WeatherData> weatherList;
        protected WeatherData weatherData;
        protected Random rnd;
        public SetForecast()
        {
            rnd = new Random();
        }
        public abstract void SetForecastList(int count);
        public abstract void SetForecastData(int addDays);
        public IEnumerable<WeatherData> GetWeatherForecastList()
        {
            return weatherList;
        }
        /// <summary>
        /// Преобразовывает число формата 0.33 в 33%
        /// </summary>
        /// <param name="humidity"></param>
        /// <returns></returns>
        protected virtual string SetHumidityToPercentStyle(double humidity)
        {
            return Math.Round((humidity * 100),0) + "%";
        }
    }
}
