using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatherForecast.BL;
using WatherForecast.Models;

namespace WatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISetForecast _setForecast;
        public WeatherForecastController(ISetForecast setForecast)
        {
            _setForecast = setForecast;
        }
        [HttpGet]
        public IEnumerable<WeatherData> GetRandonForecast()
        {
            _setForecast.SetForecastList(10);
            return _setForecast.GetWeatherForecastList();
        }
    }
}
