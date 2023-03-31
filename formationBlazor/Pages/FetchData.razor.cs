
using formationBlazor.Data;
using Microsoft.AspNetCore.Components;


namespace formationBlazor.Pages
{
    public partial class FetchData
    {
        [Inject]
        WeatherForecastService ForecastService { get; set; }
        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
