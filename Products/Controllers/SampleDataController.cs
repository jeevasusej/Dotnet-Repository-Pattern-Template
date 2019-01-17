using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products.BL.Contracts;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
       
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IUser user;
        public SampleDataController(IUser user)
        {
            this.user = user;
        }

        [HttpGet("[action]")]
        public bool WeatherForecasts()
        {
            user.UpsertUser(new DomainModel.User() { Name="To Test"});
            return true;
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
