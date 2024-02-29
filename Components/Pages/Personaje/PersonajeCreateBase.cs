using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using AppBlazor.Data.Models;
using System.Diagnostics.Contracts;
using AppBlazor.Data.Services;

namespace AppBlazor.Components
{
    public class PersonajeCreateBase : ComponentBase
    {
        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        PersonajeService PersonajeService { get; set; }


        public Personaje personaje = new();
        public string mensaje = "";
        public async Task Post()
        {

            //if (string.IsNullOrEmpty(personaje.Message))
            //{
            //    //no enviamos la información
            //}

            var respuesta = await PersonajeService.CrearPersonaje(personaje);

            if (respuesta.Ok)
            {
                // Process the response data here
                Navigation.NavigateTo("/personajes");

            }
            else
            {
                mensaje = respuesta.Message;
            }

        }
    }
}