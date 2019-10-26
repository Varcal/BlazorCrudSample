using System;
using System.Collections.Generic;
using BlazoCrudSample.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazoCrudSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheatherForecastController: ControllerBase
    {
        public IActionResult Get()
        {
            var forecasts = new List<WheatherForeCast>()
            {
                new WheatherForeCast()
                {
                    Date = new DateTime(2018, 5, 6),
                    TemperatureC = 1,
                    Summary = "Freezing"
                },
                new WheatherForeCast()
                {
                    Date = new DateTime(2018, 5, 7),
                    TemperatureC = 14,
                    Summary = "Bracing"
                },
                new WheatherForeCast()
                {
                    Date = new DateTime(2018, 5, 8),
                    TemperatureC = 13,
                    Summary = "Freezing"
                },
                new WheatherForeCast()
                {
                    Date = new DateTime(2018, 5, 9),
                    TemperatureC = 16,
                    Summary = "Balmy"
                },
                new WheatherForeCast()
                {
                    Date = new DateTime(2018, 5, 10),
                    TemperatureC = -2,
                    Summary = "Chilly"
                }
            };

            return Ok(forecasts);
        }
    }
}
