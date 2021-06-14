using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatherForecast.Models
{
    public class WeatherData
    {
        public string Day { get; set; }
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }
        /// <summary>
        ///Давлениемм рт.ст.
        /// </summary>
        public int Pressure { get; set; }
        /// <summary>
        /// Влажность в ?, указывать значение от 0 до 1
        /// </summary>
        public string Humidity { get; set; }
        /// <summary>
        /// Сила ветра
        /// </summary>
        public double WindPower { get; set; }
        /// <summary>
        /// Направление ветра
        /// </summary>
        public string WindDirection { get; set; }
        /// <summary>
        /// Осадки
        /// </summary>
        public string Precipitation { get; set; }
    }
    public enum PrecipitationTypes
    {
        Sunny, Cloudy,Rain,HeavyRain, Thunderstorm
    }
    public enum DirectionTypes
    {
        West,
        East,
        North,
        South
    }

}
