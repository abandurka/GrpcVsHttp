using GrpcVsHttp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GrpcVsHttp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastService _forecastService;

        public WeatherForecastController(WeatherForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() =>
            _forecastService.GetForecast();
    }
}
