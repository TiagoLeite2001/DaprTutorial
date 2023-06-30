using System.Linq;

namespace WeatherMVCFront.Services
{
    public interface IWeatherClient
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
    }
}
