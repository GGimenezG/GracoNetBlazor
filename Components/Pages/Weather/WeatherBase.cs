using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBlazor.Data.Models;
using AppBlazor.Data.Services;
using Microsoft.AspNetCore.Components;


namespace AppBlazor.Components.Pages.Weather
{
    public class WeatherBase : ComponentBase
    {

        [Inject]
        WeatherForecastService ForecastService { get; set; }

        public WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            // Simulate asynchronous loading to demonstrate streaming rendering
            await Task.Delay(500);

             forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }

    }
}