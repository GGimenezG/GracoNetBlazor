using AppBlazor.Data.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace AppBlazor.Data.Services
{
    public class PersonajeService
    {
        public async Task<Response<string>> CrearPersonaje(Personaje personaje)
        {
            Response<string> response = new Response<string>();

            try
            {



                response.Message = (await Consumer.Execute<Personaje>("https://localhost:7128/api/Personaje", methodHttp.GET, personaje)).Message;

                //string apiUrl = "https://localhost:7128/api/Personaje";
                //var data = new StringContent(JsonConvert.SerializeObject(personaje), Encoding.UTF8, "application/json");

                //HttpClient httpClient = new HttpClient();
                ////data.Headers.Add("Authorization", "valor");
                //HttpResponseMessage httpResponse = await httpClient.PostAsync(apiUrl, data);
                //string responseContent = await httpResponse.Content.ReadAsStringAsync();
                //if (httpResponse.IsSuccessStatusCode)
                //{
                //    response.Ok = true;
                //    response.Message = "Personaje creado con exito";

                //}
                //else
                //{
                //    response.Ok = false;
                //    response.Message = responseContent;
                //}
                return response;
            }
            catch(Exception ex)
            {

            }
            return response;
        }

        public async Task<Response<List<Personaje>>> GetAll()
        {
            Response<List<Personaje>> response = new Response<List<Personaje>>();
            List<Personaje> lstPersonajes = new List<Personaje>();
            try
            {

                response = await Consumer
                    .Execute<List<Personaje>>(
                        "https://localhost:7128/api/Personaje",
                        methodHttp.GET,
                        lstPersonajes
                    );

            }
            catch(Exception ex)
            {

            }
            return response;
        }
    }
}
