using Demo.Clean.Arch.Model;
using Demo.Clean.Arch.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Clean.Arch.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IUserLevelRepository _iUserLevelRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUserLevelRepository iUserLevelRepository)
        {
            _logger = logger;
            _iUserLevelRepository = iUserLevelRepository;
        }

        [HttpPost]
        public ActionResult result([FromBody] UserLevelModel model)
        {

            return Ok();
        }


        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _iUserLevelRepository.SaveUserLevel(new Model.UserLevelModel()
            {
                Active = true
            });
            _iUserLevelRepository.DeleteUserLevel(1);

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
