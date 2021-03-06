using Microsoft.AspNetCore.Mvc;

namespace TesteDocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            var weatherForecast = new WeatherForecast()
            {
                Date = DateTime.Now
            };
            return weatherForecast.Date.ToString();
        }
    }
}