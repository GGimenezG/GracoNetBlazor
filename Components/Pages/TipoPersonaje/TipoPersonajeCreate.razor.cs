using AppBlazor.Data.Models;
using AppBlazor.Data.Services;
using Microsoft.AspNetCore.Components;

namespace AppBlazor.Components.Pages.TipoPersonaje
{
    public class TipoPersonajeCreateBase : ComponentBase
    {
        [Parameter]
        public EventCallback OnPersonajeCreado { get; set; }

        [Parameter]
        public TipoPersonajeDTO tipoPersonaje { get; set; }

        [Parameter]
        public EventCallback ActualizarLista { get; set; }

        [Inject]
        TipoPersonajeService TipoPersonajeService { get; set; }

        public TipoPersonajeDTO model = new TipoPersonajeDTO();

        protected override async Task OnInitializedAsync()
        {
            model = tipoPersonaje;
        }


        public async Task Post()
        {
            var respuesta = await TipoPersonajeService.Create(tipoPersonaje);

            if (respuesta.Ok)
            {

                await OnPersonajeCreado.InvokeAsync();
                tipoPersonaje = new();

            }
            else
            {
                //mensaje = respuesta.Message;
            }
        }

    }
}
