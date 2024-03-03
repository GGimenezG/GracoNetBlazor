﻿using AppBlazor.Data.Models;
using Newtonsoft.Json;
using System.Text;

namespace AppBlazor.Data.Services
{
    public class TipoPersonajeService
    {
        public async Task<Response<TipoPersonaje>> Create(TipoPersonaje tipoPersonaje)
        {
            Response<TipoPersonaje> response = new Response<TipoPersonaje>();

            try
            {
                string apiUrl = "https://localhost:7128/api/TipoPersonaje";
                var data = new StringContent(JsonConvert.SerializeObject(tipoPersonaje), Encoding.UTF8, "application/json");

                HttpClient httpClient = new HttpClient();
                HttpResponseMessage httpResponse = await httpClient.PostAsync(apiUrl, data);
                string responseContent = await httpResponse.Content.ReadAsStringAsync();
                if (httpResponse.IsSuccessStatusCode)
                {
                    response.Ok = true;
                    response.Message = "Tipo de Personaje creado con exito";
                    response.Data = JsonConvert.DeserializeObject<TipoPersonaje>(responseContent);
                }
                else
                {
                    response.Ok = false;
                    Error error = JsonConvert.DeserializeObject<Error>(responseContent);
                    response.Message = error.mensaje;
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }

        public async Task<Response<List<TipoPersonaje>>> GetAll()
        {
            Response<List<TipoPersonaje>> response = new Response<List<TipoPersonaje>>();
            try
            {
                HttpClient httpClient = new HttpClient();

                string apiUrl = "https://localhost:7128/api/TipoPersonaje";
                HttpResponseMessage httpResponse = await httpClient.GetAsync(apiUrl);

                if (httpResponse.IsSuccessStatusCode)
                {
                    string responseContent = await httpResponse.Content.ReadAsStringAsync();

                    response.Data = JsonConvert.DeserializeObject<List<TipoPersonaje>>(responseContent);
                    response.Ok = true;
                    // Process the response data here
                }
                else
                {
                    response.Ok = false;
                    response.Data = new List<TipoPersonaje>();
                }

            }
            catch (Exception ex)
            {

            }
            return response;
        }
    }
}