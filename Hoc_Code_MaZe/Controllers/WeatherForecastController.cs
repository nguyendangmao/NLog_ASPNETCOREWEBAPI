
using Microsoft.AspNetCore.Mvc;
using NlogService;

namespace Hoc_Code_MaZe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger= logger;
        }
        [HttpGet]
        public IEnumerable<WeatherForecast> GetForecasts()
        {
            _logger.LogDebug("ngu lon");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
              
            })
           .ToArray();
        }
    }
}