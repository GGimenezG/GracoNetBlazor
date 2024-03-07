using AppBlazor.Data.Models;
using Newtonsoft.Json;
using System.Text;

namespace AppBlazor.Data.Services
{
    public class TipoPersonajeService
    {
        public async Task<Response<TipoPersonajeDTO>> Create(TipoPersonajeDTO tipoPersonaje)
        {
            Response<TipoPersonajeDTO> response = new Response<TipoPersonajeDTO>();

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
                    response.Data = JsonConvert.DeserializeObject<TipoPersonajeDTO>(responseContent);
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

        public async Task<Response<List<TipoPersonajeDTO>>> GetAll()
        {
            Response<List<TipoPersonajeDTO>> response = new Response<List<TipoPersonajeDTO>>();
            try
            {

                response = await Consumer
                    .Execute<List<TipoPersonajeDTO>>(
                        "http://localhost:5284/api/TipoPersonaje",
                        methodHttp.GET,
                        null
                    );
                

            }
            catch (Exception ex)
            {

            }
            return response;
        }
    }
}
