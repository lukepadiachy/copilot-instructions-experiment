using System.Threading.Tasks;
using CopilotWebApp.Models;

namespace CopilotWebApp.Interfaces
{
    public interface IWeatherService
    {
        Task<WeatherForecast[]> GetForecastAsync();
    }
}
