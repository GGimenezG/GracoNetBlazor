using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBlazor.Data.Models
{
    public class Response
    {
        public string? StatusCode { get; set; }
        public object? Data { get; set; }
    }
}