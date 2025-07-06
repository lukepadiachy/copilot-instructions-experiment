using System;
using System.Linq;
using System.Threading.Tasks;
using CopilotWebApp.Interfaces;
using CopilotWebApp.Models;

namespace CopilotWebApp.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherForecast[]> GetForecastAsync()
        {
            await Task.Delay(500); // Simulate async loading
            var startDate = DateOnly.FromDateTime(DateTime.Now);
            var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();
        }
    }
}
