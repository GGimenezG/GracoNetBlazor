using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using AppBlazor.Data.Models;
using Newtonsoft.Json;
using AppBlazor.Data.Services;

namespace AppBlazor.Components
{
    public class PersonajesBase : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation {get;set;}


        [Inject]
        PersonajeService PersonajeService { get; set; }
        public List<Personaje>? lstPersonaje {get;set;}

        protected override async Task OnInitializedAsync()
        {
            lstPersonaje = new List<Personaje>();

            var response = await PersonajeService.GetAll();

            lstPersonaje = response.Data;
            
        }

        public void Create(){
            Navigation.NavigateTo("/personaje/create");
        }
    }
}