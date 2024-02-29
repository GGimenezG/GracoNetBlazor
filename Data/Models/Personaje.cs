using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Data.Models
{
    public class Personaje
    {
        public int id {get;set;}
        [Required(ErrorMessage = "Por favor indica tu nombre")]
        public  string? nombre {get; set;}
        public int tipoId {get;set;}
        public TipoPersonaje? tipo {get;set;}
        [Range(1, 100, ErrorMessage = "estamina debe estar entre 1 y 100.")]
        public int estamina {get;set;}
        [Range(1, 100, ErrorMessage = "inteligencia debe estar entre 1 y 100.")]
        public int inteligencia {get;set;}
        [Range(1, 100, ErrorMessage = "fuerza debe estar entre 1 y 100.")]
        public int fuerza {get;set;}
        [Range(1, 100, ErrorMessage = "resistencia debe estar entre 1 y 100.")]
        public int resistencia {get;set;}
        [Range(1, 100, ErrorMessage = "defensa debe estar entre 1 y 100.")]
        public int defensa {get;set;}
        public double experiencia {get;set;}
        public int nivel {get;set;}
        public int HP {get;set;}
        public int MP {get;set;}
    }
}