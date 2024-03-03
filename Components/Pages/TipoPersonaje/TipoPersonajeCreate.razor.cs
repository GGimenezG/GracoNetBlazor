using AppBlazor.Data.Services;
using Microsoft.AspNetCore.Components;

namespace AppBlazor.Components.Pages.TipoPersonaje
{
    public partial class TipoPersonajeCreate : ComponentBase
    {
        [Parameter]
        public EventCallback OnPersonajeCreado { get; set; }
        public AppBlazor.Data.Models.TipoPersonaje tipoPersonaje { get; set; }


        public async Task Post()
        {
            var respuesta = await TipoPersonajeService.CrearTipoPersonaje(tipoPersonaje);

            if (respuesta.Ok)
            {

                await OnPersonajeCreado.InvokeAsync();
                tipoPersonaje = new();

            }
            else
            {
                mensaje = respuesta.Message;
            }
        }

    }
}
