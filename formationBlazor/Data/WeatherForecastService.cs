namespace formationBlazor.Data
{
    public class WeatherForecastService
    {

        private static readonly string[] Summaries = new[]
        {
            //"Freezing", "Bracing", "Chilly", "Cool", "Mild",
            //"Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            "Cloudy", "Rainy", "Sunny"
        };
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            var forecasts = new WeatherForecast[5];

            for (var i = 0; i < 5; i++)
            {
                var forecastDate = startDate.AddDays(i);
                var temperatureC = rng.Next(-20, 55);
                var summary = Summaries[rng.Next(Summaries.Length)];

                forecasts[i] = new WeatherForecast
                {
                    Date = forecastDate,
                    TemperatureC = temperatureC,
                    Summary = summary
                };
            }

            return forecasts;
        }

    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
        public bool Selected { get; set; }

    }
}

