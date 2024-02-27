using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazor.Data.Models
{
    public class Personaje
    {
        public int id {get;set;}
        public  string? nombre {get; set;}
        public int tipoId {get;set;}
        public TipoPersonaje? tipo {get;set;}
        public int estamina {get;set;}
        public int inteligencia {get;set;}
        public int fuerza {get;set;}
        public int resistencia {get;set;}
        public int defensa {get;set;}
        public double experiencia {get;set;}
        public int nivel {get;set;}
        public int HP {get;set;}
        public int MP {get;set;}
    }
}