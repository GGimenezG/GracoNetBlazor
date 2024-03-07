using AppBlazor.Components.Shared;
using AppBlazor.Data.Models;
using AppBlazor.Data.Services;
using Microsoft.AspNetCore.Components;

namespace AppBlazor.Components.Pages.TipoPersonaje
{
    public class TipoPersonajeBase : ComponentBase
    {
        public TipoPersonajeDTO tipoPersonaje = new();

        [Inject]
        public NavigationManager Navigation { get; set; }


        [Inject]
        TipoPersonajeService TipoPersonajeService { get; set; }
        public List<TipoPersonajeDTO>? lstTipoPersonaje { get; set; }

        public bool ShowForm { get; set; }

        public Modal ModalDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetAll();
        }

        public void Create()
        {
            ShowForm = true;
            //Navigation.NavigateTo("/personaje/create");
        }

        public void Update(TipoPersonajeDTO tipoPersonajeDTO)
        {
            ShowForm = true;

            tipoPersonaje = tipoPersonajeDTO;
        }

        public async Task GetAll()
        {
            var response = await TipoPersonajeService.GetAll();

            lstTipoPersonaje = response.Data;

            //return Task.CompletedTask;
        }

    }
}
