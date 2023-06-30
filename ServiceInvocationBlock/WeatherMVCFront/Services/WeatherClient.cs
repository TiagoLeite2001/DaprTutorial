namespace WeatherMVCFront.Services
{
    public class WeatherClient : IWeatherClient
    {
        private readonly HttpClient _httpClient;
        public WeatherClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentException(nameof(httpClient));
        }

        public object Value { get; }

        public async Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            return await _httpClient
                .GetFromJsonAsync<IEnumerable<WeatherForecast>>("/weatherforecast");
        }
    }
}
