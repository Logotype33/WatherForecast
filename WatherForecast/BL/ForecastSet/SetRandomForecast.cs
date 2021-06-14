using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatherForecast.Models;

namespace WatherForecast.BL.ForecastSet
{
    public class SetRandomForecast : SetForecast
    {
        private readonly CultureInfo en;
        public SetRandomForecast()
        {
            en = new CultureInfo("en-US");
        }
        /// <summary>
        /// Устанавить погоду на конкретный день, сегодняшний день+addDays
        /// </summary>
        /// <param name="addDays">сегодняшний день+addDays</param>
        public override void SetForecastData(int addDays)
        {
            //устанавливаю округлённое до 1 симв после запятой число, double от 0 до 1
            double humidity = Math.Round(rnd.NextDouble(), 2);
            weatherData = new WeatherData()
            {
                Day = DateTime.Now.AddDays(addDays).ToString("dd MMMM, dddd",en),
                //устанавливаю значение влажность в виде: (пример: преобразованное 0.8 в вид 80%)
                Humidity= SetHumidityToPercentStyle(humidity),
                MaxTemperature =rnd.Next(5,30),
                //устанавливаю одно из значение enum PrecipitationTypes
                Precipitation = ((PrecipitationTypes)(rnd.Next(0, 4))).ToString(),
                Pressure =rnd.Next(730,770),
                WindDirection= ((DirectionTypes)(rnd.Next(0, 3))).ToString(),
                //устанавливаю округлённое до 1 симв после запятой число,  0-4 + .0-0.9
                WindPower = Math.Round(rnd.NextDouble() + rnd.Next(0, 4),1)
            };
            //устанавливаю мин темп, в зависиомсти от мах темп, от -1 до -7 градусов
            weatherData.MinTemperature = weatherData.MaxTemperature - rnd.Next(1,7);
            //устанавливаю влажность в вид процентов например: 0.8 в 80%
        }
        /// <summary>
        /// Установить рандом погоду на count дней
        /// </summary>
        /// <param name="count">Количество дней</param>
        public override void SetForecastList(int count)
        {
            weatherList = new List<WeatherData>();
            
            for (int i = 0; i < count; i++)
            {
                SetForecastData(i);
                
                weatherList.Add(weatherData);
            }
        }
        
    }
}
