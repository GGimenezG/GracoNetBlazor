using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBlazor.Data.Models;
using AppBlazor.Data.Services;
using Microsoft.AspNetCore.Components;


namespace AppBlazor.Components
{
    public class WeatherBase : ComponentBase
    {
        [Parameter]
        public string? Param {get;set;}

        public string message {get;set;} = "Valor inicial";
        public bool control {get;set;}
        public DateTime fecha {get;set;}

        [Inject]
        WeatherForecastService ForecastService { get; set; }

        public WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            if(control){
                // Simulate asynchronous loading to demonstrate streaming rendering
                await Task.Delay(500);
                forecasts = await ForecastService.GetForecastAsync(fecha);
            }
        }

        public override async Task SetParametersAsync(ParameterView parameters)
        {
            if (parameters.TryGetValue<string>(nameof(Param), out var value))
            {
                if (value is not null)
                { 
                    message = $"The value of 'Param' is {value}.";
                    control = true;
                    fecha = DateTime.Now;
                }
                else{
                    control = false;
                    fecha = (DateTime.Now).AddDays(1);
                }
            }
            await base.SetParametersAsync(parameters);
        }
    }
}